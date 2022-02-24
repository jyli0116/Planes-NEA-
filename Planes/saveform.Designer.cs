
namespace Planes
{
    partial class saveform
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
            this.label1 = new System.Windows.Forms.Label();
            this.slotonebtn = new System.Windows.Forms.Button();
            this.slottwobtn = new System.Windows.Forms.Button();
            this.slotthreebtn = new System.Windows.Forms.Button();
            this.slotfourbtn = new System.Windows.Forms.Button();
            this.slotfivebtn = new System.Windows.Forms.Button();
            this.cancelbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose a slot where you would like to save the game : ";
            // 
            // slotonebtn
            // 
            this.slotonebtn.Location = new System.Drawing.Point(149, 77);
            this.slotonebtn.Name = "slotonebtn";
            this.slotonebtn.Size = new System.Drawing.Size(161, 23);
            this.slotonebtn.TabIndex = 1;
            this.slotonebtn.Text = "Slot One : ";
            this.slotonebtn.UseVisualStyleBackColor = true;
            this.slotonebtn.Click += new System.EventHandler(this.slotonebtn_Click);
            // 
            // slottwobtn
            // 
            this.slottwobtn.Location = new System.Drawing.Point(149, 106);
            this.slottwobtn.Name = "slottwobtn";
            this.slottwobtn.Size = new System.Drawing.Size(161, 23);
            this.slottwobtn.TabIndex = 2;
            this.slottwobtn.Text = "Slot Two : ";
            this.slottwobtn.UseVisualStyleBackColor = true;
            this.slottwobtn.Click += new System.EventHandler(this.slottwobtn_Click);
            // 
            // slotthreebtn
            // 
            this.slotthreebtn.Location = new System.Drawing.Point(149, 135);
            this.slotthreebtn.Name = "slotthreebtn";
            this.slotthreebtn.Size = new System.Drawing.Size(161, 23);
            this.slotthreebtn.TabIndex = 3;
            this.slotthreebtn.Text = "Slot Three : ";
            this.slotthreebtn.UseVisualStyleBackColor = true;
            this.slotthreebtn.Click += new System.EventHandler(this.slotthreebtn_Click);
            // 
            // slotfourbtn
            // 
            this.slotfourbtn.Location = new System.Drawing.Point(149, 164);
            this.slotfourbtn.Name = "slotfourbtn";
            this.slotfourbtn.Size = new System.Drawing.Size(161, 23);
            this.slotfourbtn.TabIndex = 4;
            this.slotfourbtn.Text = "Slot Four : ";
            this.slotfourbtn.UseVisualStyleBackColor = true;
            this.slotfourbtn.Click += new System.EventHandler(this.slotfourbtn_Click);
            // 
            // slotfivebtn
            // 
            this.slotfivebtn.Location = new System.Drawing.Point(149, 193);
            this.slotfivebtn.Name = "slotfivebtn";
            this.slotfivebtn.Size = new System.Drawing.Size(161, 23);
            this.slotfivebtn.TabIndex = 5;
            this.slotfivebtn.Text = "Slot Five : ";
            this.slotfivebtn.UseVisualStyleBackColor = true;
            this.slotfivebtn.Click += new System.EventHandler(this.slotfivebtn_Click);
            // 
            // cancelbtn
            // 
            this.cancelbtn.Location = new System.Drawing.Point(360, 164);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(99, 52);
            this.cancelbtn.TabIndex = 6;
            this.cancelbtn.Text = "Cancel";
            this.cancelbtn.UseVisualStyleBackColor = true;
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 269);
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.slotfivebtn);
            this.Controls.Add(this.slotfourbtn);
            this.Controls.Add(this.slotthreebtn);
            this.Controls.Add(this.slottwobtn);
            this.Controls.Add(this.slotonebtn);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button slotonebtn;
        private System.Windows.Forms.Button slottwobtn;
        private System.Windows.Forms.Button slotthreebtn;
        private System.Windows.Forms.Button slotfourbtn;
        private System.Windows.Forms.Button slotfivebtn;
        private System.Windows.Forms.Button cancelbtn;
    }
}