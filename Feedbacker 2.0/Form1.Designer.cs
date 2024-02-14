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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
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
            label_Message = new Label();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            dataGridView_Courses = new DataGridView();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            panel_courses = new Panel();
            label3 = new Label();
            panel_assignments = new Panel();
            panel_responses = new Panel();
            panel_message = new Panel();
            panel_macros = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel_courses_small = new Panel();
            label_courses_small = new Label();
            panel_macros_small = new Panel();
            label_macros_small = new Label();
            Column1 = new DataGridViewImageColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            editColumn = new DataGridViewImageColumn();
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(23, 87, 146);
            dataGridViewCellStyle1.Font = new Font("Tahoma", 21F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(105, 164, 219);
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView_Assignments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView_Assignments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Assignments.ColumnHeadersVisible = false;
            dataGridView_Assignments.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1 });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView_Assignments.DefaultCellStyle = dataGridViewCellStyle2;
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
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(23, 87, 146);
            dataGridViewCellStyle3.Font = new Font("Tahoma", 21F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(105, 164, 219);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView_Responses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView_Responses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Responses.ColumnHeadersVisible = false;
            dataGridView_Responses.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn4 });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dataGridView_Responses.DefaultCellStyle = dataGridViewCellStyle4;
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
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(23, 87, 146);
            dataGridViewCellStyle5.Font = new Font("Tahoma", 21F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(105, 164, 219);
            dataGridViewCellStyle5.SelectionForeColor = Color.Black;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridView_Macros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView_Macros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Macros.ColumnHeadersVisible = false;
            dataGridView_Macros.Columns.AddRange(new DataGridViewColumn[] { Column1, dataGridViewTextBoxColumn2, editColumn });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = Color.Black;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dataGridView_Macros.DefaultCellStyle = dataGridViewCellStyle6;
            dataGridView_Macros.EnableHeadersVisualStyles = false;
            dataGridView_Macros.GridColor = Color.White;
            dataGridView_Macros.Location = new Point(0, 34);
            dataGridView_Macros.Margin = new Padding(0);
            dataGridView_Macros.MultiSelect = false;
            dataGridView_Macros.Name = "dataGridView_Macros";
            dataGridView_Macros.RowHeadersVisible = false;
            dataGridView_Macros.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_Macros.Size = new Size(260, 740);
            dataGridView_Macros.TabIndex = 14;
            dataGridView_Macros.CellClick += DataGridView_Macros_CellClick;
            dataGridView_Macros.RowsAdded += DataGridView_Macros_RowsAdded;
            dataGridView_Macros.UserAddedRow += DataGridView_Macros_UserAddedRow;
            dataGridView_Macros.CellEndEdit += DataGridView_Macros_CellEndEdit;
            dataGridView_Macros.SelectionChanged += DataGridView_Macros_SelectionChanged;
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
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = Color.FromArgb(23, 87, 146);
            label1.Font = new Font("Segoe UI", 21F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(260, 34);
            label1.TabIndex = 16;
            label1.Text = "Responses";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.BackColor = Color.FromArgb(23, 87, 146);
            label2.Font = new Font("Segoe UI", 21F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(0, 0);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(260, 34);
            label2.TabIndex = 17;
            label2.Text = "Assignments";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.BackColor = Color.FromArgb(23, 87, 146);
            label4.Font = new Font("Segoe UI", 21F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(0, 0);
            label4.Margin = new Padding(0);
            label4.Name = "label4";
            label4.Size = new Size(260, 34);
            label4.TabIndex = 19;
            label4.Text = "Macros";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            label4.Click += label4_Click;
            // 
            // dataGridView_Courses
            // 
            dataGridView_Courses.AllowDrop = true;
            dataGridView_Courses.AllowUserToOrderColumns = true;
            dataGridView_Courses.AllowUserToResizeColumns = false;
            dataGridView_Courses.AllowUserToResizeRows = false;
            dataGridView_Courses.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView_Courses.BackgroundColor = Color.FromArgb(240, 240, 240);
            dataGridView_Courses.BorderStyle = BorderStyle.None;
            dataGridView_Courses.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView_Courses.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(23, 87, 146);
            dataGridViewCellStyle7.Font = new Font("Tahoma", 21F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(105, 164, 219);
            dataGridViewCellStyle7.SelectionForeColor = Color.Black;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dataGridView_Courses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridView_Courses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Courses.ColumnHeadersVisible = false;
            dataGridView_Courses.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn3 });
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Window;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = Color.Black;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dataGridView_Courses.DefaultCellStyle = dataGridViewCellStyle8;
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
            panel_courses.Controls.Add(label3);
            panel_courses.Controls.Add(dataGridView_Courses);
            panel_courses.Location = new Point(37, 0);
            panel_courses.Margin = new Padding(0, 0, 3, 0);
            panel_courses.Name = "panel_courses";
            panel_courses.Size = new Size(260, 774);
            panel_courses.TabIndex = 20;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.BackColor = Color.FromArgb(23, 87, 146);
            label3.Font = new Font("Segoe UI", 21F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(0, 0);
            label3.Margin = new Padding(0);
            label3.Name = "label3";
            label3.Size = new Size(260, 34);
            label3.TabIndex = 21;
            label3.Text = "Courses";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.Click += label3_Click_1;
            // 
            // panel_assignments
            // 
            panel_assignments.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel_assignments.Controls.Add(label2);
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
            panel_responses.Controls.Add(label1);
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
            panel_macros.Controls.Add(label4);
            panel_macros.Controls.Add(dataGridView_Macros);
            panel_macros.Location = new Point(3, 774);
            panel_macros.Margin = new Padding(3, 0, 0, 0);
            panel_macros.Name = "panel_macros";
            panel_macros.Size = new Size(260, 774);
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
            panel_macros_small.Controls.Add(label_macros_small);
            panel_macros_small.Location = new Point(266, 774);
            panel_macros_small.Margin = new Padding(3, 0, 0, 0);
            panel_macros_small.Name = "panel_macros_small";
            panel_macros_small.Size = new Size(34, 774);
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
            label_macros_small.Size = new Size(34, 774);
            label_macros_small.TabIndex = 20;
            label_macros_small.Text = "Macros";
            label_macros_small.TextAlign = ContentAlignment.MiddleCenter;
            label_macros_small.Click += label_macros_small_Click;
            // 
            // Column1
            // 
            Column1.HeaderText = "Column1";
            Column1.Image = Properties.Resources.icons8_play_50;
            Column1.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Column1.Name = "Play";
            Column1.Width = 50;
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
            editColumn.Name = "editColumn";

            editColumn.Image = Properties.Resources.icons8_edit_50__1_;
            editColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            editColumn.Width = 50;
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
        private Label label1;
        private Label label2;
        private Label label4;
        private DataGridView dataGridView_Courses;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private Panel panel_courses;
        private Label label3;
        private Panel panel_assignments;
        private Panel panel_responses;
        private Panel panel_message;
        private Panel panel_macros;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel_macros_small;
        private Label label_macros_small;
        private Panel panel_courses_small;
        private Label label_courses_small;
        private DataGridViewImageColumn Column1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewImageColumn editColumn;
    }
}
