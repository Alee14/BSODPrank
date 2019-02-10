namespace BSODPrank
{
    partial class Boot
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
            this.txtBoot = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // txtBoot
            // 
            this.txtBoot.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoot.BackColor = System.Drawing.Color.Black;
            this.txtBoot.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoot.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtBoot.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoot.ForeColor = System.Drawing.Color.White;
            this.txtBoot.Location = new System.Drawing.Point(1, 0);
            this.txtBoot.Name = "txtBoot";
            this.txtBoot.ReadOnly = true;
            this.txtBoot.Size = new System.Drawing.Size(509, 392);
            this.txtBoot.TabIndex = 0;
            this.txtBoot.Text = "";
            this.txtBoot.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBoot_KeyDown);
            // 
            // Boot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(510, 393);
            this.Controls.Add(this.txtBoot);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Boot";
            this.Text = "Boot";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Boot_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Boot_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtBoot;
    }
}