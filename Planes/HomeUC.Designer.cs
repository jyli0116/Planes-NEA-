namespace Planes
{
    partial class HomeUC
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
            this.startgamebtn = new System.Windows.Forms.Button();
            this.instructionsbtn = new System.Windows.Forms.Button();
            this.savedgamebtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startgamebtn
            // 
            this.startgamebtn.Location = new System.Drawing.Point(363, 258);
            this.startgamebtn.Name = "startgamebtn";
            this.startgamebtn.Size = new System.Drawing.Size(150, 59);
            this.startgamebtn.TabIndex = 0;
            this.startgamebtn.Text = "Start a New Game";
            this.startgamebtn.UseVisualStyleBackColor = true;
            this.startgamebtn.Click += new System.EventHandler(this.startgamebtn_Click);
            // 
            // instructionsbtn
            // 
            this.instructionsbtn.Location = new System.Drawing.Point(363, 323);
            this.instructionsbtn.Name = "instructionsbtn";
            this.instructionsbtn.Size = new System.Drawing.Size(150, 59);
            this.instructionsbtn.TabIndex = 2;
            this.instructionsbtn.Text = "Display Instructions";
            this.instructionsbtn.UseVisualStyleBackColor = true;
            this.instructionsbtn.Click += new System.EventHandler(this.instructionsbtn_Click);
            // 
            // savedgamebtn
            // 
            this.savedgamebtn.Location = new System.Drawing.Point(363, 388);
            this.savedgamebtn.Name = "savedgamebtn";
            this.savedgamebtn.Size = new System.Drawing.Size(150, 59);
            this.savedgamebtn.TabIndex = 3;
            this.savedgamebtn.Text = "Resume Saved Game";
            this.savedgamebtn.UseVisualStyleBackColor = true;
            this.savedgamebtn.Click += new System.EventHandler(this.savedgamebtn_Click);
            // 
            // HomeUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.savedgamebtn);
            this.Controls.Add(this.instructionsbtn);
            this.Controls.Add(this.startgamebtn);
            this.Name = "HomeUC";
            this.Size = new System.Drawing.Size(901, 558);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button startgamebtn;
        private System.Windows.Forms.Button instructionsbtn;
        private System.Windows.Forms.Button savedgamebtn;
    }
}
