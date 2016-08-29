namespace Tool
{
    partial class MapScreen
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
            this.panelTiles = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panelTiles
            // 
            this.panelTiles.AutoSize = true;
            this.panelTiles.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelTiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTiles.Location = new System.Drawing.Point(0, 0);
            this.panelTiles.Name = "panelTiles";
            this.panelTiles.Size = new System.Drawing.Size(746, 668);
            this.panelTiles.TabIndex = 2;
            this.panelTiles.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelTiles_MouseClick);
            // 
            // MapScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(746, 668);
            this.Controls.Add(this.panelTiles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(450, 450);
            this.Name = "MapScreen";
            this.ShowIcon = false;
            this.Text = "Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MapScreen_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelTiles;
    }
}