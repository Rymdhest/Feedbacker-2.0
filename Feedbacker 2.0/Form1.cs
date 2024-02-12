using Feedbacker_2._0.Database;
using System.ComponentModel;
using System.Text.Json;
using System.Windows.Forms;

namespace Feedbacker_2._0
{
    public partial class Form1 : Form
    {

        private string savedInformationFilePath;
        private int lastSelectedCourseIndex = -1; //used as part of a "hack" to allow editing course names in the combobox textfield
        private Boolean needSave = false;
        private SaveData saveData;
        private string programName = "Feedbacker 2.0";
        private DatabaseManager database;



        private int rowHeight = 35;
        /// <summary>
        /// Represents the data that is saved and loaded to/from a file to store the application state.
        /// </summary>
        private class SaveData
        {
            public string lastUsedFilePath { get; set; }
            public string signature { get; set; }
            public string gradeAim { get; set; }
        }
        private class Macro
        {
            public string title { get; set; }
            public string text { get; set; }
        }


        public Form1(DatabaseManager database)
        {
            InitializeComponent();


            var assignmentHandler_Assignments = new DataGridViewDragDropHandler<Assignment>();
            dataGridView_Assignments.MouseDown += (s, e) => assignmentHandler_Assignments.DataGridView_MouseDown(s, e);
            dataGridView_Assignments.MouseMove += (s, e) => assignmentHandler_Assignments.DataGridView_MouseMove(s, e);
            dataGridView_Assignments.DragDrop += (s, e) => assignmentHandler_Assignments.DataGridView_DragDrop(s, e);
            dataGridView_Assignments.DragEnter += (s, e) => assignmentHandler_Assignments.DataGridView_DragEnter(s, e);
            dataGridView_Assignments.DragOver += (s, e) => assignmentHandler_Assignments.DataGridView_DragOver(s, e);
            dataGridView_Assignments.CellPainting += DataGridView_CellPainting;
            dataGridView_Assignments.CellValueChanged += DataGridView_CellValueChanged;
            dataGridView_Assignments.SelectionChanged += DataGridView_Assignments_SelectionChanged;
            dataGridView_Assignments.UserAddedRow += DataGridView_Assignments_SelectionChanged;


            var assignmentHandler_Courses = new DataGridViewDragDropHandler<Course>();
            dataGridView_Courses.MouseDown += (s, e) => assignmentHandler_Courses.DataGridView_MouseDown(s, e);
            dataGridView_Courses.MouseMove += (s, e) => assignmentHandler_Courses.DataGridView_MouseMove(s, e);
            dataGridView_Courses.DragDrop += (s, e) => assignmentHandler_Courses.DataGridView_DragDrop(s, e);
            dataGridView_Courses.DragEnter += (s, e) => assignmentHandler_Courses.DataGridView_DragEnter(s, e);
            dataGridView_Courses.DragOver += (s, e) => assignmentHandler_Courses.DataGridView_DragOver(s, e);
            dataGridView_Courses.CellPainting += DataGridView_CellPainting;
            dataGridView_Courses.CellValueChanged += DataGridView_CellValueChanged;
            dataGridView_Courses.SelectionChanged += DataGridView_Courses_SelectionChanged;
            dataGridView_Courses.UserAddedRow += DataGridView_Courses_SelectionChanged;


            var assignmentHandler_Responses = new DataGridViewDragDropHandler<Response>();
            dataGridView_Responses.MouseDown += (s, e) => assignmentHandler_Responses.DataGridView_MouseDown(s, e);
            dataGridView_Responses.MouseMove += (s, e) => assignmentHandler_Responses.DataGridView_MouseMove(s, e);
            dataGridView_Responses.DragDrop += (s, e) => assignmentHandler_Responses.DataGridView_DragDrop(s, e);
            dataGridView_Responses.DragEnter += (s, e) => assignmentHandler_Responses.DataGridView_DragEnter(s, e);
            dataGridView_Responses.DragOver += (s, e) => assignmentHandler_Responses.DataGridView_DragOver(s, e);
            dataGridView_Responses.CellPainting += DataGridView_CellPainting;
            dataGridView_Responses.CellValueChanged += DataGridView_CellValueChanged;
            dataGridView_Responses.SelectionChanged += DataGridView_Responses_SelectionChanged;
            dataGridView_Responses.UserAddedRow += DataGridView_Responses_SelectionChanged;

            var assignmentHandler_Macros = new DataGridViewDragDropHandler<Macro>();
            dataGridView_Macros.MouseDown += (s, e) => assignmentHandler_Macros.DataGridView_MouseDown(s, e);
            dataGridView_Macros.MouseMove += (s, e) => assignmentHandler_Macros.DataGridView_MouseMove(s, e);
            dataGridView_Macros.DragDrop += (s, e) => assignmentHandler_Macros.DataGridView_DragDrop(s, e);
            dataGridView_Macros.DragEnter += (s, e) => assignmentHandler_Macros.DataGridView_DragEnter(s, e);
            dataGridView_Macros.DragOver += (s, e) => assignmentHandler_Macros.DataGridView_DragOver(s, e);
            dataGridView_Macros.CellPainting += DataGridView_CellPainting;
            dataGridView_Macros.CellValueChanged += DataGridView_CellValueChanged;

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
                //createNewProject();
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
        /// Event handler for cell value changes in a DataGridView.
        /// Marks the need for saving changes.
        /// </summary>
        private void DataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            needSave = true;
        }

