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
            /* Remove all tiles from the screen */

            if (_grid != null)
            {
                for (uint i = 0; i < _grid.GetLength(0); i++)
                {
                    for (uint j = 0; j < _grid.GetLength(1); j++)
                    {
                        _grid[i, j].Visible = false;
                        _grid[i, j].Enabled = false;
                    }
                }
            }
            
            
            /* Generate new tiles and display them on the screen */

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

                    _mainWindow._map.setTile(i, j, _mainWindow._currentTile);

                }

            }
        }

        private void changeImage(object sender, MouseEventArgs e)
        {
            PictureBox pbox = sender as PictureBox;

            if (e.Button == MouseButtons.Left)
            {
                /* Left Click: Set the clicked tile to the currently selected sprite */
                
                pbox.Image = _mainWindow._currentTile.Image;

                //  Get the index of the tile in the map
                
                uint x = (uint)(pbox.Left / pbox.Width);    //  Gets the first-dimension index of the tile
                uint y = (uint)(pbox.Top / pbox.Height);    //  Gets the second-dimension index of the tile

                _mainWindow._map.setTile(x, y, _mainWindow._currentTile);

            }
            else if (e.Button == MouseButtons.Right)
            {
                /* Right Click: Set the current sprite to that of the clicked tile.
                 * This acts similar to the "eye drop" tool in other applications */

                uint x = 0, y = 0;
                MapTile temp = _mainWindow.findTile(pbox.Image, ref x, ref y);

                if (temp != null)
                {
                    _mainWindow._currentTile = temp;
                    _mainWindow.settingsSetHilitedTile(x, y);
                }

            }
            
        }

        public void regenMap(uint w, uint h, uint nW, uint nH)
        {
            /* Regenerates the map when the map size is modified 
             * w = width, h = height, nW = new width, nH = new height */

            PictureBox[,] temp = new PictureBox[nW, nH];

            //  Loop through all elements in old grid and apply to new grid
            for (uint i = 0; i < w; i++)
            {

                for (uint j = 0; j < h; j++)
                {

                    if (i < nW && j < nH)
                    {
                        //  Copy over data from old map
                        temp[i, j] = _grid[i, j];
                    }

                }

            }

            //  Loop through all elements in new grid and initialize any null elements
            for (uint i = 0; i < nW; i++)
            {

                for (uint j = 0; j < nH; j++)
                {

                    if (temp[i, j] == null)
                    {
                        //  Set to new tile
                        temp[i, j] = new PictureBox();
                        temp[i, j].Parent = panelTiles;
                        temp[i, j].Left = (int)(i * 32);
                        temp[i, j].Top = (int)(j * 32);
                        temp[i, j].Width = 32;
                        temp[i, j].Height = 32;

                        temp[i, j].SizeMode = PictureBoxSizeMode.StretchImage;
                        temp[i, j].Visible = true;

                        temp[i, j].Image = _mainWindow._currentTile.Image;

                        temp[i, j].MouseClick += changeImage;
                    }

                }

            }

            //  Delete elements not carried over
            if (w > nW)
            {
                //  One or more columns will be deleted
                for (uint i = nW; i < w; i++)
                {
                    for (uint j = 0; j < h; j++)
                    {
                        _grid[i, j].Visible = false;
                        _grid[i, j].Enabled = false;
                    }
                }
            }

            if (h > nH)
            {
                //  One or more rows will be deleted
                for (uint i = 0; i < w; i++)
                {
                    for (uint j = nH; j < h; j++)
                    {
                        _grid[i, j].Visible = false;
                        _grid[i, j].Enabled = false;
                    }
                }
            }

            _grid = temp;

        }
    }
}
