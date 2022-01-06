
namespace WindowsFormsApp1
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
            this.labelSchoolName = new System.Windows.Forms.Label();
            this.labelAdress = new System.Windows.Forms.Label();
            this.labelCity = new System.Windows.Forms.Label();
            this.labelZip = new System.Windows.Forms.Label();
            this.labelPhoneNumber = new System.Windows.Forms.Label();
            this.labelTwitter = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.textAdress = new System.Windows.Forms.TextBox();
            this.textZip = new System.Windows.Forms.TextBox();
            this.textCity = new System.Windows.Forms.TextBox();
            this.textPhoneNumber = new System.Windows.Forms.TextBox();
            this.textTwitter = new System.Windows.Forms.TextBox();
            this.buttonLogic = new System.Windows.Forms.Button();
            this.buttonTeacher = new System.Windows.Forms.Button();
            this.buttonStudent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelSchoolName
            // 
            this.labelSchoolName.AutoSize = true;
            this.labelSchoolName.Location = new System.Drawing.Point(51, 36);
            this.labelSchoolName.Name = "labelSchoolName";
            this.labelSchoolName.Size = new System.Drawing.Size(71, 13);
            this.labelSchoolName.TabIndex = 0;
            this.labelSchoolName.Text = "School Name";
            this.labelSchoolName.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelAdress
            // 
            this.labelAdress.AutoSize = true;
            this.labelAdress.Location = new System.Drawing.Point(87, 81);
            this.labelAdress.Name = "labelAdress";
            this.labelAdress.Size = new System.Drawing.Size(39, 13);
            this.labelAdress.TabIndex = 1;
            this.labelAdress.Text = "Adress";
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Location = new System.Drawing.Point(87, 128);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(24, 13);
            this.labelCity.TabIndex = 2;
            this.labelCity.Text = "City";
            // 
            // labelZip
            // 
            this.labelZip.AutoSize = true;
            this.labelZip.Location = new System.Drawing.Point(87, 178);
            this.labelZip.Name = "labelZip";
            this.labelZip.Size = new System.Drawing.Size(24, 13);
            this.labelZip.TabIndex = 3;
            this.labelZip.Text = "ZIP";
            // 
            // labelPhoneNumber
            // 
            this.labelPhoneNumber.AutoSize = true;
            this.labelPhoneNumber.Location = new System.Drawing.Point(44, 229);
            this.labelPhoneNumber.Name = "labelPhoneNumber";
            this.labelPhoneNumber.Size = new System.Drawing.Size(78, 13);
            this.labelPhoneNumber.TabIndex = 4;
            this.labelPhoneNumber.Text = "Phone Number";
            // 
            // labelTwitter
            // 
            this.labelTwitter.AutoSize = true;
            this.labelTwitter.Location = new System.Drawing.Point(50, 272);
            this.labelTwitter.Name = "labelTwitter";
            this.labelTwitter.Size = new System.Drawing.Size(72, 13);
            this.labelTwitter.TabIndex = 5;
            this.labelTwitter.Text = "twitter Handle";
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(128, 33);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(100, 20);
            this.textName.TabIndex = 6;
            // 
            // textAdress
            // 
            this.textAdress.Location = new System.Drawing.Point(128, 78);
            this.textAdress.Name = "textAdress";
            this.textAdress.Size = new System.Drawing.Size(100, 20);
            this.textAdress.TabIndex = 7;
            // 
            // textZip
            // 
            this.textZip.Location = new System.Drawing.Point(128, 175);
            this.textZip.Name = "textZip";
            this.textZip.Size = new System.Drawing.Size(100, 20);
            this.textZip.TabIndex = 8;
            // 
            // textCity
            // 
            this.textCity.Location = new System.Drawing.Point(128, 125);
            this.textCity.Name = "textCity";
            this.textCity.Size = new System.Drawing.Size(100, 20);
            this.textCity.TabIndex = 9;
            // 
            // textPhoneNumber
            // 
            this.textPhoneNumber.Location = new System.Drawing.Point(128, 226);
            this.textPhoneNumber.Name = "textPhoneNumber";
            this.textPhoneNumber.Size = new System.Drawing.Size(100, 20);
            this.textPhoneNumber.TabIndex = 10;
            // 
            // textTwitter
            // 
            this.textTwitter.Location = new System.Drawing.Point(128, 269);
            this.textTwitter.Name = "textTwitter";
            this.textTwitter.Size = new System.Drawing.Size(100, 20);
            this.textTwitter.TabIndex = 11;
            // 
            // buttonLogic
            // 
            this.buttonLogic.Location = new System.Drawing.Point(140, 336);
            this.buttonLogic.Name = "buttonLogic";
            this.buttonLogic.Size = new System.Drawing.Size(107, 36);
            this.buttonLogic.TabIndex = 12;
            this.buttonLogic.Text = "Push To Test";
            this.buttonLogic.UseVisualStyleBackColor = true;
            this.buttonLogic.Click += new System.EventHandler(this.buttonLogic_Click);
            // 
            // buttonTeacher
            // 
            this.buttonTeacher.Location = new System.Drawing.Point(140, 390);
            this.buttonTeacher.Name = "buttonTeacher";
            this.buttonTeacher.Size = new System.Drawing.Size(107, 36);
            this.buttonTeacher.TabIndex = 13;
            this.buttonTeacher.Text = "Test Teacher";
            this.buttonTeacher.UseVisualStyleBackColor = true;
            this.buttonTeacher.Click += new System.EventHandler(this.buttonTeacher_Click);
            // 
            // buttonStudent
            // 
            this.buttonStudent.Location = new System.Drawing.Point(140, 432);
            this.buttonStudent.Name = "buttonStudent";
            this.buttonStudent.Size = new System.Drawing.Size(107, 36);
            this.buttonStudent.TabIndex = 14;
            this.buttonStudent.Text = "Test Student";
            this.buttonStudent.UseVisualStyleBackColor = true;
            this.buttonStudent.Click += new System.EventHandler(this.buttonStudent_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 507);
            this.Controls.Add(this.buttonStudent);
            this.Controls.Add(this.buttonTeacher);
            this.Controls.Add(this.buttonLogic);
            this.Controls.Add(this.textTwitter);
            this.Controls.Add(this.textPhoneNumber);
            this.Controls.Add(this.textCity);
            this.Controls.Add(this.textZip);
            this.Controls.Add(this.textAdress);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.labelTwitter);
            this.Controls.Add(this.labelPhoneNumber);
            this.Controls.Add(this.labelZip);
            this.Controls.Add(this.labelCity);
            this.Controls.Add(this.labelAdress);
            this.Controls.Add(this.labelSchoolName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSchoolName;
        private System.Windows.Forms.Label labelAdress;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.Label labelZip;
        private System.Windows.Forms.Label labelPhoneNumber;
        private System.Windows.Forms.Label labelTwitter;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textAdress;
        private System.Windows.Forms.TextBox textZip;
        private System.Windows.Forms.TextBox textCity;
        private System.Windows.Forms.TextBox textPhoneNumber;
        private System.Windows.Forms.TextBox textTwitter;
        private System.Windows.Forms.Button buttonLogic;
        private System.Windows.Forms.Button buttonTeacher;
        private System.Windows.Forms.Button buttonStudent;
    }
}

