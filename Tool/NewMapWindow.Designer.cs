namespace Tool
{
    partial class NewMapWindow
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnApplyDimensions = new System.Windows.Forms.Button();
            this.numUpDnMapHeight = new System.Windows.Forms.NumericUpDown();
            this.numUpDnMapWidth = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnMapHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnMapWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnApplyDimensions);
            this.groupBox2.Controls.Add(this.numUpDnMapHeight);
            this.groupBox2.Controls.Add(this.numUpDnMapWidth);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(190, 105);
            this.groupBox2.TabIndex = 2;
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
            // NewMapWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 122);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "NewMapWindow";
            this.Text = "New Map";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NewMapWindow_FormClosing);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnMapHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnMapWidth)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnApplyDimensions;
        private System.Windows.Forms.NumericUpDown numUpDnMapHeight;
        private System.Windows.Forms.NumericUpDown numUpDnMapWidth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}