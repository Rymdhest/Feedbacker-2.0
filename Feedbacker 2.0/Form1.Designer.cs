﻿using Feedbacker_2._0.Database;
using System.Windows.Forms;

namespace Feedbacker_2._0
{
    partial class Form1
    {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            comboBox_courses = new ComboBox();
            textBox1 = new TextBox();
            bindingSource1 = new BindingSource(components);
            dataGridView_Responses = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Responses).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Assignments).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // comboBox_courses
            // 
            comboBox_courses.FormattingEnabled = true;
            comboBox_courses.Location = new Point(12, 27);
            comboBox_courses.Name = "comboBox_courses";
            comboBox_courses.Size = new Size(176, 23);
            comboBox_courses.TabIndex = 0;
            comboBox_courses.SelectedIndexChanged += ComboBox_courses_SelectedIndexChanged;
            comboBox_courses.SelectionChangeCommitted += ComboBox_courses_SelectionChangeCommitted;
            comboBox_courses.TextChanged += ComboBox_courses_TextChanged;
            // 
            // textBox1
            // 
            textBox1.AcceptsReturn = true;
            textBox1.AcceptsTab = true;
            textBox1.AllowDrop = true;
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(446, 56);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(320, 423);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // dataGridView_Responses
            // 
            dataGridView_Responses.AllowUserToResizeColumns = false;
            dataGridView_Responses.AllowUserToResizeRows = false;
            dataGridView_Responses.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dataGridView_Responses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Responses.Columns.AddRange(new DataGridViewColumn[] { Column1 });
            dataGridView_Responses.Location = new Point(227, 56);
            dataGridView_Responses.MultiSelect = false;
            dataGridView_Responses.Name = "dataGridView_Responses";
            dataGridView_Responses.RowHeadersVisible = false;
            dataGridView_Responses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_Responses.Size = new Size(200, 453);
            dataGridView_Responses.TabIndex = 4;
            dataGridView_Responses.CellValueChanged += DataGridView_Responses_CellValueChanged;
            dataGridView_Responses.SelectionChanged += DataGridView_Responses_SelectionChanged;
            dataGridView_Responses.UserAddedRow += DataGridView_Responses_SelectionChanged;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column1.DataPropertyName = "Name";
            Column1.HeaderText = "Responses";
            Column1.Name = "Column1";
            // 
            // dataGridView_Assignments
            // 
            dataGridView_Assignments.AllowUserToResizeColumns = false;
            dataGridView_Assignments.AllowUserToResizeRows = false;
            dataGridView_Assignments.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dataGridView_Assignments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Assignments.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1 });
            dataGridView_Assignments.Location = new Point(12, 56);
            dataGridView_Assignments.MultiSelect = false;
            dataGridView_Assignments.Name = "dataGridView_Assignments";
            dataGridView_Assignments.RowHeadersVisible = false;
            dataGridView_Assignments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_Assignments.Size = new Size(200, 453);
            dataGridView_Assignments.TabIndex = 5;
            dataGridView_Assignments.CellValueChanged += DataGridView_Responses_CellValueChanged;
            dataGridView_Assignments.SelectionChanged += DataGridView_Assignments_SelectionChanged;
            dataGridView_Assignments.UserAddedRow += DataGridView_Assignments_SelectionChanged;
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
            menuStrip1.Size = new Size(778, 24);
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
            // button1
            // 
            button1.Location = new Point(194, 26);
            button1.Name = "button1";
            button1.Size = new Size(101, 23);
            button1.TabIndex = 7;
            button1.Text = "New Course";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button2.Location = new Point(446, 486);
            button2.Name = "button2";
            button2.Size = new Size(94, 23);
            button2.TabIndex = 8;
            button2.Text = "Add Signature";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button3.Location = new Point(546, 486);
            button3.Name = "button3";
            button3.Size = new Size(103, 23);
            button3.TabIndex = 9;
            button3.Text = "Add Grade Aim";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button4.Location = new Point(655, 485);
            button4.Name = "button4";
            button4.Size = new Size(113, 23);
            button4.TabIndex = 10;
            button4.Text = "Copy to Clipboard";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(778, 521);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView_Assignments);
            Controls.Add(dataGridView_Responses);
            Controls.Add(textBox1);
            Controls.Add(comboBox_courses);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Feedbacker 2.0";
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Responses).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Assignments).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void DataGridView_Responses_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            needSave = true;
        }










        #endregion

        private ComboBox comboBox_courses;
        private ColumnHeader columnHeader1;
        private TextBox textBox1;
        private BindingSource bindingSource1;
        private DataGridView dataGridView_Responses;
        private DataGridView dataGridView_Assignments;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn Column1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripMenuItem loadToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}