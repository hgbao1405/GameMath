namespace GameMathWinform.Forms
{
    partial class HighScore
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
            this.SuspendLayout();
            // 
            // HighScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 410);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(355, 457);
            this.MinimumSize = new System.Drawing.Size(355, 457);
            this.Name = "HighScore";
            this.ShowIcon = false;
            this.Text = "High Score";
            this.Load += new System.EventHandler(this.HighScore_Load);
            this.ResumeLayout(false);

        }

        #endregion
    }
}