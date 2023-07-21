namespace supportOffice
{
    partial class SplitFile
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.startPage = new System.Windows.Forms.NumericUpDown();
            this.endPage = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.saveAsText = new System.Windows.Forms.TextBox();
            this.inputcb1 = new System.Windows.Forms.Button();
            this.chooseFileText = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.optionPtW = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.startPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endPage)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(315, 55);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(159, 37);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Split PDF";
            // 
            // startPage
            // 
            this.startPage.Location = new System.Drawing.Point(293, 236);
            this.startPage.Name = "startPage";
            this.startPage.Size = new System.Drawing.Size(121, 20);
            this.startPage.TabIndex = 2;
            // 
            // endPage
            // 
            this.endPage.Location = new System.Drawing.Point(446, 236);
            this.endPage.Name = "endPage";
            this.endPage.Size = new System.Drawing.Size(124, 20);
            this.endPage.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(196, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Slipt from page:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(420, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "To";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(339, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Address Folder Output";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(339, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Address Files Input";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(199, 306);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(56, 19);
            this.button5.TabIndex = 18;
            this.button5.Text = "Browser";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.saveAs_Click);
            // 
            // saveAsText
            // 
            this.saveAsText.Location = new System.Drawing.Point(265, 305);
            this.saveAsText.Margin = new System.Windows.Forms.Padding(2);
            this.saveAsText.Name = "saveAsText";
            this.saveAsText.Size = new System.Drawing.Size(305, 20);
            this.saveAsText.TabIndex = 17;
            // 
            // inputcb1
            // 
            this.inputcb1.Location = new System.Drawing.Point(199, 196);
            this.inputcb1.Margin = new System.Windows.Forms.Padding(2);
            this.inputcb1.Name = "inputcb1";
            this.inputcb1.Size = new System.Drawing.Size(56, 19);
            this.inputcb1.TabIndex = 16;
            this.inputcb1.Text = "Browser";
            this.inputcb1.UseVisualStyleBackColor = true;
            this.inputcb1.Click += new System.EventHandler(this.chooseFile_Click);
            // 
            // chooseFileText
            // 
            this.chooseFileText.Location = new System.Drawing.Point(265, 196);
            this.chooseFileText.Margin = new System.Windows.Forms.Padding(2);
            this.chooseFileText.Name = "chooseFileText";
            this.chooseFileText.Size = new System.Drawing.Size(305, 20);
            this.chooseFileText.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(322, 368);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 34);
            this.button1.TabIndex = 21;
            this.button1.Text = "Split";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonSplit_Click);
            // 
            // optionPtW
            // 
            this.optionPtW.AutoSize = true;
            this.optionPtW.Checked = true;
            this.optionPtW.Location = new System.Drawing.Point(199, 132);
            this.optionPtW.Margin = new System.Windows.Forms.Padding(2);
            this.optionPtW.Name = "optionPtW";
            this.optionPtW.Size = new System.Drawing.Size(46, 17);
            this.optionPtW.TabIndex = 22;
            this.optionPtW.TabStop = true;
            this.optionPtW.Text = "PDF";
            this.optionPtW.UseVisualStyleBackColor = true;
            this.optionPtW.CheckedChanged += new System.EventHandler(this.optionP_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(483, 132);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(51, 17);
            this.radioButton1.TabIndex = 23;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Word";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.optionW_CheckedChanged);
            // 
            // SplitFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.optionPtW);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.saveAsText);
            this.Controls.Add(this.inputcb1);
            this.Controls.Add(this.chooseFileText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.endPage);
            this.Controls.Add(this.startPage);
            this.Controls.Add(this.labelTitle);
            this.Name = "SplitFile";
            this.Text = "SplitFile";
            ((System.ComponentModel.ISupportInitialize)(this.startPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endPage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.NumericUpDown startPage;
        private System.Windows.Forms.NumericUpDown endPage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox saveAsText;
        private System.Windows.Forms.Button inputcb1;
        private System.Windows.Forms.TextBox chooseFileText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton optionPtW;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}