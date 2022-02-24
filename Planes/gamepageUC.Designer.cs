
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
            this.gametitlelbl = new System.Windows.Forms.Label();
            this.statuslbl = new System.Windows.Forms.Label();
            this.p1lbl = new System.Windows.Forms.Label();
            this.p2lbl = new System.Windows.Forms.Label();
            this.savebtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exitgamebtn
            // 
            this.exitgamebtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.exitgamebtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exitgamebtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.exitgamebtn.Location = new System.Drawing.Point(19, 19);
            this.exitgamebtn.Name = "exitgamebtn";
            this.exitgamebtn.Size = new System.Drawing.Size(105, 56);
            this.exitgamebtn.TabIndex = 4;
            this.exitgamebtn.Text = "EXIT";
            this.exitgamebtn.UseVisualStyleBackColor = false;
            this.exitgamebtn.Click += new System.EventHandler(this.exitgamebtn_Click);
            // 
            // gametitlelbl
            // 
            this.gametitlelbl.AutoSize = true;
            this.gametitlelbl.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gametitlelbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gametitlelbl.Location = new System.Drawing.Point(358, 19);
            this.gametitlelbl.Name = "gametitlelbl";
            this.gametitlelbl.Size = new System.Drawing.Size(161, 50);
            this.gametitlelbl.TabIndex = 6;
            this.gametitlelbl.Text = "PLANES";
            // 
            // statuslbl
            // 
            this.statuslbl.AutoSize = true;
            this.statuslbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.statuslbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.statuslbl.Location = new System.Drawing.Point(404, 108);
            this.statuslbl.Name = "statuslbl";
            this.statuslbl.Size = new System.Drawing.Size(70, 21);
            this.statuslbl.TabIndex = 7;
            this.statuslbl.Text = "playing...";
            // 
            // p1lbl
            // 
            this.p1lbl.AutoSize = true;
            this.p1lbl.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.p1lbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.p1lbl.Location = new System.Drawing.Point(19, 136);
            this.p1lbl.Name = "p1lbl";
            this.p1lbl.Size = new System.Drawing.Size(91, 25);
            this.p1lbl.TabIndex = 8;
            this.p1lbl.Text = "PLAYER 1";
            // 
            // p2lbl
            // 
            this.p2lbl.AutoSize = true;
            this.p2lbl.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.p2lbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.p2lbl.Location = new System.Drawing.Point(746, 136);
            this.p2lbl.Name = "p2lbl";
            this.p2lbl.Size = new System.Drawing.Size(91, 25);
            this.p2lbl.TabIndex = 9;
            this.p2lbl.Text = "PLAYER 2";
            // 
            // savebtn
            // 
            this.savebtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.savebtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.savebtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.savebtn.Location = new System.Drawing.Point(19, 81);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(105, 35);
            this.savebtn.TabIndex = 10;
            this.savebtn.Text = "SAVE";
            this.savebtn.UseVisualStyleBackColor = false;
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // gamepageUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.savebtn);
            this.Controls.Add(this.p2lbl);
            this.Controls.Add(this.p1lbl);
            this.Controls.Add(this.statuslbl);
            this.Controls.Add(this.gametitlelbl);
            this.Controls.Add(this.exitgamebtn);
            this.Name = "gamepageUC";
            this.Size = new System.Drawing.Size(901, 558);
            this.Load += new System.EventHandler(this.gamepageUC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitgamebtn;
        private System.Windows.Forms.Label gametitlelbl;
        private System.Windows.Forms.Label statuslbl;
        private System.Windows.Forms.Label p1lbl;
        private System.Windows.Forms.Label p2lbl;
        private System.Windows.Forms.Button savebtn;
    }
}
