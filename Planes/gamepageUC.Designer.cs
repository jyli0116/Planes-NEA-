
namespace Planes
{
    partial class gamepageUC
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
            this.exitgamebtn = new System.Windows.Forms.Button();
            this.savegamebtn = new System.Windows.Forms.Button();
            this.gametitlelbl = new System.Windows.Forms.Label();
            this.statuslbl = new System.Windows.Forms.Label();
            this.p1lbl = new System.Windows.Forms.Label();
            this.p2lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // exitgamebtn
            // 
            this.exitgamebtn.Location = new System.Drawing.Point(19, 19);
            this.exitgamebtn.Name = "exitgamebtn";
            this.exitgamebtn.Size = new System.Drawing.Size(105, 56);
            this.exitgamebtn.TabIndex = 4;
            this.exitgamebtn.Text = "Exit";
            this.exitgamebtn.UseVisualStyleBackColor = true;
            this.exitgamebtn.Click += new System.EventHandler(this.exitgamebtn_Click);
            // 
            // savegamebtn
            // 
            this.savegamebtn.Location = new System.Drawing.Point(777, 19);
            this.savegamebtn.Name = "savegamebtn";
            this.savegamebtn.Size = new System.Drawing.Size(105, 56);
            this.savegamebtn.TabIndex = 5;
            this.savegamebtn.Text = "Save";
            this.savegamebtn.UseVisualStyleBackColor = true;
            this.savegamebtn.Click += new System.EventHandler(this.savegamebtn_Click);
            // 
            // gametitlelbl
            // 
            this.gametitlelbl.AutoSize = true;
            this.gametitlelbl.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gametitlelbl.Location = new System.Drawing.Point(378, 25);
            this.gametitlelbl.Name = "gametitlelbl";
            this.gametitlelbl.Size = new System.Drawing.Size(134, 50);
            this.gametitlelbl.TabIndex = 6;
            this.gametitlelbl.Text = "Planes";
            // 
            // statuslbl
            // 
            this.statuslbl.AutoSize = true;
            this.statuslbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.statuslbl.Location = new System.Drawing.Point(404, 108);
            this.statuslbl.Name = "statuslbl";
            this.statuslbl.Size = new System.Drawing.Size(70, 21);
            this.statuslbl.TabIndex = 7;
            this.statuslbl.Text = "playing...";
            // 
            // p1lbl
            // 
            this.p1lbl.AutoSize = true;
            this.p1lbl.Location = new System.Drawing.Point(19, 136);
            this.p1lbl.Name = "p1lbl";
            this.p1lbl.Size = new System.Drawing.Size(48, 15);
            this.p1lbl.TabIndex = 8;
            this.p1lbl.Text = "Player 1";
            // 
            // p2lbl
            // 
            this.p2lbl.AutoSize = true;
            this.p2lbl.Location = new System.Drawing.Point(834, 136);
            this.p2lbl.Name = "p2lbl";
            this.p2lbl.Size = new System.Drawing.Size(48, 15);
            this.p2lbl.TabIndex = 9;
            this.p2lbl.Text = "Player 2";
            // 
            // gamepageUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.p2lbl);
            this.Controls.Add(this.p1lbl);
            this.Controls.Add(this.statuslbl);
            this.Controls.Add(this.gametitlelbl);
            this.Controls.Add(this.savegamebtn);
            this.Controls.Add(this.exitgamebtn);
            this.Name = "gamepageUC";
            this.Size = new System.Drawing.Size(901, 558);
            this.Load += new System.EventHandler(this.gamepageUC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitgamebtn;
        private System.Windows.Forms.Button savegamebtn;
        private System.Windows.Forms.Label gametitlelbl;
        private System.Windows.Forms.Label statuslbl;
        private System.Windows.Forms.Label p1lbl;
        private System.Windows.Forms.Label p2lbl;
    }
}
