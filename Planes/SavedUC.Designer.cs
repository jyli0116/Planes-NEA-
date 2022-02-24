
namespace Planes
{
    partial class SavedUC
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
            this.savedbackbtn = new System.Windows.Forms.Button();
            this.slotonebtn = new System.Windows.Forms.Button();
            this.slottwobtn = new System.Windows.Forms.Button();
            this.slotthreebtn = new System.Windows.Forms.Button();
            this.slotfourbtn = new System.Windows.Forms.Button();
            this.slotfivebtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // savedgameslbl
            // 
            this.savedgameslbl.AutoSize = true;
            this.savedgameslbl.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.savedgameslbl.Location = new System.Drawing.Point(332, 92);
            this.savedgameslbl.Name = "savedgameslbl";
            this.savedgameslbl.Size = new System.Drawing.Size(252, 50);
            this.savedgameslbl.TabIndex = 1;
            this.savedgameslbl.Text = "Saved Games";
            // 
            // savedbackbtn
            // 
            this.savedbackbtn.Location = new System.Drawing.Point(19, 20);
            this.savedbackbtn.Name = "savedbackbtn";
            this.savedbackbtn.Size = new System.Drawing.Size(75, 56);
            this.savedbackbtn.TabIndex = 4;
            this.savedbackbtn.Text = "back";
            this.savedbackbtn.UseVisualStyleBackColor = true;
            this.savedbackbtn.Click += new System.EventHandler(this.savedbackbtn_Click);
            // 
            // slotonebtn
            // 
            this.slotonebtn.Location = new System.Drawing.Point(291, 243);
            this.slotonebtn.Name = "slotonebtn";
            this.slotonebtn.Size = new System.Drawing.Size(320, 40);
            this.slotonebtn.TabIndex = 5;
            this.slotonebtn.Text = "Slot One : ";
            this.slotonebtn.UseVisualStyleBackColor = true;
            this.slotonebtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // slottwobtn
            // 
            this.slottwobtn.Location = new System.Drawing.Point(291, 289);
            this.slottwobtn.Name = "slottwobtn";
            this.slottwobtn.Size = new System.Drawing.Size(320, 40);
            this.slottwobtn.TabIndex = 6;
            this.slottwobtn.Text = "Slot Two : ";
            this.slottwobtn.UseVisualStyleBackColor = true;
            this.slottwobtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // slotthreebtn
            // 
            this.slotthreebtn.Location = new System.Drawing.Point(291, 335);
            this.slotthreebtn.Name = "slotthreebtn";
            this.slotthreebtn.Size = new System.Drawing.Size(320, 40);
            this.slotthreebtn.TabIndex = 7;
            this.slotthreebtn.Text = "Slot Three : ";
            this.slotthreebtn.UseVisualStyleBackColor = true;
            this.slotthreebtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // slotfourbtn
            // 
            this.slotfourbtn.Location = new System.Drawing.Point(291, 381);
            this.slotfourbtn.Name = "slotfourbtn";
            this.slotfourbtn.Size = new System.Drawing.Size(320, 40);
            this.slotfourbtn.TabIndex = 8;
            this.slotfourbtn.Text = "Slot Four : ";
            this.slotfourbtn.UseVisualStyleBackColor = true;
            this.slotfourbtn.Click += new System.EventHandler(this.button4_Click);
            // 
            // slotfivebtn
            // 
            this.slotfivebtn.Location = new System.Drawing.Point(291, 427);
            this.slotfivebtn.Name = "slotfivebtn";
            this.slotfivebtn.Size = new System.Drawing.Size(320, 40);
            this.slotfivebtn.TabIndex = 9;
            this.slotfivebtn.Text = "Slot Five : ";
            this.slotfivebtn.UseVisualStyleBackColor = true;
            this.slotfivebtn.Click += new System.EventHandler(this.button5_Click);
            // 
            // SavedUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.slotfivebtn);
            this.Controls.Add(this.slotfourbtn);
            this.Controls.Add(this.slotthreebtn);
            this.Controls.Add(this.slottwobtn);
            this.Controls.Add(this.slotonebtn);
            this.Controls.Add(this.savedbackbtn);
            this.Controls.Add(this.savedgameslbl);
            this.Name = "SavedUC";
            this.Size = new System.Drawing.Size(901, 558);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label savedgameslbl;
        private System.Windows.Forms.Button savedbackbtn;
        private System.Windows.Forms.Button slotonebtn;
        private System.Windows.Forms.Button slottwobtn;
        private System.Windows.Forms.Button slotthreebtn;
        private System.Windows.Forms.Button slotfourbtn;
        private System.Windows.Forms.Button slotfivebtn;
    }
}
