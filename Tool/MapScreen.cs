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

            for (uint i = 0; i < _mainWindow._map.Width; i++)
            {

                for (uint j = 0; j < _mainWindow._map.Height; j++)
                {

                    _grid[i, j] = new PictureBox();
                    _grid[i, j].Parent = panelTiles;
                    _grid[i, j].Left = (int)(i * 32);
                    _grid[i, j].Top = (int)(j * 32);
                    _grid[i, j].Width = 32;
                    _grid[i, j].Height = 32;

                    _grid[i, j].SizeMode = PictureBoxSizeMode.StretchImage;
                    _grid[i, j].Visible = true;

                    _grid[i, j].Image = _mainWindow._currentTile.Image;

                    _grid[i, j].MouseClick += changeImage;

                }

            }
        }

        private void changeImage(object sender, MouseEventArgs e)
        {            
            PictureBox pbox = sender as PictureBox;
            pbox.Image = _mainWindow._currentTile.Image; //  Sets the clicked tile to the currently selected sprite
        }

        private void panelTiles_MouseClick(object sender, MouseEventArgs e)
        {
            /* Calculate which portion of the map was clicked */
            
            if(e.X < _mainWindow._map.Width * 32 && e.Y < _mainWindow._map.Height * 32)
            {

                uint cSize = 32;
                uint x = (uint)e.X / cSize;
                uint y = (uint)e.Y / cSize;

                _grid[x, y].Image = _mainWindow._currentTile.Image; //  Sets the clicked tile to the currently selected sprite

                _grid[x, y].Invalidate(); //  This will call the paint function and display a box around the selected tile

            }
        }
    }
}
