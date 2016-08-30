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
    public class Map_Serializer
    {
        /* This class is only intended to allow serialization of a map class
         * by converting the 2D array to a jagged array. This is not intended
         * to be used anywhere else in the code. */

        public uint _width;
        public uint _height;
        public uint _cellSize;

        public MapTile[][] _tiles = new MapTile[1][];

        public Map_Serializer(uint cellsX, uint cellsY, uint cellSize)
        {
            _width = cellsX;
            _height = cellsY;
            _cellSize = cellSize;
        }

        public Map_Serializer()
        {
            /* Default Constructor
             * Required for serialization */
            _width = 0;
            _height = 0;
            _cellSize = 1;
        }

        public void serialize()
        {
            /* XML Serialization */

            SaveFileDialog fDialog = new SaveFileDialog();

            fDialog.Filter = "*.xml|*.xml";
            fDialog.FileName = "map.xml";
            fDialog.FilterIndex = 1;
            fDialog.RestoreDirectory = true;

            if (fDialog.ShowDialog() == DialogResult.OK)
            {
                /* Serialize and save file */

                XmlSerializer xS = new XmlSerializer(typeof(Map));
                StreamWriter sW = new StreamWriter(fDialog.FileName);

                xS.Serialize(sW, this);
                sW.Close();

            }
        }
    }
}
