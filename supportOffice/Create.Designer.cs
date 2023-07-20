namespace supportOffice
{
    partial class Create
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
            this.button1 = new System.Windows.Forms.Button();
            this.TextBox1 = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.save1 = new System.Windows.Forms.Button();
            this.Savet2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fileName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(564, 113);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 42);
            this.button1.TabIndex = 3;
            this.button1.Text = "Create File Word";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(36, 176);
            this.TextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(842, 423);
            this.TextBox1.TabIndex = 2;
            this.TextBox1.Text = "";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(734, 113);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 42);
            this.button2.TabIndex = 4;
            this.button2.Text = "Create File Text";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(672, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Address Folder output";
            // 
            // save1
            // 
            this.save1.Location = new System.Drawing.Point(493, 75);
            this.save1.Margin = new System.Windows.Forms.Padding(2);
            this.save1.Name = "save1";
            this.save1.Size = new System.Drawing.Size(56, 19);
            this.save1.TabIndex = 13;
            this.save1.Text = "Browser";
            this.save1.UseVisualStyleBackColor = true;
            this.save1.Click += new System.EventHandler(this.save1_Click);
            // 
            // Savet2
            // 
            this.Savet2.Location = new System.Drawing.Point(564, 74);
            this.Savet2.Margin = new System.Windows.Forms.Padding(2);
            this.Savet2.Name = "Savet2";
            this.Savet2.Size = new System.Drawing.Size(314, 20);
            this.Savet2.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "File Name";
            // 
            // fileName
            // 
            this.fileName.Location = new System.Drawing.Point(47, 75);
            this.fileName.Margin = new System.Windows.Forms.Padding(2);
            this.fileName.Name = "fileName";
            this.fileName.Size = new System.Drawing.Size(272, 20);
            this.fileName.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(362, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 37);
            this.label2.TabIndex = 18;
            this.label2.Text = "Create File";
            // 
            // Create
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 612);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fileName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.save1);
            this.Controls.Add(this.Savet2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TextBox1);
            this.Name = "Create";
            this.Text = "Create";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox TextBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button save1;
        private System.Windows.Forms.TextBox Savet2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fileName;
        private System.Windows.Forms.Label label2;
    }
}