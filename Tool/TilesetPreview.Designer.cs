namespace Tool
{
    partial class TilesetPreview
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
            this.tilePanel = new System.Windows.Forms.Panel();
            this.picBoxTileset = new System.Windows.Forms.PictureBox();
            this.tilePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTileset)).BeginInit();
            this.SuspendLayout();
            // 
            // tilePanel
            // 
            this.tilePanel.AutoScroll = true;
            this.tilePanel.AutoSize = true;
            this.tilePanel.Controls.Add(this.picBoxTileset);
            this.tilePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tilePanel.Location = new System.Drawing.Point(0, 0);
            this.tilePanel.Margin = new System.Windows.Forms.Padding(0);
            this.tilePanel.Name = "tilePanel";
            this.tilePanel.Size = new System.Drawing.Size(214, 388);
            this.tilePanel.TabIndex = 0;
            // 
            // picBoxTileset
            // 
            this.picBoxTileset.Location = new System.Drawing.Point(0, 0);
            this.picBoxTileset.Name = "picBoxTileset";
            this.picBoxTileset.Size = new System.Drawing.Size(214, 388);
            this.picBoxTileset.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBoxTileset.TabIndex = 0;
            this.picBoxTileset.TabStop = false;
            this.picBoxTileset.Paint += new System.Windows.Forms.PaintEventHandler(this.picBoxTileset_Paint);
            this.picBoxTileset.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picBoxTileset_MouseClick);
            // 
            // TilesetPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(214, 388);
            this.Controls.Add(this.tilePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(230, 422);
            this.Name = "TilesetPreview";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Tileset";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TilesetPreview_FormClosing);
            this.tilePanel.ResumeLayout(false);
            this.tilePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTileset)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel tilePanel;
        private System.Windows.Forms.PictureBox picBoxTileset;
    }
}