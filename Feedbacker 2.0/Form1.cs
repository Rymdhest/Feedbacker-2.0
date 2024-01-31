using Feedbacker_2._0.Database;
using System.ComponentModel;
using System.Data.SQLite;
using System.Diagnostics;
using System.Text.Json;

namespace Feedbacker_2._0
{
    public partial class Form1 : Form
    {
        //string path = Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory);

        string savedInformationFilePath;
        BindingList<Course> courses = new BindingList<Course>();
        private int lastSelectedCourseIndex = -1; //used as part of a "hack" to allow editing course names in the combobox textfield
        private Boolean needSave = false;
        private SaveData saveData;
        public class SaveData
        {
            public string lastUsedFilePath { get; set; }
            public string signature { get; set; }
            public string gradeAim { get; set; }
            // Add more properties as needed
        }

        public Form1()
        {
            InitializeComponent();
            this.MinimumSize = new Size(795, 350);

            needSave = false;
            this.FormClosing += Form1_FormClosing;

            string appName = "Feedbacker 2.0";
            string appDataPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), appName);
            if (!Directory.Exists(appDataPath))
            {
                Directory.CreateDirectory(appDataPath);
            }
            savedInformationFilePath = Path.Combine(appDataPath, "saved_info.json");


            loadSavedInformation();

