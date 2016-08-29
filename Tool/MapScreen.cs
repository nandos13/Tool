using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tool
{
    public partial class MapScreen : Form
    {

        /* Reference to MDI parent (Main window) */
        public Form1 _mainWindow;

        /* Member Variables */
        PictureBox[,] _grid;

        private Point currentSelectedTile = new Point(-50, -50);

        public MapScreen()
        {
            InitializeComponent();
        }

        private void MapScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        public void generateMap()
        {
            _grid = new PictureBox[(_mainWindow._map.Width), (_mainWindow._map.Height)];
        }

        private void panelTiles_Paint(object sender, PaintEventArgs e)
        {

            for (uint i = 0; i < _mainWindow._map.Width; i++)
            {

                for (uint j = 0; j < _mainWindow._map.Height; j++)
                {

                    _grid[i, j].Parent = panelTiles;

                    if (_mainWindow._map.tile(i, j) != null)
                    {
                        _grid[i, j].Image = _mainWindow._map.tile(i, j).Image;
                    }
                    else
                    {
                        _grid[i, j].Image = SystemIcons.Error.ToBitmap();
                    }

                    _grid[i, j].Left = (int)(i * _mainWindow.MapCellSize);
                    _grid[i, j].Top = (int)(j * _mainWindow.MapCellSize);
                    _grid[i, j].Width = 32;
                    _grid[i, j].Height = 32;
                    _grid[i, j].Visible = true;

                }

            }

        }

        private void panelTiles_MouseClick(object sender, MouseEventArgs e)
        {
            /* Calculate which portion of the map was clicked */
            
            if(e.X < _mainWindow._map.Width * 32 && e.Y < _mainWindow._map.Height * 32)
            {

                uint cSize = 32;
                uint x = (uint)e.X / cSize;
                uint y = (uint)e.Y / cSize;

                currentSelectedTile = new Point((int)x, (int)y);

                panelTiles.Invalidate(); //  This will call the paint function and display a box around the selected tile

            }
        }
    }
}
