using Feedbacker_2._0.Database;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace Feedbacker_2._0
{
    partial class Form1
    {
        public static class CustomColors
        {
            public static Color blue_light { get; } = Color.FromArgb(185, 224, 245);
            public static Color blue_dark { get; } = Color.FromArgb(23, 87, 146);
            public static Color deep_gray { get; } = Color.FromArgb(240, 240, 240);
            
            
        }

        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
            textBox_Message = new TextBox();
            bindingSource1 = new BindingSource(components);
            dataGridView_Assignments = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            loadToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            saveAsToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            copyClipboardButton = new Button();
            databaseManagerBindingSource = new BindingSource(components);
            dataGridView_Responses = new DataGridView();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridView_Macros = new DataGridView();
            Play = new DataGridViewImageColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            editColumn = new DataGridViewImageColumn();
            label_Message = new Label();
            label_responses = new Label();
            label_assignments = new Label();
            label_macros = new Label();
            dataGridView_Courses = new DataGridView();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            panel_courses = new Panel();
            label_courses = new Label();
            panel_assignments = new Panel();
            panel_responses = new Panel();
            panel_message = new Panel();
            panel_macros = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel_courses_small = new Panel();
            label_courses_small = new Label();
            panel_macros_small = new Panel();
            label_macros_small = new Label();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Assignments).BeginInit();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)databaseManagerBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Responses).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Macros).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Courses).BeginInit();
            panel_courses.SuspendLayout();
            panel_assignments.SuspendLayout();
            panel_responses.SuspendLayout();
            panel_message.SuspendLayout();
            panel_macros.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panel_courses_small.SuspendLayout();
            panel_macros_small.SuspendLayout();
            SuspendLayout();
            // 
            // textBox_Message
            // 
            textBox_Message.AcceptsReturn = true;
            textBox_Message.AcceptsTab = true;
            textBox_Message.AllowDrop = true;
            textBox_Message.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox_Message.BorderStyle = BorderStyle.None;
            textBox_Message.Location = new Point(0, 34);
            textBox_Message.Margin = new Padding(0);
            textBox_Message.Multiline = true;
            textBox_Message.Name = "textBox_Message";
            textBox_Message.Size = new Size(260, 740);
            textBox_Message.TabIndex = 2;
            textBox_Message.TextChanged += textBox1_TextChanged;
            // 
            // dataGridView_Assignments
            // 
            dataGridView_Assignments.AllowDrop = true;
            dataGridView_Assignments.AllowUserToOrderColumns = true;
            dataGridView_Assignments.AllowUserToResizeColumns = false;
            dataGridView_Assignments.AllowUserToResizeRows = false;
            dataGridView_Assignments.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView_Assignments.BackgroundColor = Color.FromArgb(240, 240, 240);
            dataGridView_Assignments.BorderStyle = BorderStyle.None;
            dataGridView_Assignments.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView_Assignments.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(23, 87, 146);
            dataGridViewCellStyle9.Font = new Font("Tahoma", 21F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = Color.White;
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(105, 164, 219);
            dataGridViewCellStyle9.SelectionForeColor = Color.Black;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dataGridView_Assignments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridView_Assignments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Assignments.ColumnHeadersVisible = false;
            dataGridView_Assignments.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1 });
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = SystemColors.Window;
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = Color.Black;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.False;
            dataGridView_Assignments.DefaultCellStyle = dataGridViewCellStyle10;
            dataGridView_Assignments.EnableHeadersVisualStyles = false;
            dataGridView_Assignments.GridColor = Color.White;
            dataGridView_Assignments.Location = new Point(0, 34);
            dataGridView_Assignments.Margin = new Padding(0);
            dataGridView_Assignments.MultiSelect = false;
            dataGridView_Assignments.Name = "dataGridView_Assignments";
            dataGridView_Assignments.RowHeadersVisible = false;
            dataGridView_Assignments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_Assignments.Size = new Size(260, 740);
            dataGridView_Assignments.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn1.DataPropertyName = "Name";
            dataGridViewTextBoxColumn1.HeaderText = "Assignments";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1324, 24);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, loadToolStripMenuItem, saveToolStripMenuItem, saveAsToolStripMenuItem, toolStripSeparator1, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Image = (Image)resources.GetObject("newToolStripMenuItem.Image");
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(114, 22);
            newToolStripMenuItem.Text = "New";
            newToolStripMenuItem.Click += newToolStripMenuItem_Click;
            // 
            // loadToolStripMenuItem
            // 
            loadToolStripMenuItem.Image = Properties.Resources.icons8_open_file_40;
            loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            loadToolStripMenuItem.Size = new Size(114, 22);
            loadToolStripMenuItem.Text = "Load";
            loadToolStripMenuItem.Click += loadToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Image = Properties.Resources.icons8_save_48;
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(114, 22);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Image = Properties.Resources.icons8_save_as_48;
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.Size = new Size(114, 22);
            saveAsToolStripMenuItem.Text = "Save As";
            saveAsToolStripMenuItem.Click += saveAsToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(111, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Image = Properties.Resources.icons8_exit_48;
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(114, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // copyClipboardButton
            // 
            copyClipboardButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            copyClipboardButton.Location = new Point(225, 0);
            copyClipboardButton.Name = "copyClipboardButton";
            copyClipboardButton.Size = new Size(35, 34);
            copyClipboardButton.TabIndex = 10;
            copyClipboardButton.Text = "Copy to Clipboard";
            copyClipboardButton.UseVisualStyleBackColor = true;
            copyClipboardButton.Click += copyClipboardButton_Click;
            // 
            // databaseManagerBindingSource
            // 
            databaseManagerBindingSource.DataSource = typeof(DatabaseManager);
            // 
            // dataGridView_Responses
            // 
            dataGridView_Responses.AllowDrop = true;
            dataGridView_Responses.AllowUserToOrderColumns = true;
            dataGridView_Responses.AllowUserToResizeColumns = false;
            dataGridView_Responses.AllowUserToResizeRows = false;
            dataGridView_Responses.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView_Responses.BackgroundColor = Color.FromArgb(240, 240, 240);
            dataGridView_Responses.BorderStyle = BorderStyle.None;
            dataGridView_Responses.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView_Responses.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = Color.FromArgb(23, 87, 146);
            dataGridViewCellStyle11.Font = new Font("Tahoma", 21F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle11.ForeColor = Color.White;
            dataGridViewCellStyle11.SelectionBackColor = Color.FromArgb(105, 164, 219);
            dataGridViewCellStyle11.SelectionForeColor = Color.Black;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
            dataGridView_Responses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            dataGridView_Responses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Responses.ColumnHeadersVisible = false;
            dataGridView_Responses.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn4 });
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = SystemColors.Window;
            dataGridViewCellStyle12.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle12.ForeColor = Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = Color.Black;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.False;
            dataGridView_Responses.DefaultCellStyle = dataGridViewCellStyle12;
            dataGridView_Responses.EnableHeadersVisualStyles = false;
            dataGridView_Responses.GridColor = Color.White;
            dataGridView_Responses.Location = new Point(0, 34);
            dataGridView_Responses.Margin = new Padding(0);
            dataGridView_Responses.MultiSelect = false;
            dataGridView_Responses.Name = "dataGridView_Responses";
            dataGridView_Responses.RowHeadersVisible = false;
            dataGridView_Responses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_Responses.Size = new Size(260, 740);
            dataGridView_Responses.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn4.DataPropertyName = "Name";
            dataGridViewTextBoxColumn4.HeaderText = "Responses";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridView_Macros
            // 
            dataGridView_Macros.AllowDrop = true;
            dataGridView_Macros.AllowUserToOrderColumns = true;
            dataGridView_Macros.AllowUserToResizeColumns = false;
            dataGridView_Macros.AllowUserToResizeRows = false;
            dataGridView_Macros.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView_Macros.BackgroundColor = Color.FromArgb(240, 240, 240);
            dataGridView_Macros.BorderStyle = BorderStyle.None;
            dataGridView_Macros.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView_Macros.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = Color.FromArgb(23, 87, 146);
            dataGridViewCellStyle13.Font = new Font("Tahoma", 21F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle13.ForeColor = Color.White;
            dataGridViewCellStyle13.SelectionBackColor = Color.FromArgb(105, 164, 219);
            dataGridViewCellStyle13.SelectionForeColor = Color.Black;
            dataGridViewCellStyle13.WrapMode = DataGridViewTriState.True;
            dataGridView_Macros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            dataGridView_Macros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Macros.ColumnHeadersVisible = false;
            dataGridView_Macros.Columns.AddRange(new DataGridViewColumn[] { Play, dataGridViewTextBoxColumn2, editColumn });
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = SystemColors.Window;
            dataGridViewCellStyle14.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle14.ForeColor = Color.Black;
            dataGridViewCellStyle14.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = Color.Black;
            dataGridViewCellStyle14.WrapMode = DataGridViewTriState.False;
            dataGridView_Macros.DefaultCellStyle = dataGridViewCellStyle14;
            dataGridView_Macros.EnableHeadersVisualStyles = false;
            dataGridView_Macros.GridColor = Color.White;
            dataGridView_Macros.Location = new Point(0, 34);
            dataGridView_Macros.Margin = new Padding(0);
            dataGridView_Macros.MultiSelect = false;
            dataGridView_Macros.Name = "dataGridView_Macros";
            dataGridView_Macros.RowHeadersVisible = false;
            dataGridView_Macros.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_Macros.Size = new Size(260, 0);
            dataGridView_Macros.TabIndex = 14;
            dataGridView_Macros.CellClick += DataGridView_Macros_CellClick;
            dataGridView_Macros.CellEndEdit += DataGridView_Macros_CellEndEdit;
            dataGridView_Macros.RowsAdded += DataGridView_Macros_RowsAdded;
            dataGridView_Macros.SelectionChanged += DataGridView_Macros_SelectionChanged;
            dataGridView_Macros.UserAddedRow += DataGridView_Macros_UserAddedRow;
            // 
            // Play
            // 
            Play.HeaderText = "Column1";
            Play.Image = Properties.Resources.icons8_play_50;
            Play.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Play.Name = "Play";
            Play.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn2.DataPropertyName = "title";
            dataGridViewTextBoxColumn2.HeaderText = "Macros";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // editColumn
            // 
            editColumn.HeaderText = "Column2";
            editColumn.Image = Properties.Resources.icons8_edit_50__1_;
            editColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            editColumn.Name = "editColumn";
            editColumn.Width = 50;
            // 
            // label_Message
            // 
            label_Message.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label_Message.BackColor = Color.FromArgb(23, 87, 146);
            label_Message.Font = new Font("Segoe UI", 21F, FontStyle.Regular, GraphicsUnit.Point);
            label_Message.ForeColor = Color.White;
            label_Message.Location = new Point(0, 0);
            label_Message.Margin = new Padding(0);
            label_Message.Name = "label_Message";
            label_Message.Size = new Size(260, 34);
            label_Message.TabIndex = 15;
            label_Message.Text = "Message";
            label_Message.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label_responses
            // 
            label_responses.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label_responses.BackColor = Color.FromArgb(23, 87, 146);
            label_responses.Font = new Font("Segoe UI", 21F, FontStyle.Regular, GraphicsUnit.Point);
            label_responses.ForeColor = Color.White;
            label_responses.Location = new Point(0, 0);
            label_responses.Margin = new Padding(0);
            label_responses.Name = "label_responses";
            label_responses.Size = new Size(260, 34);
            label_responses.TabIndex = 16;
            label_responses.Text = "Responses";
            label_responses.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label_assignments
            // 
            label_assignments.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label_assignments.BackColor = Color.FromArgb(23, 87, 146);
            label_assignments.Font = new Font("Segoe UI", 21F, FontStyle.Regular, GraphicsUnit.Point);
            label_assignments.ForeColor = Color.White;
            label_assignments.Location = new Point(0, 0);
            label_assignments.Margin = new Padding(0);
            label_assignments.Name = "label_assignments";
            label_assignments.Size = new Size(260, 34);
            label_assignments.TabIndex = 17;
            label_assignments.Text = "Assignments";
            label_assignments.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label_macros
            // 
            label_macros.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label_macros.BackColor = Color.FromArgb(23, 87, 146);
            label_macros.Font = new Font("Segoe UI", 21F, FontStyle.Regular, GraphicsUnit.Point);
            label_macros.ForeColor = Color.White;
            label_macros.Location = new Point(0, 0);
            label_macros.Margin = new Padding(0);
            label_macros.Name = "label_macros";
            label_macros.Size = new Size(260, 34);
            label_macros.TabIndex = 19;
            label_macros.Text = "Macros";
            label_macros.TextAlign = ContentAlignment.MiddleCenter;
            label_macros.Click += label4_Click;
            // 
            // dataGridView_Courses
            // 
            dataGridView_Courses.AllowUserToOrderColumns = true;
            dataGridView_Courses.AllowUserToResizeColumns = false;
            dataGridView_Courses.AllowUserToResizeRows = false;
            dataGridView_Courses.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView_Courses.BackgroundColor = Color.FromArgb(240, 240, 240);
            dataGridView_Courses.BorderStyle = BorderStyle.None;
            dataGridView_Courses.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView_Courses.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = Color.FromArgb(23, 87, 146);
            dataGridViewCellStyle15.Font = new Font("Tahoma", 21F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle15.ForeColor = Color.White;
            dataGridViewCellStyle15.SelectionBackColor = Color.FromArgb(105, 164, 219);
            dataGridViewCellStyle15.SelectionForeColor = Color.Black;
            dataGridViewCellStyle15.WrapMode = DataGridViewTriState.True;
            dataGridView_Courses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle15;
            dataGridView_Courses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Courses.ColumnHeadersVisible = false;
            dataGridView_Courses.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn3 });
            dataGridViewCellStyle16.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = SystemColors.Window;
            dataGridViewCellStyle16.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle16.ForeColor = Color.Black;
            dataGridViewCellStyle16.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = Color.Black;
            dataGridViewCellStyle16.WrapMode = DataGridViewTriState.False;
            dataGridView_Courses.DefaultCellStyle = dataGridViewCellStyle16;
            dataGridView_Courses.EnableHeadersVisualStyles = false;
            dataGridView_Courses.GridColor = Color.White;
            dataGridView_Courses.Location = new Point(0, 34);
            dataGridView_Courses.Margin = new Padding(0);
            dataGridView_Courses.MultiSelect = false;
            dataGridView_Courses.Name = "dataGridView_Courses";
            dataGridView_Courses.RowHeadersVisible = false;
            dataGridView_Courses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_Courses.Size = new Size(260, 740);
            dataGridView_Courses.TabIndex = 12;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn3.DataPropertyName = "Name";
            dataGridViewTextBoxColumn3.HeaderText = "Courses";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // panel_courses
            // 
            panel_courses.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel_courses.Controls.Add(label_courses);
            panel_courses.Controls.Add(dataGridView_Courses);
            panel_courses.Location = new Point(37, 0);
            panel_courses.Margin = new Padding(0, 0, 3, 0);
            panel_courses.Name = "panel_courses";
            panel_courses.Size = new Size(260, 774);
            panel_courses.TabIndex = 20;
            // 
            // label_courses
            // 
            label_courses.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label_courses.BackColor = Color.FromArgb(23, 87, 146);
            label_courses.Font = new Font("Segoe UI", 21F, FontStyle.Regular, GraphicsUnit.Point);
            label_courses.ForeColor = Color.White;
            label_courses.Location = new Point(0, 0);
            label_courses.Margin = new Padding(0);
            label_courses.Name = "label_courses";
            label_courses.Size = new Size(260, 34);
            label_courses.TabIndex = 21;
            label_courses.Text = "Courses";
            label_courses.TextAlign = ContentAlignment.MiddleCenter;
            label_courses.Click += label3_Click_1;
            // 
            // panel_assignments
            // 
            panel_assignments.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel_assignments.Controls.Add(label_assignments);
            panel_assignments.Controls.Add(dataGridView_Assignments);
            panel_assignments.Location = new Point(303, 0);
            panel_assignments.Margin = new Padding(3, 0, 3, 0);
            panel_assignments.Name = "panel_assignments";
            panel_assignments.Size = new Size(260, 774);
            panel_assignments.TabIndex = 21;
            // 
            // panel_responses
            // 
            panel_responses.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel_responses.Controls.Add(label_responses);
            panel_responses.Controls.Add(dataGridView_Responses);
            panel_responses.Location = new Point(569, 0);
            panel_responses.Margin = new Padding(3, 0, 3, 0);
            panel_responses.Name = "panel_responses";
            panel_responses.Size = new Size(260, 774);
            panel_responses.TabIndex = 22;
            // 
            // panel_message
            // 
            panel_message.Controls.Add(copyClipboardButton);
            panel_message.Controls.Add(label_Message);
            panel_message.Controls.Add(textBox_Message);
            panel_message.Location = new Point(835, 0);
            panel_message.Margin = new Padding(3, 0, 3, 0);
            panel_message.Name = "panel_message";
            panel_message.Size = new Size(260, 774);
            panel_message.TabIndex = 23;
            // 
            // panel_macros
            // 
            panel_macros.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel_macros.Controls.Add(label_macros);
            panel_macros.Controls.Add(dataGridView_Macros);
            panel_macros.Location = new Point(3, 774);
            panel_macros.Margin = new Padding(3, 0, 0, 0);
            panel_macros.Name = "panel_macros";
            panel_macros.Size = new Size(260, 0);
            panel_macros.TabIndex = 24;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(panel_courses_small);
            flowLayoutPanel1.Controls.Add(panel_courses);
            flowLayoutPanel1.Controls.Add(panel_assignments);
            flowLayoutPanel1.Controls.Add(panel_responses);
            flowLayoutPanel1.Controls.Add(panel_message);
            flowLayoutPanel1.Controls.Add(panel_macros);
            flowLayoutPanel1.Controls.Add(panel_macros_small);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 24);
            flowLayoutPanel1.Margin = new Padding(0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1324, 774);
            flowLayoutPanel1.TabIndex = 25;
            flowLayoutPanel1.SizeChanged += FlowLayoutPanel1_SizeChanged;
            // 
            // panel_courses_small
            // 
            panel_courses_small.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel_courses_small.Controls.Add(label_courses_small);
            panel_courses_small.Location = new Point(0, 0);
            panel_courses_small.Margin = new Padding(0, 0, 3, 0);
            panel_courses_small.Name = "panel_courses_small";
            panel_courses_small.Size = new Size(34, 774);
            panel_courses_small.TabIndex = 26;
            panel_courses_small.Visible = false;
            // 
            // label_courses_small
            // 
            label_courses_small.BackColor = Color.FromArgb(23, 87, 146);
            label_courses_small.Dock = DockStyle.Fill;
            label_courses_small.Font = new Font("Segoe UI", 21F, FontStyle.Regular, GraphicsUnit.Point);
            label_courses_small.ForeColor = Color.White;
            label_courses_small.Location = new Point(0, 0);
            label_courses_small.Margin = new Padding(0, 0, 3, 0);
            label_courses_small.Name = "label_courses_small";
            label_courses_small.Size = new Size(34, 774);
            label_courses_small.TabIndex = 20;
            label_courses_small.Text = "Courses";
            label_courses_small.TextAlign = ContentAlignment.MiddleCenter;
            label_courses_small.Click += label_courses_small_Click;
            // 
            // panel_macros_small
            // 
            panel_macros_small.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel_macros_small.Controls.Add(label_macros_small);
            panel_macros_small.Location = new Point(266, 774);
            panel_macros_small.Margin = new Padding(3, 0, 0, 0);
            panel_macros_small.Name = "panel_macros_small";
            panel_macros_small.Size = new Size(34, 0);
            panel_macros_small.TabIndex = 25;
            panel_macros_small.Visible = false;
            // 
            // label_macros_small
            // 
            label_macros_small.BackColor = Color.FromArgb(23, 87, 146);
            label_macros_small.Dock = DockStyle.Fill;
            label_macros_small.Font = new Font("Segoe UI", 21F, FontStyle.Regular, GraphicsUnit.Point);
            label_macros_small.ForeColor = Color.White;
            label_macros_small.Location = new Point(0, 0);
            label_macros_small.Margin = new Padding(0);
            label_macros_small.Name = "label_macros_small";
            label_macros_small.Size = new Size(34, 0);
            label_macros_small.TabIndex = 20;
            label_macros_small.Text = "Macros";
            label_macros_small.TextAlign = ContentAlignment.MiddleCenter;
            label_macros_small.Click += label_macros_small_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(1324, 798);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(1340, 350);
            Name = "Form1";
            FormClosing += Form1_FormClosing;
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Assignments).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)databaseManagerBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Responses).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Macros).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Courses).EndInit();
            panel_courses.ResumeLayout(false);
            panel_assignments.ResumeLayout(false);
            panel_responses.ResumeLayout(false);
            panel_message.ResumeLayout(false);
            panel_message.PerformLayout();
            panel_macros.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            panel_courses_small.ResumeLayout(false);
            panel_macros_small.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        private void DataGridView_Macros_SelectionChanged(object sender, EventArgs e)
        {

            textBoxBoundItem = null;
            textBox_Message.Enabled = false;
            textBox_Message.Text = string.Empty;
        }

        private void DataGridView_Macros_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView_Macros.Rows[e.RowIndex].Cells["Play"].Value = Properties.Resources.icons8_play_50;
            dataGridView_Macros.Rows[e.RowIndex].Cells["editColumn"].Value = Properties.Resources.icons8_edit_50__1_;
        }

        private void DataGridView_Macros_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            dataGridView_Macros.Rows[e.Row.Index].Cells["Play"].Value = Properties.Resources.icons8_play_50;
            dataGridView_Macros.Rows[e.Row.Index].Cells["editColumn"].Value = Properties.Resources.icons8_edit_50__1_;
        }


        private void DataGridView_Macros_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            dataGridView_Macros.Rows[e.RowIndex].Cells["Play"].Value = Properties.Resources.icons8_play_50;
            dataGridView_Macros.Rows[e.RowIndex].Cells["editColumn"].Value = Properties.Resources.icons8_edit_50__1_;
        }

        private void DataGridView_Macros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 0)
            {
                // Get the selected macro and execute it
                Macro selectedMacro = (Macro)dataGridView_Macros.Rows[e.RowIndex].DataBoundItem;
                textBox_Message.AppendText(selectedMacro.text);
            }

            // edit the macro
            if (e.RowIndex >= 0 && e.ColumnIndex == 2)
            {
                textBoxBoundItem = ((Macro)dataGridView_Macros.Rows[e.RowIndex].DataBoundItem);
                //do we have anything selected?
                if (textBoxBoundItem != null)
                {
                    dataGridView_Responses.ClearSelection();
                    label_Message.Text = "Macro Text";
                    textBox_Message.Enabled = true;
                    string text = (((Macro)textBoxBoundItem).text);
                    textBox_Message.Text = text;
                }
            }
        }

            private void recalculateMessageLayoutSize()
        {
            int remainingWidth = flowLayoutPanel1.ClientSize.Width;

            if (panel_courses.Visible)
            {
                remainingWidth += -panel_courses.Size.Width - panel_courses.Margin.Horizontal;
            }

            if (panel_macros.Visible)
            {
                remainingWidth += -panel_macros.ClientSize.Width - panel_macros.Margin.Horizontal;
            }
            if (panel_macros_small.Visible)
            {
                remainingWidth += -panel_macros_small.ClientSize.Width - panel_macros_small.Margin.Horizontal;
            }
            if (panel_courses_small.Visible)
            {
                remainingWidth += -panel_courses_small.ClientSize.Width - panel_courses_small.Margin.Horizontal;
            }
            remainingWidth += -panel_assignments.Width - panel_assignments.Margin.Horizontal;
            remainingWidth += -panel_responses.Width - panel_responses.Margin.Horizontal;
            remainingWidth += -panel_message.Margin.Horizontal;

            int height = flowLayoutPanel1.Height;
            panel_message.Size = new Size(remainingWidth, height);
        }

        private void FlowLayoutPanel1_SizeChanged(object sender, EventArgs e)
        {
            recalculateMessageLayoutSize();
        }

        private void DataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            CustomizeHeaderCell(e, sender, "Segoe UI", 16, FontStyle.Regular, 500);
        }

        private void CustomizeHeaderCell(DataGridViewCellPaintingEventArgs e, object sender, string fontFamily, float fontSize, FontStyle fontStyle, int rowHeight)
        {
            if (e.RowIndex == -1 && e.ColumnIndex >= 0)
            {
                // Adjust the height of the header row
                //((DataGridView)sender).RowTemplate.Height = rowHeight;
                e.PaintBackground(e.ClipBounds, true);
                e.Graphics.FillRectangle(new SolidBrush(CustomColors.blue_dark), e.CellBounds);

                string text = e.Value?.ToString();

                if (!string.IsNullOrEmpty(text))
                {
                    using (StringFormat format = new StringFormat())
                    {
                        format.Alignment = StringAlignment.Center;
                        format.LineAlignment = StringAlignment.Center;

                        // Set the desired font
                        Font font = new Font(fontFamily, fontSize, fontStyle);

                        SizeF textSize = e.Graphics.MeasureString(text, font);

                        int newHeaderHeight = (int)textSize.Height;

                        // Set the new header height
                        ((DataGridView)sender).ColumnHeadersHeight = newHeaderHeight;


                        // Draw the text in the center of the cell
                        e.Graphics.DrawString(text, font, Brushes.White, e.CellBounds, format);
                    }
                }

                e.Handled = true;
            }

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {


                // Check if the current cell is part of the selected row
                if ((e.State & DataGridViewElementStates.Selected) == DataGridViewElementStates.Selected)
                {
                    // Fill the background of the selected cell with a color of your choice
                    e.Graphics.FillRectangle(new SolidBrush(CustomColors.blue_light), e.CellBounds);
                }
                else
                {
                    // Fill the background of other cells with the default color
                    e.Graphics.FillRectangle(new SolidBrush(e.CellStyle.BackColor), e.CellBounds);
                }

                // Draw the cell content (text)
                e.PaintContent(e.CellBounds);
                e.Handled = true;
            }


        }

        #endregion
        private ColumnHeader columnHeader1;
        private TextBox textBox_Message;
        private BindingSource bindingSource1;
        private DataGridView dataGridView_Assignments;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripMenuItem loadToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private Button copyClipboardButton;
        private BindingSource databaseManagerBindingSource;
        private DataGridView dataGridView_Responses;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridView dataGridView_Macros;
        private Label label_Message;
        private Label label_responses;
        private Label label_assignments;
        private Label label_macros;
        private DataGridView dataGridView_Courses;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private Panel panel_courses;
        private Label label_courses;
        private Panel panel_assignments;
        private Panel panel_responses;
        private Panel panel_message;
        private Panel panel_macros;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel_macros_small;
        private Label label_macros_small;
        private Panel panel_courses_small;
        private Label label_courses_small;
        private DataGridViewImageColumn Play;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewImageColumn editColumn;
    }
}
