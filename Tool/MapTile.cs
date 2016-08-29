using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Tool
{
    public class MapTile
    {
        /*Private Variables*/

        Bitmap _tileTexture;

        public MapTile()
        {
            _tileTexture = null;
        }

        public MapTile(Bitmap t)
        {
            _tileTexture = t;
        }

        public Bitmap Image
        {
            get { return _tileTexture; }
        }

    }
}
