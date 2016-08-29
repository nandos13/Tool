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

                if (_grid != null)
                {
                    _grid[x, y].Image = _mainWindow._currentTile.Image; //  Sets the clicked tile to the currently selected sprite

                    _grid[x, y].Invalidate(); //  This will call the paint function and display a box around the selected tile
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
