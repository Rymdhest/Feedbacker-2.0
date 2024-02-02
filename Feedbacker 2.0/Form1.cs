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
        private int lastSelectedCourseIndex = -1; //used as part of a "hack" to allow editing course names in the combobox textfield
        private Boolean needSave = false;
        private SaveData saveData;
        private string programName = "Feedbacker 2.0";
        private DatabaseManager database;

        public class SaveData
        {
            public string lastUsedFilePath { get; set; }
            public string signature { get; set; }
            public string gradeAim { get; set; }
        }

        public Form1(DatabaseManager database)
        {
            InitializeComponent();
            this.database = database;


            needSave = false;

            string appDataPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), programName);
            if (!Directory.Exists(appDataPath))
            {
                Directory.CreateDirectory(appDataPath);
            }
            savedInformationFilePath = Path.Combine(appDataPath, "saved_info.json");


            loadSavedInformation();

            if (File.Exists(saveData.lastUsedFilePath))
            {
                loadDatabaseFromFile(saveData.lastUsedFilePath);
            }
            else
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
        private void DataGridView_Responses_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            needSave = true;
        }
        private void loadDatabaseFromFile(string filePath)
        {
            saveData.lastUsedFilePath = filePath;
            saveStoredInformation();
            comboBox_courses.DataSource = database.Courses;
            comboBox_courses.DisplayMember = "Name";

            database.loadDatabaseFromFile(filePath);

            comboBox_courses.SelectedIndex = -1;
            if (comboBox_courses.Items.Count > 0)
            {
                comboBox_courses.SelectedIndex = 0;
                comboBox_courses.Enabled = true;
                lastSelectedCourseIndex = comboBox_courses.SelectedIndex;
            }
            needSave = false;
        }

        private void saveDatabaseToFile(string filePath)
        {
            database.saveDatabaseToFile(filePath);
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

            comboBox_courses.DataSource = database.Courses;
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
            database.Courses.Clear();
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
            comboBox_courses.Enabled = true;
            database.Courses.Add(course);

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
