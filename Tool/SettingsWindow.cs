using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Tool
{
    public partial class SettingsWindow : Form
    {

        /* Reference to MDI parent (Main window) */
        public Form1 _mainWindow;

        public SettingsWindow()
        {
            InitializeComponent();
        }

        private void btnBrowseTileset_Click(object sender, EventArgs e)
        {
            /*Open dialog menu to select an image file. Place file directory in txtSpriteSheetDirectory*/
            OpenFileDialog fDialog = new OpenFileDialog();

            fDialog.Filter = "Image Files(*.jpg; *.png)|*.jpg;*.jpeg;*.png";
            fDialog.FilterIndex = 1;
            fDialog.RestoreDirectory = true;

            if (fDialog.ShowDialog() == DialogResult.OK)
            {
                txtTilesetDirectory.Text = fDialog.FileName;
                fDialog.Dispose();
            }
        }

        private void btnApplyTileset_Click(object sender, EventArgs e)
        {
            if(_mainWindow != null)
            {

                if (File.Exists(txtTilesetDirectory.Text))
                {

                    if (Path.GetExtension(txtTilesetDirectory.Text) == ".jpg" || 
                        Path.GetExtension(txtTilesetDirectory.Text) == ".jpeg" || 
                        Path.GetExtension(txtTilesetDirectory.Text) == ".png")
                    {

                        _mainWindow._tilesetImage = Image.FromFile(txtTilesetDirectory.Text);
                        _mainWindow.MapCellSize = (uint)numUpDnTileSize.Value;
                        _mainWindow.updateTilesetImage();

                    }

                    
                }
                
            }

        }

        private void SettingsWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        public void updateNUDValues()
        {
            numUpDnMapWidth.Value = _mainWindow._map.Width;
            numUpDnMapHeight.Value = _mainWindow._map.Height;
        }

        private void btnApplyDimensions_Click(object sender, EventArgs e)
        {
            if (numUpDnMapHeight.Value >= _mainWindow._map.Height
                && numUpDnMapWidth.Value >= _mainWindow._map.Width)      //  Neither dimension will cut any data off the map
            {

            }
            else
            {
                /* At least one dimension will result in a smaller map than the current setup.
                 * The user should be prompted to prevent unwanted loss of data. */

                String message = "Lowering the width or height of the map may result in a possible loss of data. \nAre you sure you would like to continue?";
                if (MessageBox.Show(message, "Caution", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                    == DialogResult.Yes)
                {
                    //TODO
                    _mainWindow._map.Height = (uint)numUpDnMapHeight.Value;
                    _mainWindow._map.Width = (uint)numUpDnMapWidth.Value;

                }
                else
                {
                    _mainWindow.updateNUDValues();
                }

            }
        }
    }
}
