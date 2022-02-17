
namespace Planes
{
    partial class setupconfirm
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
            this.continueoutbtn = new System.Windows.Forms.Button();
            this.staybtn = new System.Windows.Forms.Button();
            this.setupconfirmlbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // continueoutbtn
            // 
            this.continueoutbtn.Location = new System.Drawing.Point(206, 98);
            this.continueoutbtn.Name = "continueoutbtn";
            this.continueoutbtn.Size = new System.Drawing.Size(119, 23);
            this.continueoutbtn.TabIndex = 5;
            this.continueoutbtn.Text = "Continue Exit";
            this.continueoutbtn.UseVisualStyleBackColor = true;
            this.continueoutbtn.Click += new System.EventHandler(this.continueoutbtn_Click);
            // 
            // staybtn
            // 
            this.staybtn.Location = new System.Drawing.Point(36, 98);
            this.staybtn.Name = "staybtn";
            this.staybtn.Size = new System.Drawing.Size(119, 23);
            this.staybtn.TabIndex = 4;
            this.staybtn.Text = "Stay on Page";
            this.staybtn.UseVisualStyleBackColor = true;
            this.staybtn.Click += new System.EventHandler(this.staybtn_Click);
            // 
            // setupconfirmlbl
            // 
            this.setupconfirmlbl.Location = new System.Drawing.Point(36, 18);
            this.setupconfirmlbl.Name = "setupconfirmlbl";
            this.setupconfirmlbl.Size = new System.Drawing.Size(289, 67);
            this.setupconfirmlbl.TabIndex = 3;
            this.setupconfirmlbl.Text = "If you exit, nothing will be saved of this game so far and you will be redirected" +
    " to a new game start - Are you sure you would like to exit?";
            this.setupconfirmlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // setupconfirm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 172);
            this.Controls.Add(this.continueoutbtn);
            this.Controls.Add(this.staybtn);
            this.Controls.Add(this.setupconfirmlbl);
            this.Name = "setupconfirm";
            this.Text = "setupconfirm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button continueoutbtn;
        private System.Windows.Forms.Button staybtn;
        private System.Windows.Forms.Label setupconfirmlbl;
    }
}