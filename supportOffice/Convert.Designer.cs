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
            this.panelConvert = new System.Windows.Forms.Panel();
            this.convert1 = new System.Windows.Forms.Button();
            this.save1 = new System.Windows.Forms.Button();
            this.browser1 = new System.Windows.Forms.Button();
            this.Savet2 = new System.Windows.Forms.TextBox();
            this.Savet1 = new System.Windows.Forms.TextBox();
            this.optionPtW = new System.Windows.Forms.RadioButton();
            this.optionWtP = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelConvert.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelConvert
            // 
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
            this.panelConvert.Location = new System.Drawing.Point(107, 11);
            this.panelConvert.Margin = new System.Windows.Forms.Padding(2);
            this.panelConvert.Name = "panelConvert";
            this.panelConvert.Size = new System.Drawing.Size(617, 528);
            this.panelConvert.TabIndex = 1;
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
            // save1
            // 
            this.save1.Location = new System.Drawing.Point(117, 354);
            this.save1.Margin = new System.Windows.Forms.Padding(2);
            this.save1.Name = "save1";
            this.save1.Size = new System.Drawing.Size(56, 19);
            this.save1.TabIndex = 8;
            this.save1.Text = "Browser";
            this.save1.UseVisualStyleBackColor = true;
            this.save1.Click += new System.EventHandler(this.save1_Click);
            // 
            // browser1
            // 
            this.browser1.Location = new System.Drawing.Point(117, 279);
            this.browser1.Margin = new System.Windows.Forms.Padding(2);
            this.browser1.Name = "browser1";
            this.browser1.Size = new System.Drawing.Size(56, 19);
            this.browser1.TabIndex = 7;
            this.browser1.Text = "Browser";
            this.browser1.UseVisualStyleBackColor = true;
            this.browser1.Click += new System.EventHandler(this.browser1_Click);
            // 
            // Savet2
            // 
            this.Savet2.Location = new System.Drawing.Point(188, 355);
            this.Savet2.Margin = new System.Windows.Forms.Padding(2);
            this.Savet2.Name = "Savet2";
            this.Savet2.Size = new System.Drawing.Size(272, 20);
            this.Savet2.TabIndex = 6;
            // 
            // Savet1
            // 
            this.Savet1.Location = new System.Drawing.Point(188, 279);
            this.Savet1.Margin = new System.Windows.Forms.Padding(2);
            this.Savet1.Name = "Savet1";
            this.Savet1.Size = new System.Drawing.Size(272, 20);
            this.Savet1.TabIndex = 5;
            // 
            // optionPtW
            // 
            this.optionPtW.AutoSize = true;
            this.optionPtW.Location = new System.Drawing.Point(320, 208);
            this.optionPtW.Margin = new System.Windows.Forms.Padding(2);
            this.optionPtW.Name = "optionPtW";
            this.optionPtW.Size = new System.Drawing.Size(87, 17);
            this.optionPtW.TabIndex = 2;
            this.optionPtW.TabStop = true;
            this.optionPtW.Text = "PDF to Word";
            this.optionPtW.UseVisualStyleBackColor = true;
            this.optionPtW.CheckedChanged += new System.EventHandler(this.optionPtW_CheckedChanged);
            // 
            // optionWtP
            // 
            this.optionWtP.AutoSize = true;
            this.optionWtP.Location = new System.Drawing.Point(119, 208);
            this.optionWtP.Margin = new System.Windows.Forms.Padding(2);
            this.optionWtP.Name = "optionWtP";
            this.optionWtP.Size = new System.Drawing.Size(87, 17);
            this.optionWtP.TabIndex = 1;
            this.optionWtP.TabStop = true;
            this.optionWtP.Text = "Word to PDF";
            this.optionWtP.UseVisualStyleBackColor = true;
            this.optionWtP.CheckedChanged += new System.EventHandler(this.optionWtP_CheckedChanged);
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
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(262, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Address File Input";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(262, 331);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Address Folder output";
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

        private System.Windows.Forms.Panel panelConvert;
        private System.Windows.Forms.Button convert1;
        private System.Windows.Forms.Button save1;
        private System.Windows.Forms.Button browser1;
        private System.Windows.Forms.TextBox Savet2;
        private System.Windows.Forms.TextBox Savet1;
        private System.Windows.Forms.RadioButton optionPtW;
        private System.Windows.Forms.RadioButton optionWtP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}