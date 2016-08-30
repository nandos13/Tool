using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Xml.Serialization;

namespace Tool
{
    public class MapTile
    {
        /*Private Variables*/

        private Bitmap _tileTexture;
        private int _tileOffsetX;
        private int _tileOffsetY;

        public MapTile()
        {
            _tileTexture = null;
            _tileOffsetX = 0;
            _tileOffsetY = 0;
        }

        public MapTile(Bitmap t)
        {
            _tileTexture = t;
        }

        [XmlIgnore]
        public Bitmap Image
        {
            get { return _tileTexture; }
            set { _tileTexture = value; }
        }

        public int TileOffsetX
        {
            get { return _tileOffsetX; }
            set { _tileOffsetX = value; }
        }

        public int TileOffsetY
        {
            get { return _tileOffsetY; }
            set { _tileOffsetY = value; }
        }

    }
}
