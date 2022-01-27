namespace Planes
{
    partial class InstructionsUC
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
            this.howtoplaylbl = new System.Windows.Forms.Label();
            this.instructionslbl = new System.Windows.Forms.Label();
            this.instructionbackbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // howtoplaylbl
            // 
            this.howtoplaylbl.AutoSize = true;
            this.howtoplaylbl.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.howtoplaylbl.Location = new System.Drawing.Point(315, 154);
            this.howtoplaylbl.Name = "howtoplaylbl";
            this.howtoplaylbl.Size = new System.Drawing.Size(239, 50);
            this.howtoplaylbl.TabIndex = 0;
            this.howtoplaylbl.Text = "How To Play";
            // 
            // instructionslbl
            // 
            this.instructionslbl.Location = new System.Drawing.Point(201, 289);
            this.instructionslbl.Name = "instructionslbl";
            this.instructionslbl.Size = new System.Drawing.Size(479, 216);
            this.instructionslbl.TabIndex = 1;
            this.instructionslbl.Text = "here are some instructions";
            // 
            // instructionbackbtn
            // 
            this.instructionbackbtn.Location = new System.Drawing.Point(19, 19);
            this.instructionbackbtn.Name = "instructionbackbtn";
            this.instructionbackbtn.Size = new System.Drawing.Size(75, 56);
            this.instructionbackbtn.TabIndex = 3;
            this.instructionbackbtn.Text = "back";
            this.instructionbackbtn.UseVisualStyleBackColor = true;
            this.instructionbackbtn.Click += new System.EventHandler(this.instructionbackbtn_Click);
            // 
            // InstructionsUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.instructionbackbtn);
            this.Controls.Add(this.instructionslbl);
            this.Controls.Add(this.howtoplaylbl);
            this.Name = "InstructionsUC";
            this.Size = new System.Drawing.Size(901, 558);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label howtoplaylbl;
        private System.Windows.Forms.Label instructionslbl;
        private System.Windows.Forms.Button instructionbackbtn;
    }
}
