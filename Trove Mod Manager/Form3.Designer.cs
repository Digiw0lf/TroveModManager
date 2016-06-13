namespace Trove_Mod_Manager
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.modSearchedName = new System.Windows.Forms.RichTextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.authorLabel = new System.Windows.Forms.Label();
            this.authorText = new System.Windows.Forms.RichTextBox();
            this.subTypeLabel = new System.Windows.Forms.RichTextBox();
            this.subType = new System.Windows.Forms.Label();
            this.Type = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.RichTextBox();
            this.modImage = new System.Windows.Forms.PictureBox();
            this.totalDownloadsLabel = new System.Windows.Forms.RichTextBox();
            this.downloadMod = new System.Windows.Forms.Button();
            this.modDLFeedback = new System.Windows.Forms.RichTextBox();
            this.fileIDBox = new System.Windows.Forms.TextBox();
            this.IDBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.searchedModReplaces = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tSaurusLoc = new System.Windows.Forms.PictureBox();
            this.linkTEXT = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.modImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tSaurusLoc)).BeginInit();
            this.SuspendLayout();
            // 
            // modSearchedName
            // 
            this.modSearchedName.BackColor = System.Drawing.SystemColors.Control;
            this.modSearchedName.Font = new System.Drawing.Font("Constantia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modSearchedName.Location = new System.Drawing.Point(42, 55);
            this.modSearchedName.Name = "modSearchedName";
            this.modSearchedName.ReadOnly = true;
            this.modSearchedName.Size = new System.Drawing.Size(551, 27);
            this.modSearchedName.TabIndex = 0;
            this.modSearchedName.Text = "";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Constantia", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(42, 30);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(72, 23);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Name :";
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.Font = new System.Drawing.Font("Constantia", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorLabel.Location = new System.Drawing.Point(42, 88);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(82, 23);
            this.authorLabel.TabIndex = 2;
            this.authorLabel.Text = "Author :";
            // 
            // authorText
            // 
            this.authorText.BackColor = System.Drawing.SystemColors.Control;
            this.authorText.Font = new System.Drawing.Font("Constantia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorText.Location = new System.Drawing.Point(42, 114);
            this.authorText.Name = "authorText";
            this.authorText.ReadOnly = true;
            this.authorText.Size = new System.Drawing.Size(551, 27);
            this.authorText.TabIndex = 3;
            this.authorText.Text = "";
            // 
            // subTypeLabel
            // 
            this.subTypeLabel.BackColor = System.Drawing.SystemColors.Control;
            this.subTypeLabel.Font = new System.Drawing.Font("Constantia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTypeLabel.Location = new System.Drawing.Point(322, 179);
            this.subTypeLabel.Name = "subTypeLabel";
            this.subTypeLabel.ReadOnly = true;
            this.subTypeLabel.Size = new System.Drawing.Size(271, 27);
            this.subTypeLabel.TabIndex = 7;
            this.subTypeLabel.Text = "";
            this.subTypeLabel.Click += new System.EventHandler(this.subTypeLabel_Click);
            // 
            // subType
            // 
            this.subType.AutoSize = true;
            this.subType.Font = new System.Drawing.Font("Constantia", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subType.Location = new System.Drawing.Point(318, 153);
            this.subType.Name = "subType";
            this.subType.Size = new System.Drawing.Size(93, 23);
            this.subType.TabIndex = 6;
            this.subType.Text = "Subtype :";
            this.subType.Click += new System.EventHandler(this.label1_Click);
            // 
            // Type
            // 
            this.Type.AutoSize = true;
            this.Type.Font = new System.Drawing.Font("Constantia", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Type.Location = new System.Drawing.Point(42, 153);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(63, 23);
            this.Type.TabIndex = 5;
            this.Type.Text = "Type :";
            // 
            // typeLabel
            // 
            this.typeLabel.BackColor = System.Drawing.SystemColors.Control;
            this.typeLabel.Font = new System.Drawing.Font("Constantia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeLabel.Location = new System.Drawing.Point(42, 178);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.ReadOnly = true;
            this.typeLabel.Size = new System.Drawing.Size(270, 27);
            this.typeLabel.TabIndex = 4;
            this.typeLabel.Text = "";
            // 
            // modImage
            // 
            this.modImage.Location = new System.Drawing.Point(647, 41);
            this.modImage.Name = "modImage";
            this.modImage.Size = new System.Drawing.Size(539, 267);
            this.modImage.TabIndex = 8;
            this.modImage.TabStop = false;
            // 
            // totalDownloadsLabel
            // 
            this.totalDownloadsLabel.BackColor = System.Drawing.SystemColors.Control;
            this.totalDownloadsLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.totalDownloadsLabel.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalDownloadsLabel.Location = new System.Drawing.Point(647, 314);
            this.totalDownloadsLabel.Name = "totalDownloadsLabel";
            this.totalDownloadsLabel.Size = new System.Drawing.Size(283, 30);
            this.totalDownloadsLabel.TabIndex = 9;
            this.totalDownloadsLabel.Text = "";
            // 
            // downloadMod
            // 
            this.downloadMod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.downloadMod.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downloadMod.Location = new System.Drawing.Point(42, 274);
            this.downloadMod.Name = "downloadMod";
            this.downloadMod.Size = new System.Drawing.Size(551, 70);
            this.downloadMod.TabIndex = 10;
            this.downloadMod.Text = "Download && Install";
            this.downloadMod.UseVisualStyleBackColor = true;
            this.downloadMod.Click += new System.EventHandler(this.downloadMod_Click);
            // 
            // modDLFeedback
            // 
            this.modDLFeedback.Location = new System.Drawing.Point(945, 314);
            this.modDLFeedback.Name = "modDLFeedback";
            this.modDLFeedback.Size = new System.Drawing.Size(241, 30);
            this.modDLFeedback.TabIndex = 11;
            this.modDLFeedback.Text = "";
            // 
            // fileIDBox
            // 
            this.fileIDBox.Location = new System.Drawing.Point(647, 41);
            this.fileIDBox.Name = "fileIDBox";
            this.fileIDBox.ReadOnly = true;
            this.fileIDBox.Size = new System.Drawing.Size(100, 22);
            this.fileIDBox.TabIndex = 12;
            this.fileIDBox.Visible = false;
            // 
            // IDBox
            // 
            this.IDBox.Location = new System.Drawing.Point(753, 41);
            this.IDBox.Name = "IDBox";
            this.IDBox.ReadOnly = true;
            this.IDBox.Size = new System.Drawing.Size(100, 22);
            this.IDBox.TabIndex = 13;
            this.IDBox.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 23);
            this.label1.TabIndex = 15;
            this.label1.Text = "Replaces :\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // searchedModReplaces
            // 
            this.searchedModReplaces.BackColor = System.Drawing.SystemColors.Control;
            this.searchedModReplaces.Font = new System.Drawing.Font("Constantia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchedModReplaces.Location = new System.Drawing.Point(42, 241);
            this.searchedModReplaces.Name = "searchedModReplaces";
            this.searchedModReplaces.ReadOnly = true;
            this.searchedModReplaces.Size = new System.Drawing.Size(270, 27);
            this.searchedModReplaces.TabIndex = 14;
            this.searchedModReplaces.Text = "";
            this.searchedModReplaces.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Constantia", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(318, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 23);
            this.label2.TabIndex = 16;
            this.label2.Text = "Trovesaurus Link :";
            // 
            // tSaurusLoc
            // 
            this.tSaurusLoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tSaurusLoc.Location = new System.Drawing.Point(322, 241);
            this.tSaurusLoc.Name = "tSaurusLoc";
            this.tSaurusLoc.Size = new System.Drawing.Size(206, 27);
            this.tSaurusLoc.TabIndex = 17;
            this.tSaurusLoc.TabStop = false;
            this.tSaurusLoc.Click += new System.EventHandler(this.tSaurusLoc_Click);
            // 
            // linkTEXT
            // 
            this.linkTEXT.Location = new System.Drawing.Point(860, 40);
            this.linkTEXT.Name = "linkTEXT";
            this.linkTEXT.ReadOnly = true;
            this.linkTEXT.Size = new System.Drawing.Size(100, 22);
            this.linkTEXT.TabIndex = 18;
            this.linkTEXT.Visible = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1230, 379);
            this.Controls.Add(this.linkTEXT);
            this.Controls.Add(this.tSaurusLoc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchedModReplaces);
            this.Controls.Add(this.IDBox);
            this.Controls.Add(this.fileIDBox);
            this.Controls.Add(this.modDLFeedback);
            this.Controls.Add(this.downloadMod);
            this.Controls.Add(this.totalDownloadsLabel);
            this.Controls.Add(this.modImage);
            this.Controls.Add(this.subTypeLabel);
            this.Controls.Add(this.subType);
            this.Controls.Add(this.Type);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.authorText);
            this.Controls.Add(this.authorLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.modSearchedName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.Text = "Selected Mod";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.modImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tSaurusLoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox modSearchedName;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.RichTextBox authorText;
        private System.Windows.Forms.RichTextBox subTypeLabel;
        private System.Windows.Forms.Label subType;
        private System.Windows.Forms.Label Type;
        private System.Windows.Forms.RichTextBox typeLabel;
        private System.Windows.Forms.PictureBox modImage;
        private System.Windows.Forms.RichTextBox totalDownloadsLabel;
        private System.Windows.Forms.Button downloadMod;
        private System.Windows.Forms.RichTextBox modDLFeedback;
        private System.Windows.Forms.TextBox fileIDBox;
        private System.Windows.Forms.TextBox IDBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox searchedModReplaces;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox tSaurusLoc;
        private System.Windows.Forms.TextBox linkTEXT;
    }
}