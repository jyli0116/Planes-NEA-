
namespace Planes
{
    partial class noPlayersUC
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
            this.noplayerslbl = new System.Windows.Forms.Label();
            this.p1btn = new System.Windows.Forms.Button();
            this.p2btn = new System.Windows.Forms.Button();
            this.playersbackbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // noplayerslbl
            // 
            this.noplayerslbl.AutoSize = true;
            this.noplayerslbl.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.noplayerslbl.Location = new System.Drawing.Point(281, 154);
            this.noplayerslbl.Name = "noplayerslbl";
            this.noplayerslbl.Size = new System.Drawing.Size(308, 50);
            this.noplayerslbl.TabIndex = 0;
            this.noplayerslbl.Text = "Settings: Players";
            // 
            // p1btn
            // 
            this.p1btn.Location = new System.Drawing.Point(280, 290);
            this.p1btn.Name = "p1btn";
            this.p1btn.Size = new System.Drawing.Size(114, 104);
            this.p1btn.TabIndex = 1;
            this.p1btn.Text = "One Player Game";
            this.p1btn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.p1btn.UseVisualStyleBackColor = true;
            this.p1btn.Click += new System.EventHandler(this.p1btn_Click);
            // 
            // p2btn
            // 
            this.p2btn.Location = new System.Drawing.Point(475, 290);
            this.p2btn.Name = "p2btn";
            this.p2btn.Size = new System.Drawing.Size(114, 104);
            this.p2btn.TabIndex = 2;
            this.p2btn.Text = "Two Player Game";
            this.p2btn.UseVisualStyleBackColor = true;
            this.p2btn.Click += new System.EventHandler(this.p2btn_Click);
            // 
            // playersbackbtn
            // 
            this.playersbackbtn.Location = new System.Drawing.Point(19, 19);
            this.playersbackbtn.Name = "playersbackbtn";
            this.playersbackbtn.Size = new System.Drawing.Size(75, 56);
            this.playersbackbtn.TabIndex = 3;
            this.playersbackbtn.Text = "back";
            this.playersbackbtn.UseVisualStyleBackColor = true;
            this.playersbackbtn.Click += new System.EventHandler(this.playersbackbtn_Click);
            // 
            // noPlayersUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.playersbackbtn);
            this.Controls.Add(this.p2btn);
            this.Controls.Add(this.p1btn);
            this.Controls.Add(this.noplayerslbl);
            this.Name = "noPlayersUC";
            this.Size = new System.Drawing.Size(901, 558);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label noplayerslbl;
        private System.Windows.Forms.Button p1btn;
        private System.Windows.Forms.Button p2btn;
        private System.Windows.Forms.Button playersbackbtn;
    }
}
