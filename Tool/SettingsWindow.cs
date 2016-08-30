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

            hideDimensionEditor();
        }

        public void hideDimensionEditor()
        {
            groupBox2.Hide();
            btnNewMap.Show();
        }

        public void showDimensionEditor()
        {
            groupBox2.Show();
            btnNewMap.Hide();
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

                        //  Check for any loss of data

                        MapTile temp = new MapTile();
                        uint lostData = 0;

                        Image newImage = Image.FromFile(txtTilesetDirectory.Text);

                        if (!(_mainWindow._map.isEmpty()))
                        {
                            for (uint i = 0; i < _mainWindow._map.Width; i++)
                            {
                                for (uint j = 0; j < _mainWindow._map.Height; j++)
                                {
                                    temp = _mainWindow._map.tile(i, j);

                                    if ((uint)(newImage.Width / numUpDnTileSize.Value) <= temp.TileOffsetX || (uint)(newImage.Height / numUpDnTileSize.Value) <= temp.TileOffsetY)
                                    {
                                        /* Current map uses tiles out of the range of the currently
                                         * loaded tileset. Alert the user to this possible loss of data */
                                        lostData++;
                                    }
                                }
                            }
                        }

                        if (lostData > 0)
                        {

                            String message = "The current map uses tiles that fall out of the range of the currently loaded Tileset. These tiles will be reset to the first tile (0, 0) in the current Tileset. \nAre you sure you wish to apply this tileset? \nTiles affected: ";
                            if (MessageBox.Show(message + lostData.ToString(), "Caution", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                            {
                                _mainWindow._tilesetImage = newImage;
                                _mainWindow.MapCellSize = (uint)numUpDnTileSize.Value;
                                _mainWindow.updateTilesetImage();

                                if (!(_mainWindow._map.isEmpty()))
                                {
                                    _mainWindow.refreshMap();
                                }

                            }
                            else
                            {
                                updateNUDValues();
                            }

                        }
                        else
                        {
                            _mainWindow._tilesetImage = newImage;
                            _mainWindow.MapCellSize = (uint)numUpDnTileSize.Value;
                            _mainWindow.updateTilesetImage();

                            if (!(_mainWindow._map.isEmpty()))
                            {
                                _mainWindow.refreshMap();
                            }
                        }

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
            if (!(_mainWindow._map.isEmpty()))
            {
                numUpDnMapWidth.Value = _mainWindow._map.Width;
                numUpDnMapHeight.Value = _mainWindow._map.Height;
            }
            else
            {
                numUpDnMapWidth.Value = 1;
                numUpDnMapHeight.Value = 1;
            }
            numUpDnTileSize.Value = _mainWindow._map.CellSize;
        }

        private void btnApplyDimensions_Click(object sender, EventArgs e)
        {
            if (numUpDnMapHeight.Value >= _mainWindow._map.Height
                && numUpDnMapWidth.Value >= _mainWindow._map.Width)      //  Neither dimension will cut any data off the map
            {
                _mainWindow.regenMap(_mainWindow._map.Width, _mainWindow._map.Height, (uint)numUpDnMapWidth.Value, (uint)numUpDnMapHeight.Value);
                _mainWindow._map.Width = (uint)numUpDnMapWidth.Value;
                _mainWindow._map.Height = (uint)numUpDnMapHeight.Value;
            }
            else
            {
                /* At least one dimension will result in a smaller map than the current setup.
                 * The user should be prompted to prevent unwanted loss of data. */

                String message = "Lowering the width or height of the map may result in a possible loss of data. \nAre you sure you would like to continue?";
                if (MessageBox.Show(message, "Caution", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                    == DialogResult.Yes)
                {
                    _mainWindow.regenMap(_mainWindow._map.Width, _mainWindow._map.Height, (uint)numUpDnMapWidth.Value, (uint)numUpDnMapHeight.Value);
                    _mainWindow._map.Height = (uint)numUpDnMapHeight.Value;
                    _mainWindow._map.Width = (uint)numUpDnMapWidth.Value;

                }
                else
                {
                    _mainWindow.updateNUDValues();
                }

            }
        }

        private void btnNewMap_Click(object sender, EventArgs e)
        {
            _mainWindow.showNewMapDialog();
        }

        public void showMapOptions()
        {
            showDimensionEditor();
        }
    }
}
