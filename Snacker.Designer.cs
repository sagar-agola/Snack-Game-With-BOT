namespace SnackGame
{
    partial class Snacker
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
            this.LblMenu = new System.Windows.Forms.Label();
            this.LblStartStop = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblMenu
            // 
            this.LblMenu.AutoSize = true;
            this.LblMenu.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMenu.Location = new System.Drawing.Point(187, 28);
            this.LblMenu.Name = "LblMenu";
            this.LblMenu.Padding = new System.Windows.Forms.Padding(5);
            this.LblMenu.Size = new System.Drawing.Size(152, 46);
            this.LblMenu.TabIndex = 0;
            this.LblMenu.Text = "Snacker.IO";
            this.LblMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblStartStop
            // 
            this.LblStartStop.AutoSize = true;
            this.LblStartStop.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblStartStop.Location = new System.Drawing.Point(158, 166);
            this.LblStartStop.Name = "LblStartStop";
            this.LblStartStop.Padding = new System.Windows.Forms.Padding(5);
            this.LblStartStop.Size = new System.Drawing.Size(211, 166);
            this.LblStartStop.TabIndex = 4;
            this.LblStartStop.Text = "[Space] to Start/Pause\r\n\r\n\r\n[Enter] to Play \r\n\r\n[B] to Enable BOT";
            this.LblStartStop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Snacker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 400);
            this.Controls.Add(this.LblStartStop);
            this.Controls.Add(this.LblMenu);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(516, 439);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(516, 439);
            this.Name = "Snacker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Snacker.IO";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Snacker_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Snacker_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblMenu;
        private System.Windows.Forms.Label LblStartStop;
    }
}

