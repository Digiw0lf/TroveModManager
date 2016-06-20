namespace Trove_Mod_Manager
{
    partial class Form4
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
            this.bigAssButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.classesList = new System.Windows.Forms.ListBox();
            this.costumeList = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bigAssButton
            // 
            this.bigAssButton.Location = new System.Drawing.Point(1132, 251);
            this.bigAssButton.Name = "bigAssButton";
            this.bigAssButton.Size = new System.Drawing.Size(188, 72);
            this.bigAssButton.TabIndex = 0;
            this.bigAssButton.Text = "button1";
            this.bigAssButton.UseVisualStyleBackColor = true;
            this.bigAssButton.Click += new System.EventHandler(this.bigAssButton_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.classesList);
            this.flowLayoutPanel1.Controls.Add(this.richTextBox1);
            this.flowLayoutPanel1.Controls.Add(this.costumeList);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(31, 56);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1077, 448);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // classesList
            // 
            this.classesList.FormattingEnabled = true;
            this.classesList.ItemHeight = 16;
            this.classesList.Location = new System.Drawing.Point(3, 3);
            this.classesList.Name = "classesList";
            this.classesList.Size = new System.Drawing.Size(339, 436);
            this.classesList.TabIndex = 0;
            this.classesList.SelectedIndexChanged += new System.EventHandler(this.classesList_SelectedIndexChanged);
            // 
            // costumeList
            // 
            this.costumeList.FormattingEnabled = true;
            this.costumeList.ItemHeight = 16;
            this.costumeList.Location = new System.Drawing.Point(699, 3);
            this.costumeList.Name = "costumeList";
            this.costumeList.Size = new System.Drawing.Size(350, 436);
            this.costumeList.TabIndex = 4;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(1114, 384);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(215, 132);
            this.listBox1.TabIndex = 5;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Location = new System.Drawing.Point(348, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(345, 436);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "\n\n\n\n\n\n\n\n\n\n\n\n            ---------------------------------------------------------" +
    "----------->";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 576);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.bigAssButton);
            this.Name = "Form4";
            this.Text = "Form4";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bigAssButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ListBox classesList;
        private System.Windows.Forms.ListBox costumeList;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}