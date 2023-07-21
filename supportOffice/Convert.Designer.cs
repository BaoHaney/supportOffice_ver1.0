namespace supportOffice
{
    partial class Convert
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.optionWtP = new System.Windows.Forms.RadioButton();
            this.optionPtW = new System.Windows.Forms.RadioButton();
            this.Savet1 = new System.Windows.Forms.TextBox();
            this.Savet2 = new System.Windows.Forms.TextBox();
            this.browser1 = new System.Windows.Forms.Button();
            this.save1 = new System.Windows.Forms.Button();
            this.convert1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.panelConvert = new System.Windows.Forms.Panel();
            this.panelConvert.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(242, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Convert";
            // 
            // optionWtP
            // 
            this.optionWtP.AutoSize = true;
            this.optionWtP.Location = new System.Drawing.Point(160, 208);
            this.optionWtP.Margin = new System.Windows.Forms.Padding(2);
            this.optionWtP.Name = "optionWtP";
            this.optionWtP.Size = new System.Drawing.Size(87, 17);
            this.optionWtP.TabIndex = 1;
            this.optionWtP.TabStop = true;
            this.optionWtP.Text = "Word to PDF";
            this.optionWtP.UseVisualStyleBackColor = true;
            this.optionWtP.CheckedChanged += new System.EventHandler(this.optionWtP_CheckedChanged);
            // 
            // optionPtW
            // 
            this.optionPtW.AutoSize = true;
            this.optionPtW.Location = new System.Drawing.Point(160, 156);
            this.optionPtW.Margin = new System.Windows.Forms.Padding(2);
            this.optionPtW.Name = "optionPtW";
            this.optionPtW.Size = new System.Drawing.Size(87, 17);
            this.optionPtW.TabIndex = 2;
            this.optionPtW.TabStop = true;
            this.optionPtW.Text = "PDF to Word";
            this.optionPtW.UseVisualStyleBackColor = true;
            this.optionPtW.CheckedChanged += new System.EventHandler(this.optionPtW_CheckedChanged);
            // 
            // Savet1
            // 
            this.Savet1.Location = new System.Drawing.Point(188, 279);
            this.Savet1.Margin = new System.Windows.Forms.Padding(2);
            this.Savet1.Name = "Savet1";
            this.Savet1.Size = new System.Drawing.Size(296, 20);
            this.Savet1.TabIndex = 5;
            // 
            // Savet2
            // 
            this.Savet2.Location = new System.Drawing.Point(188, 355);
            this.Savet2.Margin = new System.Windows.Forms.Padding(2);
            this.Savet2.Name = "Savet2";
            this.Savet2.Size = new System.Drawing.Size(296, 20);
            this.Savet2.TabIndex = 6;
            // 
            // browser1
            // 
            this.browser1.Location = new System.Drawing.Point(106, 279);
            this.browser1.Margin = new System.Windows.Forms.Padding(2);
            this.browser1.Name = "browser1";
            this.browser1.Size = new System.Drawing.Size(67, 19);
            this.browser1.TabIndex = 7;
            this.browser1.Text = "Choose file";
            this.browser1.UseVisualStyleBackColor = true;
            this.browser1.Click += new System.EventHandler(this.browser1_Click);
            // 
            // save1
            // 
            this.save1.Location = new System.Drawing.Point(106, 354);
            this.save1.Margin = new System.Windows.Forms.Padding(2);
            this.save1.Name = "save1";
            this.save1.Size = new System.Drawing.Size(67, 19);
            this.save1.TabIndex = 8;
            this.save1.Text = "Browser";
            this.save1.UseVisualStyleBackColor = true;
            this.save1.Click += new System.EventHandler(this.save1_Click);
            // 
            // convert1
            // 
            this.convert1.Location = new System.Drawing.Point(249, 444);
            this.convert1.Margin = new System.Windows.Forms.Padding(2);
            this.convert1.Name = "convert1";
            this.convert1.Size = new System.Drawing.Size(104, 62);
            this.convert1.TabIndex = 9;
            this.convert1.Text = "Convert";
            this.convert1.UseVisualStyleBackColor = true;
            this.convert1.Click += new System.EventHandler(this.convert1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(272, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Address File Input";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(263, 331);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Address Folder output";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(364, 156);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(81, 17);
            this.radioButton1.TabIndex = 12;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "IMG to PDF";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.optionItP_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(364, 208);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(81, 17);
            this.radioButton2.TabIndex = 13;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "PDF to IMG";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.optionPtI_CheckedChanged);
            // 
            // panelConvert
            // 
            this.panelConvert.Controls.Add(this.radioButton2);
            this.panelConvert.Controls.Add(this.radioButton1);
            this.panelConvert.Controls.Add(this.label3);
            this.panelConvert.Controls.Add(this.label2);
            this.panelConvert.Controls.Add(this.convert1);
            this.panelConvert.Controls.Add(this.save1);
            this.panelConvert.Controls.Add(this.browser1);
            this.panelConvert.Controls.Add(this.Savet2);
            this.panelConvert.Controls.Add(this.Savet1);
            this.panelConvert.Controls.Add(this.optionPtW);
            this.panelConvert.Controls.Add(this.optionWtP);
            this.panelConvert.Controls.Add(this.label1);
            this.panelConvert.Location = new System.Drawing.Point(105, 11);
            this.panelConvert.Margin = new System.Windows.Forms.Padding(2);
            this.panelConvert.Name = "panelConvert";
            this.panelConvert.Size = new System.Drawing.Size(617, 528);
            this.panelConvert.TabIndex = 1;
            // 
            // Convert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 562);
            this.Controls.Add(this.panelConvert);
            this.Name = "Convert";
            this.Text = "Convert";
            this.panelConvert.ResumeLayout(false);
            this.panelConvert.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton optionWtP;
        private System.Windows.Forms.RadioButton optionPtW;
        private System.Windows.Forms.TextBox Savet1;
        private System.Windows.Forms.TextBox Savet2;
        private System.Windows.Forms.Button browser1;
        private System.Windows.Forms.Button save1;
        private System.Windows.Forms.Button convert1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Panel panelConvert;
    }
}