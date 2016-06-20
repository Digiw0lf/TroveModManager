namespace Trove_Mod_Manager
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        
        /// <summary>
        /// Clean up any resources being used.
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
/// Required method for Designer support - do not modify
/// the contents of this method with the code editor.
/// </summary>
private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.selectPath = new System.Windows.Forms.FolderBrowserDialog();
            this.zipFileUser = new System.Windows.Forms.OpenFileDialog();
            this.storagePath = new System.Windows.Forms.FolderBrowserDialog();
            this.Feedback = new System.Windows.Forms.TabPage();
            this.debugText_ = new System.Windows.Forms.TextBox();
            this.adminHelp = new System.Windows.Forms.Button();
            this.feedbackPageFeedback = new System.Windows.Forms.RichTextBox();
            this.feedbackTxt = new System.Windows.Forms.RichTextBox();
            this.feedbackPageText = new System.Windows.Forms.RichTextBox();
            this.sendMailButton = new System.Windows.Forms.Button();
            this.modCreationTools = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.feedbackExtract = new System.Windows.Forms.RichTextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.extractFileArchives = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sortRecent = new System.Windows.Forms.RadioButton();
            this.sortAlph = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.searchModBox = new System.Windows.Forms.RichTextBox();
            this.searchModButton_ = new System.Windows.Forms.Button();
            this.subFilterBox = new System.Windows.Forms.ComboBox();
            this.filterBox = new System.Windows.Forms.ListBox();
            this.modSearchNames = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rotatingCircle = new System.Windows.Forms.PictureBox();
            this.button5 = new System.Windows.Forms.Button();
            this.modSearchedStatus = new System.Windows.Forms.Label();
            this.searchedModReplaces = new System.Windows.Forms.Label();
            this.searchedModDLNum = new System.Windows.Forms.Label();
            this.searchedModSubtype = new System.Windows.Forms.Label();
            this.searchedModType = new System.Windows.Forms.Label();
            this.searchedModAuthor = new System.Windows.Forms.Label();
            this.searchedModName_ = new System.Windows.Forms.Label();
            this.modPicture = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.viewModToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.feedBackThing = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.clearMods = new System.Windows.Forms.Button();
            this.removeMod = new System.Windows.Forms.Button();
            this.feedbackMyMods = new System.Windows.Forms.RichTextBox();
            this.checkT = new System.Windows.Forms.TextBox();
            this.modList = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.setupTextBox = new System.Windows.Forms.RichTextBox();
            this.feedbackSetup = new System.Windows.Forms.RichTextBox();
            this.pathName = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.button4 = new System.Windows.Forms.Button();
            this.autoSteam = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Feedback.SuspendLayout();
            this.modCreationTools.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rotatingCircle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modPicture)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // zipFileUser
            // 
            this.zipFileUser.FileName = "openFileDialog1";
            // 
            // Feedback
            // 
            this.Feedback.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.Feedback.Controls.Add(this.debugText_);
            this.Feedback.Controls.Add(this.adminHelp);
            this.Feedback.Controls.Add(this.feedbackPageFeedback);
            this.Feedback.Controls.Add(this.feedbackTxt);
            this.Feedback.Controls.Add(this.feedbackPageText);
            this.Feedback.Controls.Add(this.sendMailButton);
            this.Feedback.Location = new System.Drawing.Point(4, 34);
            this.Feedback.Name = "Feedback";
            this.Feedback.Padding = new System.Windows.Forms.Padding(3);
            this.Feedback.Size = new System.Drawing.Size(1493, 611);
            this.Feedback.TabIndex = 4;
            this.Feedback.Text = "Feedback";
            // 
            // debugText_
            // 
            this.debugText_.Location = new System.Drawing.Point(1110, 554);
            this.debugText_.Name = "debugText_";
            this.debugText_.Size = new System.Drawing.Size(246, 31);
            this.debugText_.TabIndex = 6;
            this.debugText_.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // adminHelp
            // 
            this.adminHelp.FlatAppearance.BorderSize = 0;
            this.adminHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminHelp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(64)))));
            this.adminHelp.Location = new System.Drawing.Point(1362, 545);
            this.adminHelp.Name = "adminHelp";
            this.adminHelp.Size = new System.Drawing.Size(119, 49);
            this.adminHelp.TabIndex = 5;
            this.adminHelp.Text = "Debug";
            this.adminHelp.UseVisualStyleBackColor = true;
            this.adminHelp.Click += new System.EventHandler(this.adminHelp_Click);
            // 
            // feedbackPageFeedback
            // 
            this.feedbackPageFeedback.Location = new System.Drawing.Point(33, 499);
            this.feedbackPageFeedback.Name = "feedbackPageFeedback";
            this.feedbackPageFeedback.ReadOnly = true;
            this.feedbackPageFeedback.Size = new System.Drawing.Size(407, 57);
            this.feedbackPageFeedback.TabIndex = 4;
            this.feedbackPageFeedback.Text = "";
            // 
            // feedbackTxt
            // 
            this.feedbackTxt.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feedbackTxt.Location = new System.Drawing.Point(33, 34);
            this.feedbackTxt.Name = "feedbackTxt";
            this.feedbackTxt.Size = new System.Drawing.Size(1034, 439);
            this.feedbackTxt.TabIndex = 2;
            this.feedbackTxt.Text = "";
            // 
            // feedbackPageText
            // 
            this.feedbackPageText.BackColor = System.Drawing.SystemColors.Control;
            this.feedbackPageText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.feedbackPageText.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feedbackPageText.Location = new System.Drawing.Point(1110, 34);
            this.feedbackPageText.Name = "feedbackPageText";
            this.feedbackPageText.ReadOnly = true;
            this.feedbackPageText.Size = new System.Drawing.Size(317, 425);
            this.feedbackPageText.TabIndex = 1;
            this.feedbackPageText.Text = resources.GetString("feedbackPageText.Text");
            // 
            // sendMailButton
            // 
            this.sendMailButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(242)))));
            this.sendMailButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendMailButton.Font = new System.Drawing.Font("Segoe UI Symbol", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendMailButton.Location = new System.Drawing.Point(804, 499);
            this.sendMailButton.Name = "sendMailButton";
            this.sendMailButton.Size = new System.Drawing.Size(263, 57);
            this.sendMailButton.TabIndex = 3;
            this.sendMailButton.Text = "Send";
            this.sendMailButton.UseVisualStyleBackColor = false;
            this.sendMailButton.Click += new System.EventHandler(this.sendMailButton_Click);
            // 
            // modCreationTools
            // 
            this.modCreationTools.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.modCreationTools.Controls.Add(this.label2);
            this.modCreationTools.Controls.Add(this.button3);
            this.modCreationTools.Controls.Add(this.label5);
            this.modCreationTools.Controls.Add(this.richTextBox2);
            this.modCreationTools.Controls.Add(this.feedbackExtract);
            this.modCreationTools.Controls.Add(this.richTextBox1);
            this.modCreationTools.Controls.Add(this.label4);
            this.modCreationTools.Controls.Add(this.label3);
            this.modCreationTools.Controls.Add(this.extractFileArchives);
            this.modCreationTools.Font = new System.Drawing.Font("Segoe UI Symbol", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modCreationTools.Location = new System.Drawing.Point(4, 34);
            this.modCreationTools.Margin = new System.Windows.Forms.Padding(0);
            this.modCreationTools.Name = "modCreationTools";
            this.modCreationTools.Padding = new System.Windows.Forms.Padding(3);
            this.modCreationTools.Size = new System.Drawing.Size(1493, 611);
            this.modCreationTools.TabIndex = 3;
            this.modCreationTools.Text = "Mod Creation Tools";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(703, 412);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "UNAVAILABLE";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI Symbol", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(664, 440);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(213, 77);
            this.button3.TabIndex = 7;
            this.button3.Text = "Open Mass Blueprint Converter";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Symbol", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label5.Location = new System.Drawing.Point(596, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(249, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Mass Blueprint Converter\r\n";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.richTextBox2.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox2.Location = new System.Drawing.Point(601, 131);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(343, 236);
            this.richTextBox2.TabIndex = 5;
            this.richTextBox2.Text = "**UNDER CONSTRUCTION**\n\nMass Converts all .blueprint file types of a selected cla" +
    "ss into .qb file types.\n\nCurrently only supports LVL 20 Boomeranger Costume, mor" +
    "e to come!";
            this.richTextBox2.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            // 
            // feedbackExtract
            // 
            this.feedbackExtract.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.feedbackExtract.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.feedbackExtract.Font = new System.Drawing.Font("Segoe UI Symbol", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feedbackExtract.Location = new System.Drawing.Point(62, 381);
            this.feedbackExtract.Name = "feedbackExtract";
            this.feedbackExtract.ReadOnly = true;
            this.feedbackExtract.Size = new System.Drawing.Size(343, 40);
            this.feedbackExtract.TabIndex = 2;
            this.feedbackExtract.Text = "";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.richTextBox1.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(62, 131);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(343, 236);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Symbol", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label4.Location = new System.Drawing.Point(57, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Archive Extracter\r\n";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Symbol", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(242)))));
            this.label3.Location = new System.Drawing.Point(166, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1114, 50);
            this.label3.TabIndex = 3;
            this.label3.Text = "Hoping to have this filled with a couple different tools for modders. Many times " +
    "it\'s just easier to do things manually, \r\nso these will need to have a large imp" +
    "act to be useful.";
            // 
            // extractFileArchives
            // 
            this.extractFileArchives.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(242)))));
            this.extractFileArchives.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.extractFileArchives.Font = new System.Drawing.Font("Segoe UI Symbol", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extractFileArchives.Location = new System.Drawing.Point(119, 440);
            this.extractFileArchives.Name = "extractFileArchives";
            this.extractFileArchives.Size = new System.Drawing.Size(213, 77);
            this.extractFileArchives.TabIndex = 0;
            this.extractFileArchives.Text = "Extract from Archives";
            this.extractFileArchives.UseVisualStyleBackColor = false;
            this.extractFileArchives.Click += new System.EventHandler(this.extractFileArchives_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.tabPage3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage3.Controls.Add(this.flowLayoutPanel1);
            this.tabPage3.Location = new System.Drawing.Point(4, 34);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1493, 611);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Search for Mods";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.flowLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flowLayoutPanel1.Controls.Add(this.groupBox1);
            this.flowLayoutPanel1.Controls.Add(this.modSearchNames);
            this.flowLayoutPanel1.Controls.Add(this.groupBox2);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(25, 24);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(12);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1438, 559);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sortRecent);
            this.groupBox1.Controls.Add(this.sortAlph);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.searchModBox);
            this.groupBox1.Controls.Add(this.searchModButton_);
            this.groupBox1.Controls.Add(this.subFilterBox);
            this.groupBox1.Controls.Add(this.filterBox);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Symbol", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.groupBox1.Location = new System.Drawing.Point(15, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(289, 536);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Options";
            // 
            // sortRecent
            // 
            this.sortRecent.AutoSize = true;
            this.sortRecent.Font = new System.Drawing.Font("Segoe UI Symbol", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortRecent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.sortRecent.Location = new System.Drawing.Point(180, 371);
            this.sortRecent.Name = "sortRecent";
            this.sortRecent.Size = new System.Drawing.Size(96, 29);
            this.sortRecent.TabIndex = 8;
            this.sortRecent.TabStop = true;
            this.sortRecent.Text = "Recent";
            this.sortRecent.UseVisualStyleBackColor = true;
            this.sortRecent.CheckedChanged += new System.EventHandler(this.sortRecent_CheckedChanged);
            // 
            // sortAlph
            // 
            this.sortAlph.AutoSize = true;
            this.sortAlph.Font = new System.Drawing.Font("Segoe UI Symbol", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortAlph.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.sortAlph.Location = new System.Drawing.Point(12, 371);
            this.sortAlph.Name = "sortAlph";
            this.sortAlph.Size = new System.Drawing.Size(150, 29);
            this.sortAlph.TabIndex = 7;
            this.sortAlph.TabStop = true;
            this.sortAlph.Text = "Alphabetical";
            this.sortAlph.UseVisualStyleBackColor = true;
            this.sortAlph.CheckedChanged += new System.EventHandler(this.sortAlph_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI Symbol", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.label6.Location = new System.Drawing.Point(7, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Type :";
            // 
            // searchModBox
            // 
            this.searchModBox.BackColor = System.Drawing.SystemColors.Window;
            this.searchModBox.Font = new System.Drawing.Font("Segoe UI Symbol", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchModBox.Location = new System.Drawing.Point(12, 26);
            this.searchModBox.Margin = new System.Windows.Forms.Padding(10, 10, 10, 15);
            this.searchModBox.Multiline = false;
            this.searchModBox.Name = "searchModBox";
            this.searchModBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.searchModBox.Size = new System.Drawing.Size(264, 36);
            this.searchModBox.TabIndex = 2;
            this.searchModBox.Text = "Search For a Name...";
            this.searchModBox.WordWrap = false;
            this.searchModBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.searchModBox_MouseClick);
            this.searchModBox.TextChanged += new System.EventHandler(this.searchModBox_TextChanged);
            this.searchModBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchModBox_KeyDown);
            this.searchModBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.searchModBox_KeyPress);
            // 
            // searchModButton_
            // 
            this.searchModButton_.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(242)))));
            this.searchModButton_.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchModButton_.Font = new System.Drawing.Font("Segoe UI Symbol", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchModButton_.ForeColor = System.Drawing.Color.Black;
            this.searchModButton_.Location = new System.Drawing.Point(12, 463);
            this.searchModButton_.Margin = new System.Windows.Forms.Padding(10, 10, 10, 15);
            this.searchModButton_.Name = "searchModButton_";
            this.searchModButton_.Size = new System.Drawing.Size(264, 49);
            this.searchModButton_.TabIndex = 3;
            this.searchModButton_.Text = "Search";
            this.searchModButton_.UseVisualStyleBackColor = false;
            this.searchModButton_.Click += new System.EventHandler(this.searchModButton__Click);
            // 
            // subFilterBox
            // 
            this.subFilterBox.FormattingEnabled = true;
            this.subFilterBox.Location = new System.Drawing.Point(12, 408);
            this.subFilterBox.Margin = new System.Windows.Forms.Padding(10, 10, 10, 15);
            this.subFilterBox.Name = "subFilterBox";
            this.subFilterBox.Size = new System.Drawing.Size(264, 33);
            this.subFilterBox.TabIndex = 5;
            // 
            // filterBox
            // 
            this.filterBox.Font = new System.Drawing.Font("Segoe UI Symbol", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterBox.FormattingEnabled = true;
            this.filterBox.ItemHeight = 25;
            this.filterBox.Location = new System.Drawing.Point(12, 97);
            this.filterBox.Margin = new System.Windows.Forms.Padding(10);
            this.filterBox.Name = "filterBox";
            this.filterBox.Size = new System.Drawing.Size(264, 279);
            this.filterBox.TabIndex = 4;
            this.filterBox.SelectedIndexChanged += new System.EventHandler(this.filterBox_SelectedIndexChanged);
            // 
            // modSearchNames
            // 
            this.modSearchNames.Font = new System.Drawing.Font("Segoe UI Symbol", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modSearchNames.FormattingEnabled = true;
            this.modSearchNames.ItemHeight = 25;
            this.modSearchNames.Location = new System.Drawing.Point(337, 22);
            this.modSearchNames.Margin = new System.Windows.Forms.Padding(30, 10, 30, 10);
            this.modSearchNames.Name = "modSearchNames";
            this.modSearchNames.Size = new System.Drawing.Size(637, 529);
            this.modSearchNames.TabIndex = 9;
            this.modSearchNames.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rotatingCircle);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.modSearchedStatus);
            this.groupBox2.Controls.Add(this.searchedModReplaces);
            this.groupBox2.Controls.Add(this.searchedModDLNum);
            this.groupBox2.Controls.Add(this.searchedModSubtype);
            this.groupBox2.Controls.Add(this.searchedModType);
            this.groupBox2.Controls.Add(this.searchedModAuthor);
            this.groupBox2.Controls.Add(this.searchedModName_);
            this.groupBox2.Controls.Add(this.modPicture);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Symbol", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.groupBox2.Location = new System.Drawing.Point(1007, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(417, 536);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mod Information";
            // 
            // rotatingCircle
            // 
            this.rotatingCircle.Location = new System.Drawing.Point(347, 375);
            this.rotatingCircle.Name = "rotatingCircle";
            this.rotatingCircle.Size = new System.Drawing.Size(53, 50);
            this.rotatingCircle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rotatingCircle.TabIndex = 1;
            this.rotatingCircle.TabStop = false;
            // 
            // button5
            // 
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Location = new System.Drawing.Point(6, 431);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(405, 99);
            this.button5.TabIndex = 8;
            this.button5.Text = "Download and Install";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_2);
            // 
            // modSearchedStatus
            // 
            this.modSearchedStatus.AutoEllipsis = true;
            this.modSearchedStatus.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modSearchedStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.modSearchedStatus.Location = new System.Drawing.Point(1, 375);
            this.modSearchedStatus.Name = "modSearchedStatus";
            this.modSearchedStatus.Size = new System.Drawing.Size(340, 28);
            this.modSearchedStatus.TabIndex = 7;
            this.modSearchedStatus.Text = "Status";
            // 
            // searchedModReplaces
            // 
            this.searchedModReplaces.AutoSize = true;
            this.searchedModReplaces.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchedModReplaces.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.searchedModReplaces.Location = new System.Drawing.Point(1, 315);
            this.searchedModReplaces.Name = "searchedModReplaces";
            this.searchedModReplaces.Size = new System.Drawing.Size(107, 28);
            this.searchedModReplaces.TabIndex = 6;
            this.searchedModReplaces.Text = "Replaces :";
            // 
            // searchedModDLNum
            // 
            this.searchedModDLNum.AutoSize = true;
            this.searchedModDLNum.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchedModDLNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.searchedModDLNum.Location = new System.Drawing.Point(1, 343);
            this.searchedModDLNum.Name = "searchedModDLNum";
            this.searchedModDLNum.Size = new System.Drawing.Size(129, 28);
            this.searchedModDLNum.TabIndex = 5;
            this.searchedModDLNum.Text = "Download #";
            // 
            // searchedModSubtype
            // 
            this.searchedModSubtype.AutoSize = true;
            this.searchedModSubtype.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchedModSubtype.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.searchedModSubtype.Location = new System.Drawing.Point(200, 287);
            this.searchedModSubtype.Name = "searchedModSubtype";
            this.searchedModSubtype.Size = new System.Drawing.Size(55, 28);
            this.searchedModSubtype.TabIndex = 4;
            this.searchedModSubtype.Text = "For :";
            // 
            // searchedModType
            // 
            this.searchedModType.AutoSize = true;
            this.searchedModType.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchedModType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.searchedModType.Location = new System.Drawing.Point(1, 287);
            this.searchedModType.Name = "searchedModType";
            this.searchedModType.Size = new System.Drawing.Size(69, 28);
            this.searchedModType.TabIndex = 3;
            this.searchedModType.Text = "Type :";
            // 
            // searchedModAuthor
            // 
            this.searchedModAuthor.AutoSize = true;
            this.searchedModAuthor.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchedModAuthor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.searchedModAuthor.Location = new System.Drawing.Point(1, 259);
            this.searchedModAuthor.Name = "searchedModAuthor";
            this.searchedModAuthor.Size = new System.Drawing.Size(117, 28);
            this.searchedModAuthor.TabIndex = 2;
            this.searchedModAuthor.Text = "Created by";
            // 
            // searchedModName_
            // 
            this.searchedModName_.AutoSize = true;
            this.searchedModName_.BackColor = System.Drawing.Color.Transparent;
            this.searchedModName_.Font = new System.Drawing.Font("Segoe UI Symbol", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchedModName_.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.searchedModName_.Location = new System.Drawing.Point(0, 224);
            this.searchedModName_.Name = "searchedModName_";
            this.searchedModName_.Size = new System.Drawing.Size(149, 35);
            this.searchedModName_.TabIndex = 1;
            this.searchedModName_.Text = "Mod Name";
            // 
            // modPicture
            // 
            this.modPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.modPicture.Location = new System.Drawing.Point(6, 26);
            this.modPicture.Name = "modPicture";
            this.modPicture.Size = new System.Drawing.Size(405, 195);
            this.modPicture.TabIndex = 0;
            this.modPicture.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewModToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(152, 30);
            // 
            // viewModToolStripMenuItem
            // 
            this.viewModToolStripMenuItem.Name = "viewModToolStripMenuItem";
            this.viewModToolStripMenuItem.Size = new System.Drawing.Size(151, 26);
            this.viewModToolStripMenuItem.Text = "View Mod";
            this.viewModToolStripMenuItem.Click += new System.EventHandler(this.viewMod_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.AllowDrop = true;
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.tabPage2.Controls.Add(this.feedBackThing);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.clearMods);
            this.tabPage2.Controls.Add(this.removeMod);
            this.tabPage2.Controls.Add(this.feedbackMyMods);
            this.tabPage2.Controls.Add(this.checkT);
            this.tabPage2.Controls.Add(this.modList);
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1493, 611);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "My Mods";
            // 
            // feedBackThing
            // 
            this.feedBackThing.Location = new System.Drawing.Point(1199, 422);
            this.feedBackThing.Name = "feedBackThing";
            this.feedBackThing.Size = new System.Drawing.Size(239, 86);
            this.feedBackThing.TabIndex = 6;
            this.feedBackThing.Text = "";
            this.feedBackThing.Visible = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI Symbol", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(1206, 29);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(225, 77);
            this.button2.TabIndex = 1;
            this.button2.Text = "Install New Mod";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // clearMods
            // 
            this.clearMods.BackColor = System.Drawing.SystemColors.Control;
            this.clearMods.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearMods.Font = new System.Drawing.Font("Segoe UI Symbol", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearMods.ForeColor = System.Drawing.SystemColors.ControlText;
            this.clearMods.Location = new System.Drawing.Point(1206, 231);
            this.clearMods.Name = "clearMods";
            this.clearMods.Size = new System.Drawing.Size(225, 77);
            this.clearMods.TabIndex = 7;
            this.clearMods.Text = "Clear all Mods";
            this.clearMods.UseVisualStyleBackColor = false;
            this.clearMods.Click += new System.EventHandler(this.clearMods_Click);
            // 
            // removeMod
            // 
            this.removeMod.BackColor = System.Drawing.SystemColors.Control;
            this.removeMod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeMod.Font = new System.Drawing.Font("Segoe UI Symbol", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeMod.ForeColor = System.Drawing.SystemColors.ControlText;
            this.removeMod.Location = new System.Drawing.Point(1206, 131);
            this.removeMod.Name = "removeMod";
            this.removeMod.Size = new System.Drawing.Size(225, 77);
            this.removeMod.TabIndex = 4;
            this.removeMod.Text = "Remove Selected Mod\r\n";
            this.removeMod.UseVisualStyleBackColor = false;
            this.removeMod.Click += new System.EventHandler(this.removeMod_Click);
            // 
            // feedbackMyMods
            // 
            this.feedbackMyMods.Location = new System.Drawing.Point(23, 533);
            this.feedbackMyMods.Name = "feedbackMyMods";
            this.feedbackMyMods.ReadOnly = true;
            this.feedbackMyMods.Size = new System.Drawing.Size(1151, 36);
            this.feedbackMyMods.TabIndex = 5;
            this.feedbackMyMods.Text = "";
            // 
            // checkT
            // 
            this.checkT.Location = new System.Drawing.Point(54, 191);
            this.checkT.Name = "checkT";
            this.checkT.Size = new System.Drawing.Size(1087, 31);
            this.checkT.TabIndex = 2;
            // 
            // modList
            // 
            this.modList.Font = new System.Drawing.Font("Segoe UI Symbol", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modList.FormattingEnabled = true;
            this.modList.ItemHeight = 25;
            this.modList.Location = new System.Drawing.Point(23, 29);
            this.modList.Name = "modList";
            this.modList.Size = new System.Drawing.Size(1151, 479);
            this.modList.TabIndex = 3;
            this.modList.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(1199, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(239, 498);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.setupTextBox);
            this.tabPage1.Controls.Add(this.feedbackSetup);
            this.tabPage1.Controls.Add(this.pathName);
            this.tabPage1.Controls.Add(this.linkLabel1);
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.autoSteam);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1493, 611);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Initial Setup";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1197, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 25);
            this.label7.TabIndex = 12;
            // 
            // setupTextBox
            // 
            this.setupTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.setupTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.setupTextBox.Font = new System.Drawing.Font("Segoe UI Symbol", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setupTextBox.ForeColor = System.Drawing.Color.White;
            this.setupTextBox.Location = new System.Drawing.Point(98, 388);
            this.setupTextBox.Name = "setupTextBox";
            this.setupTextBox.Size = new System.Drawing.Size(1283, 100);
            this.setupTextBox.TabIndex = 11;
            this.setupTextBox.Text = resources.GetString("setupTextBox.Text");
            // 
            // feedbackSetup
            // 
            this.feedbackSetup.Location = new System.Drawing.Point(210, 522);
            this.feedbackSetup.Name = "feedbackSetup";
            this.feedbackSetup.ReadOnly = true;
            this.feedbackSetup.Size = new System.Drawing.Size(1083, 34);
            this.feedbackSetup.TabIndex = 7;
            this.feedbackSetup.Text = "";
            // 
            // pathName
            // 
            this.pathName.Location = new System.Drawing.Point(112, 323);
            this.pathName.Name = "pathName";
            this.pathName.Size = new System.Drawing.Size(1070, 31);
            this.pathName.TabIndex = 1;
            this.pathName.TextChanged += new System.EventHandler(this.pathName_TextChanged);
            // 
            // linkLabel1
            // 
            this.linkLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.linkLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI Symbol", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.ForeColor = System.Drawing.Color.White;
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.linkLabel1.Location = new System.Drawing.Point(3, 3);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(5000, 0, 5000, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(1487, 149);
            this.linkLabel1.TabIndex = 10;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Click Here for a Guide on using Trove Mod Manager!";
            this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // button4
            // 
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button4.Location = new System.Drawing.Point(874, 155);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(213, 77);
            this.button4.TabIndex = 8;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // autoSteam
            // 
            this.autoSteam.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("autoSteam.BackgroundImage")));
            this.autoSteam.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.autoSteam.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.autoSteam.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.autoSteam.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.autoSteam.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.autoSteam.ForeColor = System.Drawing.SystemColors.ControlText;
            this.autoSteam.Location = new System.Drawing.Point(398, 155);
            this.autoSteam.Name = "autoSteam";
            this.autoSteam.Size = new System.Drawing.Size(213, 77);
            this.autoSteam.TabIndex = 5;
            this.autoSteam.UseVisualStyleBackColor = true;
            this.autoSteam.Click += new System.EventHandler(this.autoSteam_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(110, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "\r\n";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(242)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(1202, 323);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "Select Path";
            this.toolTip1.SetToolTip(this.button1, "Examples of Trove Live Paths\r\n\r\nSteam:\r\nC:\\Program Files (x86)\\Steam\\steamapps\\co" +
        "mmon\\Trove\\Games\\Trove\\Live\r\n\r\nGlyph:\r\nC:\\Program Files (x86)\\Glyph\\Games\\Trove\\" +
        "Live");
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // tabControl1
            // 
            this.tabControl1.AllowDrop = true;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.modCreationTools);
            this.tabControl1.Controls.Add(this.Feedback);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI Symbol", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.HotTrack = true;
            this.tabControl1.Location = new System.Drawing.Point(-2, -2);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1501, 649);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(242)))));
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1496, 639);
            this.Controls.Add(this.tabControl1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1514, 686);
            this.MinimumSize = new System.Drawing.Size(1514, 686);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "Trove Mod Manager - BETA 1.1.0";
            this.Enter += new System.EventHandler(this.Form1_Enter);
            this.MouseEnter += new System.EventHandler(this.Form1_Enter);
            this.Feedback.ResumeLayout(false);
            this.Feedback.PerformLayout();
            this.modCreationTools.ResumeLayout(false);
            this.modCreationTools.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rotatingCircle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modPicture)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FolderBrowserDialog selectPath;
        
        private System.Windows.Forms.OpenFileDialog zipFileUser;
        private System.Windows.Forms.FolderBrowserDialog storagePath;
        private System.Windows.Forms.TabPage Feedback;
        private System.Windows.Forms.RichTextBox feedbackPageFeedback;
        private System.Windows.Forms.RichTextBox feedbackTxt;
        private System.Windows.Forms.RichTextBox feedbackPageText;
        private System.Windows.Forms.Button sendMailButton;
        private System.Windows.Forms.TabPage modCreationTools;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox feedbackExtract;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button extractFileArchives;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.RichTextBox searchModBox;
        private System.Windows.Forms.Button searchModButton_;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button clearMods;
        private System.Windows.Forms.RichTextBox feedBackThing;
        private System.Windows.Forms.RichTextBox feedbackMyMods;
        private System.Windows.Forms.TextBox checkT;
        private System.Windows.Forms.Button removeMod;
        private System.Windows.Forms.ListBox modList;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RichTextBox setupTextBox;
        private System.Windows.Forms.RichTextBox feedbackSetup;
        private System.Windows.Forms.TextBox pathName;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button autoSteam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem viewModToolStripMenuItem;
        private System.Windows.Forms.ListBox filterBox;
        private System.Windows.Forms.ComboBox subFilterBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox modSearchNames;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label searchedModAuthor;
        private System.Windows.Forms.Label searchedModName_;
        private System.Windows.Forms.PictureBox modPicture;
        private System.Windows.Forms.RadioButton sortAlph;
        private System.Windows.Forms.RadioButton sortRecent;
        private System.Windows.Forms.Label searchedModSubtype;
        private System.Windows.Forms.Label searchedModType;
        private System.Windows.Forms.Label searchedModDLNum;
        private System.Windows.Forms.Label searchedModReplaces;
        private System.Windows.Forms.Label modSearchedStatus;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.PictureBox rotatingCircle;
        private System.Windows.Forms.Button adminHelp;
        private System.Windows.Forms.TextBox debugText_;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label7;
    }
}