        /// <summary>
        /// Loads the database from a specified filepath and populates the GUI with the retrieved data.
        /// </summary>
        /// <param name="filePath">The path to the database file to load.</param>
        private void loadDatabaseFromFile(string filePath)
        {
            saveData.lastUsedFilePath = filePath;
            saveStoredInformation();
            dataGridView_Courses.AutoGenerateColumns = false;



            dataGridView_Courses.DataSource = database.Courses;
            //dataGridView_Courses.ColumnHeadersDefaultCellStyle.BackColor = Color.Red;


            dataGridView_Courses.Refresh();


            database.loadDatabaseFromFile(filePath);


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
                    textBox_Message.Enabled = true;
                    string text = (((Response)dataGridView_Responses.SelectedRows[0].DataBoundItem).Message);
                    textBox_Message.Text = text;
                }
                else
                {
                    textBox_Message.Text = string.Empty;
                }
            }
            else
            {
                textBox_Message.Enabled = false;
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
                    textBox_Message.Text = string.Empty;
                }
            }
            else
            {
                dataGridView_Responses.DataSource = null;
                dataGridView_Responses.Enabled = false;
                textBox_Message.Text = string.Empty;
            }
        }

        private void DataGridView_Courses_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView_Courses.SelectedRows.Count >= 1)
            {
                if (dataGridView_Courses.SelectedRows[0].DataBoundItem != null)
                {
                    dataGridView_Assignments.AutoGenerateColumns = false;
                    dataGridView_Assignments.DataSource = ((Course)dataGridView_Courses.SelectedRows[0].DataBoundItem).assignments;
                    dataGridView_Assignments.Enabled = true;
                }
                else
                {
                    dataGridView_Assignments.DataSource = null;
                    dataGridView_Assignments.Enabled = false;
                    textBox_Message.Text = string.Empty;
                }
            }
            else
            {
                dataGridView_Assignments.DataSource = null;
                dataGridView_Assignments.Enabled = false;
                textBox_Message.Text = string.Empty;
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
                    ((Response)dataGridView_Responses.SelectedRows[0].DataBoundItem).Message = textBox_Message.Text;
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
            }
            else
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
        /// Clears existing data in the application, resetting it to a clean state.
        /// </summary>
        private void clear()
        {
            database.Courses.Clear();
            dataGridView_Courses.DataSource = null;
            dataGridView_Courses.DataSource = database.Courses;

            dataGridView_Assignments.DataSource = null;
            dataGridView_Assignments.Enabled = false;
            dataGridView_Responses.DataSource = null;
            dataGridView_Responses.Enabled = false;
            textBox_Message.Text = string.Empty;
            textBox_Message.Enabled = false;

            label_courses_small.Text = "Courses";

            lastSelectedCourseIndex = -1;
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
        /// Event handler for the Click event of the "Add Signature" button.
        /// Appends a predefined signature to the feedback message text box.
        /// </summary>
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox_Message.Enabled == true)
                textBox_Message.AppendText(Environment.NewLine + Environment.NewLine + saveData.signature);
        }

        /// <summary>
        /// Event handler for the Click event of the "Add Grade Aim" button.
        /// Appends a predefined message indicating the addition of a grade aim to the feedback message text box.
        /// </summary>
        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView_Responses.Visible = false;
            if (textBox_Message.Enabled == true)
                textBox_Message.AppendText(Environment.NewLine + Environment.NewLine + saveData.gradeAim);
        }

        /// <summary>
        /// Event handler for the Click event of the "Copy to Clipboard" button.
        /// Copies the content of the feedback message text box to the clipboard.
        /// </summary>
        private void copyClipboardButton_Click(object sender, EventArgs e)
        {
            if (textBox_Message.Enabled == true && textBox_Message.Text != string.Empty)
                Clipboard.SetText(textBox_Message.Text);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            label3.Visible = false;
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

            string text = "Courses";
            if (dataGridView_Courses.SelectedRows.Count > 0)
            {
                if (dataGridView_Courses.SelectedRows[0].DataBoundItem != null)
                {
                    text = ((Course)dataGridView_Courses.SelectedRows[0].DataBoundItem).Name;
                }
            }
            label_courses_small.Text = text;
            panel_courses.Visible = false;
            panel_courses_small.Visible = true;
            recalculateMessageLayoutSize();
        }

        private void label_courses_small_Click(object sender, EventArgs e)
        {
            panel_courses.Visible = true;
            panel_courses_small.Visible = false;
            recalculateMessageLayoutSize();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            panel_macros.Visible = false;
            panel_macros_small.Visible = true;
            recalculateMessageLayoutSize();
        }

        private void label_macros_small_Click(object sender, EventArgs e)
        {
            panel_macros.Visible = true;
            panel_macros_small.Visible = false;
            recalculateMessageLayoutSize();
        }
    }

}
