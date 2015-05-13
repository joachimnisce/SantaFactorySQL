namespace santaFactory
{
    partial class formName
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
            this.btn_department = new System.Windows.Forms.Button();
            this.btn_dwarves = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_department
            // 
            this.btn_department.Location = new System.Drawing.Point(13, 13);
            this.btn_department.Name = "btn_department";
            this.btn_department.Size = new System.Drawing.Size(609, 128);
            this.btn_department.TabIndex = 0;
            this.btn_department.Text = "Departments";
            this.btn_department.UseVisualStyleBackColor = true;
            this.btn_department.Click += new System.EventHandler(this.btn_department_Click);
            // 
            // btn_dwarves
            // 
            this.btn_dwarves.Location = new System.Drawing.Point(12, 147);
            this.btn_dwarves.Name = "btn_dwarves";
            this.btn_dwarves.Size = new System.Drawing.Size(609, 128);
            this.btn_dwarves.TabIndex = 1;
            this.btn_dwarves.Text = "Dwarves";
            this.btn_dwarves.UseVisualStyleBackColor = true;
            this.btn_dwarves.Click += new System.EventHandler(this.btn_dwarves_Click);
            // 
            // formName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 327);
            this.Controls.Add(this.btn_dwarves);
            this.Controls.Add(this.btn_department);
            this.Name = "formName";
            this.Text = "Santa Factory Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_department;
        private System.Windows.Forms.Button btn_dwarves;
    }
}

