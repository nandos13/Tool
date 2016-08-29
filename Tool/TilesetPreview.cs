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
    
    public partial class TilesetPreview : Form
    {

        /* Reference to MDI parent (Main window) */
        public Form1 _mainWindow;

        private uint tilesX = 0;
        private uint tilesY = 0;

        private Point currentSelectedTile = new Point(-50, -50);


        public TilesetPreview()
        {
            InitializeComponent();

            UpdateImage();

        }

        public void UpdateImage()
        {

            if (_mainWindow != null)
            {

                if (_mainWindow._tilesetImage != null)
                {

                    picBoxTileset.Image = _mainWindow._tilesetImage;
                    Bitmap temp = new Bitmap(_mainWindow._tilesetImage);

                    tilesX = (uint)(_mainWindow._tilesetImage.Width / _mainWindow.MapCellSize);
                    tilesY = (uint)(_mainWindow._tilesetImage.Height / _mainWindow.MapCellSize);

                    _mainWindow._loadedTiles = new MapTile[tilesX, tilesY];
                    uint cSize = _mainWindow.MapCellSize;

                    //  Load all tiles in the image
                    for (uint i = 0; i < tilesX; i++)
                    {

                        for (uint j = 0; j < tilesY; j++)
                        {

                            Rectangle tileArea = new Rectangle((int)(i*cSize), (int)(j*cSize), (int)(cSize), (int)(cSize));
                            Bitmap tile = (Bitmap)temp.Clone(tileArea, temp.PixelFormat);

                            _mainWindow._loadedTiles[i, j] = new MapTile(tile);

                        }

                    }
                    
                }

            }

        }

        private void TilesetPreview_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        private void picBoxTileset_MouseClick(object sender, MouseEventArgs e)
        {
            /* Calculate which portion of the image was clicked */

            if(e.X < _mainWindow._tilesetImage.Width && e.Y < _mainWindow._tilesetImage.Height)
            {

                uint cSize = _mainWindow.MapCellSize;
                uint x = (uint) e.X / cSize;
                uint y = (uint) e.Y / cSize;

                currentSelectedTile = new Point((int)x, (int)y);

                _mainWindow._currentTile = _mainWindow._loadedTiles[x, y];
                
                picBoxTileset.Invalidate(); //  This will call the paint function and display a box around the selected tile

            }

        }

        private void picBoxTileset_Paint(object sender, PaintEventArgs e)
        {
            /* Draws a rectangle around the selected tile */

            uint cSize = _mainWindow.MapCellSize;
            Rectangle rect = new Rectangle((int)(currentSelectedTile.X * cSize), (int)(currentSelectedTile.Y * cSize), (int)cSize, (int)cSize);
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.DeepPink, 2);
            pen.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;
            g.DrawRectangle(pen, rect);
            
            pen.Dispose();
        }
    }
}
