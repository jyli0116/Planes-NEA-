namespace Planes
{
    partial class savedgameUC
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
            this.savedgameslbl = new System.Windows.Forms.Label();
            this.savedbackbutton = new System.Windows.Forms.Button();
            this.slotonebtn = new System.Windows.Forms.Button();
            this.slottwobtn = new System.Windows.Forms.Button();
            this.slotthreebtn = new System.Windows.Forms.Button();
            this.slotfourbtn = new System.Windows.Forms.Button();
            this.slotfivebtn = new System.Windows.Forms.Button();
            this.gamedetaillbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // savedgameslbl
            // 
            this.savedgameslbl.AutoSize = true;
            this.savedgameslbl.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.savedgameslbl.Location = new System.Drawing.Point(313, 154);
            this.savedgameslbl.Name = "savedgameslbl";
            this.savedgameslbl.Size = new System.Drawing.Size(252, 50);
            this.savedgameslbl.TabIndex = 0;
            this.savedgameslbl.Text = "Saved Games";
            // 
            // savedbackbutton
            // 
            this.savedbackbutton.Location = new System.Drawing.Point(19, 19);
            this.savedbackbutton.Name = "savedbackbutton";
            this.savedbackbutton.Size = new System.Drawing.Size(75, 56);
            this.savedbackbutton.TabIndex = 3;
            this.savedbackbutton.Text = "back";
            this.savedbackbutton.UseVisualStyleBackColor = true;
            this.savedbackbutton.Click += new System.EventHandler(this.playersbackbtn_Click);
            // 
            // slotonebtn
            // 
            this.slotonebtn.Location = new System.Drawing.Point(550, 225);
            this.slotonebtn.Name = "slotonebtn";
            this.slotonebtn.Size = new System.Drawing.Size(250, 45);
            this.slotonebtn.TabIndex = 4;
            this.slotonebtn.Text = "Game One : ";
            this.slotonebtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.slotonebtn.UseVisualStyleBackColor = true;
            this.slotonebtn.Click += new System.EventHandler(this.slotonebtn_Click);
            // 
            // slottwobtn
            // 
            this.slottwobtn.Location = new System.Drawing.Point(550, 276);
            this.slottwobtn.Name = "slottwobtn";
            this.slottwobtn.Size = new System.Drawing.Size(250, 45);
            this.slottwobtn.TabIndex = 4;
            this.slottwobtn.Text = "Game Two : ";
            this.slottwobtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.slottwobtn.UseVisualStyleBackColor = true;
            this.slottwobtn.Click += new System.EventHandler(this.slottwobtn_Click);
            // 
            // slotthreebtn
            // 
            this.slotthreebtn.Location = new System.Drawing.Point(550, 327);
            this.slotthreebtn.Name = "slotthreebtn";
            this.slotthreebtn.Size = new System.Drawing.Size(250, 45);
            this.slotthreebtn.TabIndex = 4;
            this.slotthreebtn.Text = "Game Three : ";
            this.slotthreebtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.slotthreebtn.UseVisualStyleBackColor = true;
            this.slotthreebtn.Click += new System.EventHandler(this.slotthreebtn_Click);
            // 
            // slotfourbtn
            // 
            this.slotfourbtn.Location = new System.Drawing.Point(550, 378);
            this.slotfourbtn.Name = "slotfourbtn";
            this.slotfourbtn.Size = new System.Drawing.Size(250, 45);
            this.slotfourbtn.TabIndex = 4;
            this.slotfourbtn.Text = "Game Four : ";
            this.slotfourbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.slotfourbtn.UseVisualStyleBackColor = true;
            this.slotfourbtn.Click += new System.EventHandler(this.slotfourbtn_Click);
            // 
            // slotfivebtn
            // 
            this.slotfivebtn.Location = new System.Drawing.Point(550, 429);
            this.slotfivebtn.Name = "slotfivebtn";
            this.slotfivebtn.Size = new System.Drawing.Size(250, 45);
            this.slotfivebtn.TabIndex = 4;
            this.slotfivebtn.Text = "Game Five : ";
            this.slotfivebtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.slotfivebtn.UseVisualStyleBackColor = true;
            this.slotfivebtn.Click += new System.EventHandler(this.slotfivebtn_Click);
            // 
            // gamedetaillbl
            // 
            this.gamedetaillbl.Location = new System.Drawing.Point(111, 225);
            this.gamedetaillbl.Name = "gamedetaillbl";
            this.gamedetaillbl.Size = new System.Drawing.Size(347, 249);
            this.gamedetaillbl.TabIndex = 5;
            this.gamedetaillbl.Text = "game labels";
            // 
            // savedgameUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gamedetaillbl);
            this.Controls.Add(this.slotfivebtn);
            this.Controls.Add(this.slotfourbtn);
            this.Controls.Add(this.slotthreebtn);
            this.Controls.Add(this.slottwobtn);
            this.Controls.Add(this.slotonebtn);
            this.Controls.Add(this.savedbackbutton);
            this.Controls.Add(this.savedgameslbl);
            this.Name = "savedgameUC";
            this.Size = new System.Drawing.Size(901, 558);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label savedgameslbl;
        private System.Windows.Forms.Button savedbackbutton;
        private System.Windows.Forms.Button slotonebtn;
        private System.Windows.Forms.Button slottwobtn;
        private System.Windows.Forms.Button slotthreebtn;
        private System.Windows.Forms.Button slotfourbtn;
        private System.Windows.Forms.Button slotfivebtn;
        private System.Windows.Forms.Label gamedetaillbl;
    }
}
