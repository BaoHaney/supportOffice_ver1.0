namespace supportOffice
{
    partial class Rename
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
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Savet1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelNoti = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxBrowser = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(283, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 37);
            this.label2.TabIndex = 19;
            this.label2.Text = "Rename File";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(88, 148);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 24);
            this.button1.TabIndex = 20;
            this.button1.Text = "Choose file";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonChooseFile_Click);
            // 
            // Savet1
            // 
            this.Savet1.Location = new System.Drawing.Point(230, 148);
            this.Savet1.Margin = new System.Windows.Forms.Padding(2);
            this.Savet1.Name = "Savet1";
            this.Savet1.Size = new System.Drawing.Size(433, 20);
            this.Savet1.TabIndex = 21;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(547, 263);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 21);
            this.button2.TabIndex = 22;
            this.button2.Text = "Start rename";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.buttonRename_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.label1.Location = new System.Drawing.Point(85, 263);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 18);
            this.label1.TabIndex = 23;
            this.label1.Text = "your file name: ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(230, 264);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(299, 20);
            this.textBox1.TabIndex = 24;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.label3.Location = new System.Drawing.Point(85, 346);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 18);
            this.label3.TabIndex = 25;
            this.label3.Text = "Notice: ";
            // 
            // labelNoti
            // 
            this.labelNoti.AutoSize = true;
            this.labelNoti.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.labelNoti.Location = new System.Drawing.Point(157, 346);
            this.labelNoti.Name = "labelNoti";
            this.labelNoti.Size = new System.Drawing.Size(441, 18);
            this.labelNoti.TabIndex = 26;
            this.labelNoti.Text = "Please choose your file name and sign your new name.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.label4.Location = new System.Drawing.Point(85, 207);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 18);
            this.label4.TabIndex = 27;
            this.label4.Text = "Save as (not require) ";
            // 
            // textBoxBrowser
            // 
            this.textBoxBrowser.Location = new System.Drawing.Point(279, 208);
            this.textBoxBrowser.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxBrowser.Name = "textBoxBrowser";
            this.textBoxBrowser.Size = new System.Drawing.Size(250, 20);
            this.textBoxBrowser.TabIndex = 28;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(547, 207);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(116, 21);
            this.button3.TabIndex = 29;
            this.button3.Text = "Browser";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.buttonBrowser_Click);
            // 
            // Rename
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBoxBrowser);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelNoti);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Savet1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Name = "Rename";
            this.Text = "Rename";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Savet1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelNoti;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxBrowser;
        private System.Windows.Forms.Button button3;
    }
}