using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Windows.Forms;
using System.IO;

namespace Tool
{
    public class Map
    {
        /* Private variables */

        private uint _width = 0;        // number of cells in x axis
        private uint _height = 0;       // number of cells in y axis
        private uint _cellSize = 1;     // width & height of cells (pixels)

        MapTile[,] _tiles = new MapTile[0, 0];

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
            set { _width = value; }
        }

        public uint Height
        {
            get { return _height; }
            set { _height = value; }
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

        public void regenMap(uint w, uint h, uint nW, uint nH, MapTile nTile)
        {
            /* Regenerates the array of MapTiles when the map size is modified 
             * w = width, h = height, nW = new width, nH = new height 
             * nTile = new MapTile that will fill all blank spaces */

            MapTile[,] temp = new MapTile[nW, nH];

            //  Loop through all elements in old grid and apply to new grid
            for (uint i = 0; i < w; i++)
            {
                
                for(uint j = 0; j < h; j++)
                {

                    if (i < nW && j < nH)
                    {
                        //  Copy over data from old map
                        temp[i, j] = _tiles[i, j];
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
                        //temp[i, j] = new MapTile();
                        temp[i, j] = nTile;
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

        public void serialize()
        {
            /* XML Serialization:
             * Creates a new instance of Map_Serializer class
             * and calls the serialize function in the instance */

            MapTile[][] jagArray = new MapTile[_width][];

            for (uint i = 0; i < _tiles.GetLength(0); i++)
            {
                jagArray[i] = new MapTile[_tiles.GetLength(1)];

                for (uint j = 0; j < _tiles.GetLength(1); j++)
                {
                    jagArray[i][j] = _tiles[i, j];
                }
            }

            Map_Serializer serial = new Map_Serializer(_width, _height, _cellSize);
            serial._tiles = jagArray;

            serial.serialize();

        }

        public void deserialize()
        {
            /* XML Deserialization:
             * Creates a new instance of a Map_Serializer class
             * and calls the deserialize function in the instance */

            Map_Serializer serial = new Map_Serializer();
            Map temp = new Map(0, 0, 0);

            serial.deserialize(ref temp);

            //  Copy loaded values over to this map
            _cellSize = temp.CellSize;
            _width = temp.Width;
            _height = temp.Height;
            _tiles = temp._tiles;
            
        }

        public void reloadTextures(MapTile[,] loaded)
        {
            /* Reloads all textures after a new map has been loaded from a file */

            for (uint i = 0; i < _tiles.GetLength(0); i++)
            {
                for (uint j = 0; j < _tiles.GetLength(1); j++)
                {
                    MapTile temp = _tiles[i, j];

                    if (loaded.GetLength(0) < temp.TileOffsetX && loaded.GetLength(1) < temp.TileOffsetY)
                    {
                        _tiles[i, j].Image = loaded[0, 0].Image;
                    }
                    else
                    {
                        temp.Image = loaded[temp.TileOffsetX, temp.TileOffsetY].Image;
                    }

                }
            }

        }
    }
}
