using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tool
{
    public class Map
    {
        /* Private variables */

        private uint _width = 10;       // number of cells in x axis
        private uint _height = 10;      // number of cells in y axis
        private uint _cellSize;         // width & height of cells (pixels)

        MapTile[,] _tiles = new MapTile[10, 10];

        /* Constructor */

        public Map(uint cellsX, uint cellsY, uint cellSize)
        {
            _width = cellsX;
            _height = cellsY;
            _cellSize = cellSize;
        }

        public uint Width
        {
            get { return _width; }
            set { regenMap(_width, _height, value, _height);  _width = value; }
        }

        public uint Height
        {
            get { return _height; }
            set { regenMap(_width, _height, _width, value);  _height = value; }
        }

        public uint CellSize
        {
            get { return _cellSize; }
            set { _cellSize = value; }
        }

        public void setTile(uint x, uint y, MapTile data)
        {
            _tiles[x, y] = data;
        }

        private void regenMap(uint w, uint h, uint nW, uint nH)
        {
            /* Regenerates the array of MapTiles when the map size is modified 
             * w = width, h = height, nW = new width, nH = new height */

            MapTile[,] temp = new MapTile[nW, nH];

            for(uint i = 0; i < w; i++)
            {
                
                for(uint j = 0; j < h; j++)
                {

                    if (i < nW && j < nH)
                    {

                        temp[i, j] = _tiles[i, j];

                    }

                }

            }

            _tiles = temp;

        }

        public void newMap()
        {
            /* Loops through the array of MapTiles and sets them all to new tiles */

            _tiles = new MapTile[_width, _height];

        }

        public MapTile tile(uint x, uint y)
        {
            return _tiles[x, y];
        }

        //
    }
}
