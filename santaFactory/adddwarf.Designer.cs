﻿namespace santaFactory
{
    partial class adddwarf
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
            this.txtname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.txtage = new System.Windows.Forms.TextBox();
            this.lbl3 = new System.Windows.Forms.Label();
            this.txtcolor = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(12, 54);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(260, 20);
            this.txtname.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(9, 92);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(26, 13);
            this.lbl2.TabIndex = 3;
            this.lbl2.Text = "Age";
            // 
            // txtage
            // 
            this.txtage.Location = new System.Drawing.Point(12, 120);
            this.txtage.Name = "txtage";
            this.txtage.Size = new System.Drawing.Size(260, 20);
            this.txtage.TabIndex = 2;
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(9, 155);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(31, 13);
            this.lbl3.TabIndex = 5;
            this.lbl3.Text = "Color";
            // 
            // txtcolor
            // 
            this.txtcolor.Location = new System.Drawing.Point(12, 182);
            this.txtcolor.Name = "txtcolor";
            this.txtcolor.Size = new System.Drawing.Size(260, 20);
            this.txtcolor.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 242);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(260, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Department";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 275);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(148, 275);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(124, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // adddwarf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 310);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.txtcolor);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.txtage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtname);
            this.Name = "adddwarf";
            this.Text = "Add or Edit";
            this.Load += new System.EventHandler(this.adddwarf_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.TextBox txtage;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.TextBox txtcolor;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}