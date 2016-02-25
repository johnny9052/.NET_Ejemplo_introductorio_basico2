namespace CursoDotNet
{
    partial class _4_FormVectores
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
            this.btnOperVec = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOperVec
            // 
            this.btnOperVec.Location = new System.Drawing.Point(82, 23);
            this.btnOperVec.Name = "btnOperVec";
            this.btnOperVec.Size = new System.Drawing.Size(107, 23);
            this.btnOperVec.TabIndex = 0;
            this.btnOperVec.Text = "Operacion vector";
            this.btnOperVec.UseVisualStyleBackColor = true;
            this.btnOperVec.Click += new System.EventHandler(this.btnOperVec_Click);
            // 
            // _4_FormVectores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 62);
            this.Controls.Add(this.btnOperVec);
            this.Name = "_4_FormVectores";
            this.Text = "_4_FormVectores";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOperVec;
    }
}