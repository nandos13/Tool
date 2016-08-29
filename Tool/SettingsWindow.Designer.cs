namespace Tool
{
    partial class SettingsWindow
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnApplyTileset = new System.Windows.Forms.Button();
            this.numUpDnTileSize = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTilesetDirectory = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBrowseTileset = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnApplyDimensions = new System.Windows.Forms.Button();
            this.numUpDnMapHeight = new System.Windows.Forms.NumericUpDown();
            this.numUpDnMapWidth = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnTileSize)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnMapHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnMapWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnApplyTileset);
            this.groupBox1.Controls.Add(this.numUpDnTileSize);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtTilesetDirectory);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnBrowseTileset);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(190, 105);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tileset";
            // 
            // btnApplyTileset
            // 
            this.btnApplyTileset.Location = new System.Drawing.Point(95, 63);
            this.btnApplyTileset.Name = "btnApplyTileset";
            this.btnApplyTileset.Size = new System.Drawing.Size(89, 35);
            this.btnApplyTileset.TabIndex = 5;
            this.btnApplyTileset.Text = "Apply";
            this.btnApplyTileset.UseVisualStyleBackColor = true;
            this.btnApplyTileset.Click += new System.EventHandler(this.btnApplyTileset_Click);
            // 
            // numUpDnTileSize
            // 
            this.numUpDnTileSize.Location = new System.Drawing.Point(9, 76);
            this.numUpDnTileSize.Maximum = new decimal(new int[] {
            128,
            0,
            0,
            0});
            this.numUpDnTileSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDnTileSize.Name = "numUpDnTileSize";
            this.numUpDnTileSize.Size = new System.Drawing.Size(80, 22);
            this.numUpDnTileSize.TabIndex = 4;
            this.numUpDnTileSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tile size (pixels):";
            // 
            // txtTilesetDirectory
            // 
            this.txtTilesetDirectory.Location = new System.Drawing.Point(9, 35);
            this.txtTilesetDirectory.Name = "txtTilesetDirectory";
            this.txtTilesetDirectory.Size = new System.Drawing.Size(146, 22);
            this.txtTilesetDirectory.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Directory:";
            // 
            // btnBrowseTileset
            // 
            this.btnBrowseTileset.Location = new System.Drawing.Point(161, 33);
            this.btnBrowseTileset.Name = "btnBrowseTileset";
            this.btnBrowseTileset.Size = new System.Drawing.Size(23, 23);
            this.btnBrowseTileset.TabIndex = 2;
            this.btnBrowseTileset.Text = "...";
            this.btnBrowseTileset.UseVisualStyleBackColor = true;
            this.btnBrowseTileset.Click += new System.EventHandler(this.btnBrowseTileset_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnApplyDimensions);
            this.groupBox2.Controls.Add(this.numUpDnMapHeight);
            this.groupBox2.Controls.Add(this.numUpDnMapWidth);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 123);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(190, 105);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Map Dimensions";
            // 
            // btnApplyDimensions
            // 
            this.btnApplyDimensions.Location = new System.Drawing.Point(95, 63);
            this.btnApplyDimensions.Name = "btnApplyDimensions";
            this.btnApplyDimensions.Size = new System.Drawing.Size(89, 35);
            this.btnApplyDimensions.TabIndex = 4;
            this.btnApplyDimensions.Text = "Apply";
            this.btnApplyDimensions.UseVisualStyleBackColor = true;
            this.btnApplyDimensions.Click += new System.EventHandler(this.btnApplyDimensions_Click);
            // 
            // numUpDnMapHeight
            // 
            this.numUpDnMapHeight.Location = new System.Drawing.Point(6, 76);
            this.numUpDnMapHeight.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numUpDnMapHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDnMapHeight.Name = "numUpDnMapHeight";
            this.numUpDnMapHeight.Size = new System.Drawing.Size(83, 22);
            this.numUpDnMapHeight.TabIndex = 3;
            this.numUpDnMapHeight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numUpDnMapWidth
            // 
            this.numUpDnMapWidth.Location = new System.Drawing.Point(6, 35);
            this.numUpDnMapWidth.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numUpDnMapWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDnMapWidth.Name = "numUpDnMapWidth";
            this.numUpDnMapWidth.Size = new System.Drawing.Size(83, 22);
            this.numUpDnMapWidth.TabIndex = 2;
            this.numUpDnMapWidth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Height:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Width:";
            // 
            // SettingsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 234);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(230, 268);
            this.MinimumSize = new System.Drawing.Size(230, 268);
            this.Name = "SettingsWindow";
            this.Text = "Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingsWindow_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnTileSize)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnMapHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnMapWidth)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numUpDnTileSize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTilesetDirectory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBrowseTileset;
        private System.Windows.Forms.Button btnApplyTileset;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnApplyDimensions;
        private System.Windows.Forms.NumericUpDown numUpDnMapHeight;
        private System.Windows.Forms.NumericUpDown numUpDnMapWidth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}