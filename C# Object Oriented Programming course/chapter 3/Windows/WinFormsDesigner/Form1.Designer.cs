
namespace WinFormsDesigner
{
    partial class MyForm
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
            this.ClickMe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ClickMe
            // 
            this.ClickMe.Location = new System.Drawing.Point(291, 59);
            this.ClickMe.Name = "ClickMe";
            this.ClickMe.Size = new System.Drawing.Size(75, 23);
            this.ClickMe.TabIndex = 0;
            this.ClickMe.Text = "ClickMe";
            this.ClickMe.UseVisualStyleBackColor = true;
            this.ClickMe.Click += new System.EventHandler(this.ClickMe_Click);
            // 
            // MyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ClickMe);
            this.Name = "MyForm";
            this.Text = "My Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ClickMe;
    }
}

