namespace Planes
{
    partial class difficultyUC
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.easybtn = new System.Windows.Forms.Button();
            this.mediumbtn = new System.Windows.Forms.Button();
            this.hardbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(19, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 56);
            this.button1.TabIndex = 3;
            this.button1.Text = "back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(278, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 50);
            this.label1.TabIndex = 4;
            this.label1.Text = "Setting: Difficulty";
            // 
            // easybtn
            // 
            this.easybtn.Location = new System.Drawing.Point(190, 280);
            this.easybtn.Name = "easybtn";
            this.easybtn.Size = new System.Drawing.Size(148, 104);
            this.easybtn.TabIndex = 5;
            this.easybtn.Text = "Easy";
            this.easybtn.UseVisualStyleBackColor = true;
            this.easybtn.Click += new System.EventHandler(this.easybtn_Click);
            // 
            // mediumbtn
            // 
            this.mediumbtn.Location = new System.Drawing.Point(370, 280);
            this.mediumbtn.Name = "mediumbtn";
            this.mediumbtn.Size = new System.Drawing.Size(148, 104);
            this.mediumbtn.TabIndex = 5;
            this.mediumbtn.Text = "Medium";
            this.mediumbtn.UseVisualStyleBackColor = true;
            this.mediumbtn.Click += new System.EventHandler(this.mediumbtn_Click);
            // 
            // hardbtn
            // 
            this.hardbtn.Location = new System.Drawing.Point(550, 280);
            this.hardbtn.Name = "hardbtn";
            this.hardbtn.Size = new System.Drawing.Size(148, 104);
            this.hardbtn.TabIndex = 5;
            this.hardbtn.Text = "Hard";
            this.hardbtn.UseVisualStyleBackColor = true;
            this.hardbtn.Click += new System.EventHandler(this.hardbtn_Click);
            // 
            // difficultyUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.hardbtn);
            this.Controls.Add(this.mediumbtn);
            this.Controls.Add(this.easybtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "difficultyUC";
            this.Size = new System.Drawing.Size(901, 558);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button easybtn;
        private System.Windows.Forms.Button mediumbtn;
        private System.Windows.Forms.Button hardbtn;
    }
}
