using Feedbacker_2._0.Database;
using System.Text.Json;

namespace Feedbacker_2._0
{
    public partial class Form1 : Form
    {

        string savedInformationFilePath;
        private int lastSelectedCourseIndex = -1; //used as part of a "hack" to allow editing course names in the combobox textfield
        private Boolean needSave = false;
        private SaveData saveData;
        private string programName = "Feedbacker 2.0";
        private DatabaseManager database;

        /// <summary>
        /// Represents the data that is saved and loaded to/from a file to store the application state.
        /// </summary>
        private class SaveData
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

        /// <summary>
        /// Saves the stored information to a JSON file.
        /// </summary>
        private void saveStoredInformation()
        {
            string json = JsonSerializer.Serialize(saveData);
            File.WriteAllText(savedInformationFilePath, json);
        }

        /// <summary>
        /// Loads previously saved information from a JSON file.
        /// </summary>
        /// <returns>True if saved information was loaded successfully; otherwise, false.</returns>

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

        /// <summary>
        /// Event handler for the form closing event.
        /// Prompts the user to save changes before closing if necessary.
        /// </summary>
        private void Form1_FormClosing(object? sender, FormClosingEventArgs e)
        {
            tryAskToSave();
        }

        /// <summary>
        /// Event handler for cell value changes in the DataGridView_Responses.
        /// Marks the need for saving changes.
        /// </summary>
        private void DataGridView_Responses_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            needSave = true;
        }

        /// <summary>
        /// Loads the database from a specified filepath and populates the UI with the retrieved data.
        /// </summary>
        /// <param name="filePath">The path to the database file to load.</param>
        private void loadDatabaseFromFile(string filePath)
        {
            saveData.lastUsedFilePath = filePath;
            saveStoredInformation();
            comboBox_courses.DataSource = database.Courses;
            comboBox_courses.DisplayMember = "Name";

            database.loadDatabaseFromFile(filePath);


            comboBox_courses.SelectedIndex = -1;
            // default select the first course if there is one
            if (comboBox_courses.Items.Count > 0)
            {
                comboBox_courses.SelectedIndex = 0;
                comboBox_courses.Enabled = true;
                lastSelectedCourseIndex = comboBox_courses.SelectedIndex;
            }

            needSave = false;
        }

        /// <summary>
        /// Saves the current state of the database to the specified file.
        /// </summary>
        /// <param name="filePath">The path to the file where the database will be saved.</param>
        private void saveDatabaseToFile(string filePath)
        {
            database.saveDatabaseToFile(filePath);
            needSave = false;
            saveData.lastUsedFilePath = filePath;
        }

        /// <summary>
        /// Event handler for the SelectionChangeCommitted event of the courses ComboBox.
        /// Updates the lastSelectedCourseIndex when the user selects a different course.
        /// This is part of a hack to allow for changing course names in the combobox.
        /// </summary>
        private void ComboBox_courses_SelectionChangeCommitted(object sender, EventArgs e)
        {
            lastSelectedCourseIndex = comboBox_courses.SelectedIndex;

        }

        /// <summary>
        /// Event handler for the SelectedIndexChanged event of the courses ComboBox.
        /// Populates the assignments DataGridView if a valid course was selected.
        /// Otherwise depopulates the responses.
        /// </summary>
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

        /// <summary>
        /// Event handler for the SelectionChanged event of the responses DataGridView.
        /// Updates the text box with the selected response's message when a valid response is selected.
        /// </summary>
        private void DataGridView_Responses_SelectionChanged(object sender, EventArgs e)
        {
            //do we have anything selected?
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

        /// <summary>
        /// Event handler for the SelectionChanged event of the assignments DataGridView.
        /// Populates the responses DataGridView if a valid assignment is selected.
        /// </summary>
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

        /// <summary>
        /// Event handler for the TextChanged event of the feedback text box.
        /// Updates the message of the selected response when the text in the text box changes.
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

        /// <summary>
        /// Event handler for the Click event of the "Save" ToolStripMenuItem.
        /// Saves the database to the last used file path or prompts the user to
        /// choose a new file path if no previous savefile exists.
        /// </summary>
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

        /// <summary>
        /// Opens a SaveFileDialog to allow the user to choose a new file path and saves the database to that path.
        /// </summary>
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

        /// <summary>
        /// Event handler for the Click event of the "Save As" ToolStripMenuItem.
        /// Opens a SaveFileDialog to allow the user to choose a new file path and saves the database to that path.
        /// </summary>
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveAs();
        }

        /// <summary>
        /// If changes are detected, prompts the user to save them before proceeding.
        /// </summary>
        private void tryAskToSave()
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

        /// <summary>
        /// Creates a new project, clearing existing data and prompting the user to save changes if needed.
        /// </summary>
        private void createNewProject()
        {
            tryAskToSave();
            clear();
            comboBox_courses.DataSource = database.Courses;
            comboBox_courses.DisplayMember = "Name";
        }

        /// <summary>
        /// Event handler for the Click event of the "New" ToolStripMenuItem.
        /// Creates a new project by clearing existing data and prompting the user to save changes if needed.
        /// </summary>
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            createNewProject();
        }

        /// <summary>
        /// Event handler for the TextChanged event of the courses ComboBox.
        /// Updates the name of the course when the user edits the name in the combobox.
        /// </summary>
        private void ComboBox_courses_TextChanged(object sender, EventArgs e)
        {
            if (lastSelectedCourseIndex >= 0)
            {
                //need to use lastSelectedCourseIndex because changing the combobox text puts the selected index to -1.
                ((Course)comboBox_courses.Items[lastSelectedCourseIndex]).Name = comboBox_courses.Text;
                needSave = true;
            }
        }

        /// <summary>
        /// Clears existing data in the application, resetting it to a clean state.
        /// </summary>
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

        /// <summary>
        /// Event handler for the Click event of the "Load" ToolStripMenuItem.
        /// Prompts the user to select a database file and loads its contents into the application.
        /// </summary>
        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            //properties for the OpenFileDialog
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

        /// <summary>
        /// Event handler for the Click event of the "Exit" ToolStripMenuItem.
        /// Prompts the user to save changes, if needed, before exiting the application.
        /// </summary>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tryAskToSave();
            System.Windows.Forms.Application.Exit();
        }

        /// <summary>
        /// Event handler for the Click event of the "Add Course" button.
        /// Adds a new course to the application and selects it.
        /// </summary>
        private void newCourseButton_Click(object sender, EventArgs e)
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

        /// <summary>
        /// Event handler for the Click event of the "Add Signature" button.
        /// Appends a predefined signature to the feedback message text box.
        /// </summary>
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Enabled == true)
                textBox1.AppendText(Environment.NewLine + Environment.NewLine + "MVH Tomas Berggren");
        }

        /// <summary>
        /// Event handler for the Click event of the "Add Grade Aim" button.
        /// Appends a predefined message indicating the addition of a grade aim to the feedback message text box.
        /// </summary>
        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Enabled == true)
                textBox1.AppendText("Add Grade Aim");
        }

        /// <summary>
        /// Event handler for the Click event of the "Copy to Clipboard" button.
        /// Copies the content of the feedback message text box to the clipboard.
        /// </summary>
        private void copyClipboardButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Enabled == true)
                Clipboard.SetText(textBox1.Text);
        }
    }
}