            if (File.Exists(saveData.lastUsedFilePath))
            {
                loadDatabaseFromFile(saveData.lastUsedFilePath);
            } else
            {
                createNewProject();
            }
            needSave = false;
        }

        private void saveStoredInformation()
        {
            string json = JsonSerializer.Serialize(saveData);
            File.WriteAllText(savedInformationFilePath, json);
        }

        private bool loadSavedInformation()
        {
            if (File.Exists(savedInformationFilePath))
            {
                string loadedJson = File.ReadAllText(savedInformationFilePath);
                saveData = JsonSerializer.Deserialize<SaveData>(loadedJson);
                return true;
            }
            else
            {
                saveData = new SaveData();
                return false;
            }
        }

        private void Form1_FormClosing(object? sender, FormClosingEventArgs e)
        {
            askToSave();
        }

        private void loadDatabaseFromFile(string filePath)
        {
            saveData.lastUsedFilePath = filePath;
            saveStoredInformation();
            comboBox_courses.DataSource = courses;
            comboBox_courses.DisplayMember = "Name";
            using SQLiteConnection connection = establishDatabaseConnection(filePath);
            string stm = "SELECT * FROM courses";
            using var cmd = new SQLiteCommand(stm, connection);
            SQLiteDataReader reader;
            //making sure there are no errors. IE table cars does not exist yet.
            try
            {
                reader = cmd.ExecuteReader();

            }
            catch (SQLiteException exception)
            {
                Debug.WriteLine(exception.Message);
                return;
            }

            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                string name = reader.GetString(1);
                //string description = rdr.GetString(2);
                string description = "description";
                Course course = new Course(id, name, description);
                courses.Add(course);
            }
            reader.Close();

            foreach (Course course in courses)
            {
                string stm2 = $"SELECT * FROM assignments WHERE CourseId='{course.Id}'";
                using var cmd2 = new SQLiteCommand(stm2, connection);
                SQLiteDataReader rdr2;
                //making sure there are no errors. IE table cars does not exist yet.
                try
                {
                    rdr2 = cmd2.ExecuteReader();

                }
                catch (SQLiteException exception)
                {
                    Debug.WriteLine(exception.Message);
                    return;
                }
                while (rdr2.Read())
                {
                    int id2 = rdr2.GetInt32(0);
                    string name2 = rdr2.GetString(2);
                    int position = rdr2.GetInt32(4);

                    //TODO: attach course inside course.addAssignment();
                    Assignment assignment = new Assignment(id2, name2, "Description", position, course);
                    course.Assignments.Add(assignment);
                }
                rdr2.Close();
            }


            foreach (Course course in courses)
            {
                foreach (Assignment assignment in course.Assignments)
                {
                    string stm3 = $"SELECT * FROM responses WHERE AssignmentId='{assignment.Id}'";
                    using var cmd3 = new SQLiteCommand(stm3, connection);
                    SQLiteDataReader rdr3;
                    //making sure there are no errors. IE table cars does not exist yet.
                    try
                    {
                        rdr3 = cmd3.ExecuteReader();

                    }
                    catch (SQLiteException exception)
                    {
                        Debug.WriteLine(exception.Message);
                        return;
                    }
                    while (rdr3.Read())
                    {
                        int id3 = rdr3.GetInt32(0);
                        string name3 = rdr3.GetString(2);
                        string message = rdr3.GetString(3);

                        //TODO: attach assignment inside assignment.addResponse();
                        Response response = new Response(id3, name3, message, assignment);
                        assignment.Responses.Add(response);
                    }
                    rdr3.Close();
                }

            }
            comboBox_courses.SelectedIndex = -1;
            if (comboBox_courses.Items.Count > 0)
            {
                comboBox_courses.SelectedIndex = 0;
                comboBox_courses.Enabled = true;
                lastSelectedCourseIndex = comboBox_courses.SelectedIndex;
            }
            needSave = false;
        }

        private SQLiteConnection establishDatabaseConnection(string filePath)
        {
            string connectionString = $@"URI=file:{filePath}";
            SQLiteConnection connection = new SQLiteConnection(connectionString);
            connection.Open();
            return connection;
        }

        private void createNewEmptyDatabas(SQLiteConnection connection)
        {
            using var command = new SQLiteCommand(connection);

            command.CommandText = @"CREATE TABLE courses (
                Id INTEGER NOT NULL, 
                CourseName TEXT NOT NULL, 
                CourseDescription TEXT, 
                PRIMARY KEY(Id AUTOINCREMENT))";
            command.ExecuteNonQuery();

            command.CommandText = @"CREATE TABLE assignments (
                Id INTEGER NOT NULL, 
                CourseId INTEGER NOT NULL, 
                AssignmentTitle TEXT NOT NULL, 
                AssignmentDescription TEXT, 
                AssignmentPosition INTEGER, 
                FOREIGN KEY(CourseId) REFERENCES courses(Id), 
                PRIMARY KEY(Id AUTOINCREMENT))";
            command.ExecuteNonQuery();

            command.CommandText = @"CREATE TABLE responses (
                Id INTEGER NOT NULL, 
                AssignmentId  INTEGER NOT NULL, 
                ResponseTitle TEXT NOT NULL, 
                ResponseText TEXT, 
                FOREIGN KEY(AssignmentId) REFERENCES assignments(Id), 
                PRIMARY KEY(Id AUTOINCREMENT))";
            command.ExecuteNonQuery();
        }

        private void insertDataToDatabase(SQLiteConnection connection)
        {
            using var command = new SQLiteCommand(connection);

            foreach (Course course in courses)
            {
                command.CommandText = @$"INSERT INTO courses(CourseName, CourseDescription)
                VALUES(
                    '{course.Name}',
                    '{course.Description}')";
                command.ExecuteNonQuery();
                foreach (Assignment assignment in course.Assignments)
                {

                    command.CommandText = @$"INSERT INTO assignments(CourseId, AssignmentTitle, AssignmentDescription, AssignmentPosition) 
                        VALUES(
                            (SELECT Id FROM courses WHERE CourseName = '{course.Name}'),
                            '{assignment.Name}',
                            '{assignment.Description}',
                            {assignment.Position})";
                    command.ExecuteNonQuery();
                    foreach (Response response in assignment.Responses)
                    {
                        command.CommandText = @$"INSERT INTO responses(AssignmentId, ResponseTitle, ResponseText) 
                            VALUES(
                                (SELECT Id FROM assignments WHERE AssignmentTitle = '{assignment.Name}'),
                                '{response.Name}',
                                '{response.Message}')";
                        command.ExecuteNonQuery();
                    }
                }
            }
        }

        private void dropAllTables(SQLiteConnection connection)
        {
            using var command = new SQLiteCommand(connection);

            command.CommandText = "DROP TABLE IF EXISTS courses";
            command.ExecuteNonQuery();

            command.CommandText = "DROP TABLE IF EXISTS assignments";
            command.ExecuteNonQuery();

            command.CommandText = "DROP TABLE IF EXISTS responses";
            command.ExecuteNonQuery();
        }

        private void saveDatabaseToFile(string filePath)
        {
            using SQLiteConnection connection = establishDatabaseConnection(filePath);
            dropAllTables(connection);
            createNewEmptyDatabas(connection);
            insertDataToDatabase(connection);
            needSave = false;
            saveData.lastUsedFilePath = filePath;
        }


        private void ComboBox_courses_SelectionChangeCommitted(object sender, EventArgs e)
        {
            lastSelectedCourseIndex = comboBox_courses.SelectedIndex;

        }
        private void ComboBox_courses_SelectedIndexChanged(object sender, EventArgs e)
        {


            dataGridView_Assignments.AutoGenerateColumns = false;
            if ((Course)comboBox_courses.SelectedItem != null)
            {
                dataGridView_Assignments.DataSource = ((Course)comboBox_courses.SelectedItem).Assignments;
                dataGridView_Assignments.Enabled = Enabled;
            }
            else
            {
                dataGridView_Responses.Enabled = false;
                dataGridView_Responses.DataSource = null;
                textBox1.Enabled = false;
                textBox1.Text = string.Empty;
            }
        }

        private void DataGridView_Responses_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView_Responses.SelectedRows.Count >= 1)
            {
                if (dataGridView_Responses.SelectedRows[0].DataBoundItem != null)
                {
                    textBox1.Enabled = true;
                    string text = (((Response)dataGridView_Responses.SelectedRows[0].DataBoundItem).Message);
                    textBox1.Text = text;
                }
                else
                {
                    textBox1.Text = string.Empty;
                }
            }
            else
            {
                textBox1.Enabled = false;
            }
        }
        private void DataGridView_Assignments_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView_Assignments.SelectedRows.Count >= 1)
            {
                if (dataGridView_Assignments.SelectedRows[0].DataBoundItem != null)
                {
                    dataGridView_Responses.AutoGenerateColumns = false;
                    dataGridView_Responses.DataSource = ((Assignment)dataGridView_Assignments.SelectedRows[0].DataBoundItem).Responses;
                    dataGridView_Responses.Enabled = true;
                }
                else
                {
                    dataGridView_Responses.DataSource = null;
                    dataGridView_Responses.Enabled = false;
                    textBox1.Text = string.Empty;
                }
            }
            else
            {
                dataGridView_Responses.DataSource = null;
                dataGridView_Responses.Enabled = false;
                textBox1.Text = string.Empty;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (dataGridView_Responses.SelectedRows.Count >= 1)
            {
                if ((Response)dataGridView_Responses.SelectedRows[0].DataBoundItem != null)
                {
                    ((Response)dataGridView_Responses.SelectedRows[0].DataBoundItem).Message = textBox1.Text;
                    needSave = true;
                }
            }

        }




        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (File.Exists(saveData.lastUsedFilePath))
            {
                saveDatabaseToFile(saveData.lastUsedFilePath);
            } else
            {
                saveAs();
            }
        }

        private void saveAs()
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Title = "Save As";
                saveFileDialog.Filter = "Database (.db)|*.db";
                saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;


                    // Save your data to the selected file
                    saveDatabaseToFile(filePath);
                    saveStoredInformation();
                }
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveAs();
        }

        private void askToSave()
        {
            if (needSave)
            {
                DialogResult result = MessageBox.Show("You have not saved some changes. Would you like to save them first?",
                                      "Save Changes", MessageBoxButtons.YesNo);
                switch (result)
                {
                    case DialogResult.Yes:
                        saveAs();
                        break;
                    case DialogResult.No:
                        break;
                }
            }
            needSave = false;
        }
        private void createNewProject()
        {
            askToSave();
            clear();

            comboBox_courses.DataSource = courses;
            comboBox_courses.DisplayMember = "Name";

        }


        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            createNewProject();
        }
        private void ComboBox_courses_TextChanged(object sender, EventArgs e)
        {
            if (lastSelectedCourseIndex >= 0)
            {

                ((Course)comboBox_courses.Items[lastSelectedCourseIndex]).Name = comboBox_courses.Text;
                needSave = true;

            }
        }
        private void clear()
        {
            courses.Clear();
            comboBox_courses.DataSource = null;
            comboBox_courses.Enabled = false;


            dataGridView_Assignments.DataSource = null;
            dataGridView_Assignments.Enabled = false;
            dataGridView_Responses.DataSource = null;
            dataGridView_Responses.Enabled = false;
            textBox1.Text = string.Empty;
            textBox1.Enabled = false;
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Set properties for the OpenFileDialog
            openFileDialog.Title = "Select a File";
            openFileDialog.Filter = "Database (.db)|*.db";
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            // Show the OpenFileDialog and get the result
            DialogResult result = openFileDialog.ShowDialog();

            // Check if the user clicked OK
            if (result == DialogResult.OK)
            {
                clear();
                loadDatabaseFromFile(openFileDialog.FileName);

            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            askToSave();
            System.Windows.Forms.Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Course course = new Course();
            course.Name = "New Course";
            comboBox_courses.Enabled = true;
            courses.Add(course);

            lastSelectedCourseIndex = -1;
            comboBox_courses.SelectedItem = course;
            lastSelectedCourseIndex = comboBox_courses.Items.IndexOf(course);
            comboBox_courses.Focus();
            comboBox_courses.Select(0, comboBox_courses.Text.Length);

            dataGridView_Assignments.AutoGenerateColumns = false;
            dataGridView_Assignments.DataSource = ((Course)comboBox_courses.SelectedItem).Assignments;
            dataGridView_Assignments.Enabled = Enabled;

            needSave = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Enabled == true)
                textBox1.AppendText(Environment.NewLine + Environment.NewLine + "MVH Tomas Berggren");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Enabled == true)
                textBox1.AppendText("Add Grade Aim");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Enabled == true)
                Clipboard.SetText(textBox1.Text);
        }
    }
}
