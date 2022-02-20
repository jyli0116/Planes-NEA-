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
            this.button1 = new System.Windows.Forms.Button();
            this.p1currentlbl = new System.Windows.Forms.Label();
            this.autobtn = new System.Windows.Forms.Button();
            this.clearbtn = new System.Windows.Forms.Button();
            this.undobtn = new System.Windows.Forms.Button();
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(753, 289);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Turn";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.turnbtn_Click);
            // 
            // p1currentlbl
            // 
            this.p1currentlbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.p1currentlbl.AutoSize = true;
            this.p1currentlbl.Location = new System.Drawing.Point(326, 161);
            this.p1currentlbl.Name = "p1currentlbl";
            this.p1currentlbl.Size = new System.Drawing.Size(136, 15);
            this.p1currentlbl.TabIndex = 7;
            this.p1currentlbl.Text = "Player 1 Placing Planes...";
            this.p1currentlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // autobtn
            // 
            this.autobtn.Location = new System.Drawing.Point(753, 318);
            this.autobtn.Name = "autobtn";
            this.autobtn.Size = new System.Drawing.Size(75, 23);
            this.autobtn.TabIndex = 8;
            this.autobtn.Text = "Auto";
            this.autobtn.UseVisualStyleBackColor = true;
            this.autobtn.Click += new System.EventHandler(this.autobtn_Click);
            // 
            // clearbtn
            // 
            this.clearbtn.Location = new System.Drawing.Point(753, 347);
            this.clearbtn.Name = "clearbtn";
            this.clearbtn.Size = new System.Drawing.Size(75, 23);
            this.clearbtn.TabIndex = 9;
            this.clearbtn.Text = "Clear";
            this.clearbtn.UseVisualStyleBackColor = true;
            this.clearbtn.Click += new System.EventHandler(this.clearbtn_Click);
            // 
            // undobtn
            // 
            this.undobtn.Location = new System.Drawing.Point(753, 376);
            this.undobtn.Name = "undobtn";
            this.undobtn.Size = new System.Drawing.Size(75, 23);
            this.undobtn.TabIndex = 10;
            this.undobtn.Text = "Undo";
            this.undobtn.UseVisualStyleBackColor = true;
            this.undobtn.Click += new System.EventHandler(this.undobtn_Click);
            // 
            // setP1UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.undobtn);
            this.Controls.Add(this.clearbtn);
            this.Controls.Add(this.autobtn);
            this.Controls.Add(this.p1currentlbl);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label p1currentlbl;
        private System.Windows.Forms.Button autobtn;
        private System.Windows.Forms.Button clearbtn;
        private System.Windows.Forms.Button undobtn;
    }
}
