namespace Planes
{
    partial class setP1UC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.P1backbtn = new System.Windows.Forms.Button();
            this.P1confirmbtn = new System.Windows.Forms.Button();
            this.P1titlelbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // P1backbtn
            // 
            this.P1backbtn.Location = new System.Drawing.Point(19, 19);
            this.P1backbtn.Name = "P1backbtn";
            this.P1backbtn.Size = new System.Drawing.Size(75, 56);
            this.P1backbtn.TabIndex = 3;
            this.P1backbtn.Text = "back";
            this.P1backbtn.UseVisualStyleBackColor = true;
            this.P1backbtn.Click += new System.EventHandler(this.P1backbtn_Click);
            // 
            // P1confirmbtn
            // 
            this.P1confirmbtn.Location = new System.Drawing.Point(753, 482);
            this.P1confirmbtn.Name = "P1confirmbtn";
            this.P1confirmbtn.Size = new System.Drawing.Size(133, 61);
            this.P1confirmbtn.TabIndex = 4;
            this.P1confirmbtn.Text = "confirm";
            this.P1confirmbtn.UseVisualStyleBackColor = true;
            this.P1confirmbtn.Click += new System.EventHandler(this.P1confirmbtn_Click);
            // 
            // P1titlelbl
            // 
            this.P1titlelbl.AutoSize = true;
            this.P1titlelbl.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.P1titlelbl.Location = new System.Drawing.Point(312, 100);
            this.P1titlelbl.Name = "P1titlelbl";
            this.P1titlelbl.Size = new System.Drawing.Size(277, 50);
            this.P1titlelbl.TabIndex = 5;
            this.P1titlelbl.Text = "Player 1 Board";
            // 
            // setP1UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.P1titlelbl);
            this.Controls.Add(this.P1confirmbtn);
            this.Controls.Add(this.P1backbtn);
            this.Name = "setP1UC";
            this.Size = new System.Drawing.Size(901, 558);
            this.Load += new System.EventHandler(this.setP1UC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button P1backbtn;
        private System.Windows.Forms.Button P1confirmbtn;
        private System.Windows.Forms.Label P1titlelbl;
    }
}
