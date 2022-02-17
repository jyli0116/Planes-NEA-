namespace Planes
{
    partial class setP2UC
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
            this.P2backbtn = new System.Windows.Forms.Button();
            this.P2confirmbtn = new System.Windows.Forms.Button();
            this.P2titlelbl = new System.Windows.Forms.Label();
            this.turnbtn = new System.Windows.Forms.Button();
            this.p2currentlbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // P2backbtn
            // 
            this.P2backbtn.Location = new System.Drawing.Point(19, 19);
            this.P2backbtn.Name = "P2backbtn";
            this.P2backbtn.Size = new System.Drawing.Size(75, 56);
            this.P2backbtn.TabIndex = 3;
            this.P2backbtn.Text = "back";
            this.P2backbtn.UseVisualStyleBackColor = true;
            this.P2backbtn.Click += new System.EventHandler(this.P2backbtn_Click);
            // 
            // P2confirmbtn
            // 
            this.P2confirmbtn.Location = new System.Drawing.Point(753, 482);
            this.P2confirmbtn.Name = "P2confirmbtn";
            this.P2confirmbtn.Size = new System.Drawing.Size(133, 61);
            this.P2confirmbtn.TabIndex = 4;
            this.P2confirmbtn.Text = "confirm";
            this.P2confirmbtn.UseVisualStyleBackColor = true;
            this.P2confirmbtn.Click += new System.EventHandler(this.P2confirmbtn_Click);
            // 
            // P2titlelbl
            // 
            this.P2titlelbl.AutoSize = true;
            this.P2titlelbl.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.P2titlelbl.Location = new System.Drawing.Point(316, 100);
            this.P2titlelbl.Name = "P2titlelbl";
            this.P2titlelbl.Size = new System.Drawing.Size(277, 50);
            this.P2titlelbl.TabIndex = 5;
            this.P2titlelbl.Text = "Player 2 Board";
            // 
            // turnbtn
            // 
            this.turnbtn.Location = new System.Drawing.Point(753, 289);
            this.turnbtn.Name = "turnbtn";
            this.turnbtn.Size = new System.Drawing.Size(75, 23);
            this.turnbtn.TabIndex = 6;
            this.turnbtn.Text = "Turn";
            this.turnbtn.UseVisualStyleBackColor = true;
            this.turnbtn.Click += new System.EventHandler(this.turnbtn_Click);
            // 
            // p2currentlbl
            // 
            this.p2currentlbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.p2currentlbl.AutoSize = true;
            this.p2currentlbl.Location = new System.Drawing.Point(326, 161);
            this.p2currentlbl.Name = "p2currentlbl";
            this.p2currentlbl.Size = new System.Drawing.Size(136, 15);
            this.p2currentlbl.TabIndex = 7;
            this.p2currentlbl.Text = "Player 2 Placing Planes...";
            this.p2currentlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // setP2UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.p2currentlbl);
            this.Controls.Add(this.turnbtn);
            this.Controls.Add(this.P2titlelbl);
            this.Controls.Add(this.P2confirmbtn);
            this.Controls.Add(this.P2backbtn);
            this.Name = "setP2UC";
            this.Size = new System.Drawing.Size(901, 558);
            this.Load += new System.EventHandler(this.setP2UC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button P2backbtn;
        private System.Windows.Forms.Button P2confirmbtn;
        private System.Windows.Forms.Label P2titlelbl;
        private System.Windows.Forms.Button turnbtn;
        private System.Windows.Forms.Label p2currentlbl;
    }
}
