
namespace Planes
{
    partial class savedform
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
            this.saveconfirmbtn = new System.Windows.Forms.Label();
            this.saveformbtn = new System.Windows.Forms.Button();
            this.continueexitbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // saveconfirmbtn
            // 
            this.saveconfirmbtn.Location = new System.Drawing.Point(45, 26);
            this.saveconfirmbtn.Name = "saveconfirmbtn";
            this.saveconfirmbtn.Size = new System.Drawing.Size(241, 38);
            this.saveconfirmbtn.TabIndex = 0;
            this.saveconfirmbtn.Text = "There are still unsaved changes - Are you sure you would like to exit?";
            this.saveconfirmbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // saveformbtn
            // 
            this.saveformbtn.Location = new System.Drawing.Point(22, 96);
            this.saveformbtn.Name = "saveformbtn";
            this.saveformbtn.Size = new System.Drawing.Size(119, 23);
            this.saveformbtn.TabIndex = 1;
            this.saveformbtn.Text = "Save Game";
            this.saveformbtn.UseVisualStyleBackColor = true;
            this.saveformbtn.Click += new System.EventHandler(this.saveformbtn_Click);
            // 
            // continueexitbtn
            // 
            this.continueexitbtn.Location = new System.Drawing.Point(192, 96);
            this.continueexitbtn.Name = "continueexitbtn";
            this.continueexitbtn.Size = new System.Drawing.Size(119, 23);
            this.continueexitbtn.TabIndex = 2;
            this.continueexitbtn.Text = "Continue Exit";
            this.continueexitbtn.UseVisualStyleBackColor = true;
            this.continueexitbtn.Click += new System.EventHandler(this.continueexitbtn_Click);
            // 
            // savedform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 172);
            this.Controls.Add(this.continueexitbtn);
            this.Controls.Add(this.saveformbtn);
            this.Controls.Add(this.saveconfirmbtn);
            this.Name = "savedform";
            this.Text = "savedform";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label saveconfirmbtn;
        private System.Windows.Forms.Button saveformbtn;
        private System.Windows.Forms.Button continueexitbtn;
    }
}