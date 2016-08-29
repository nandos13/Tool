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
    public partial class Form1 : Form
    {

        /* One instance of each window */

        private SettingsWindow  window_settings = new SettingsWindow();
        private MapScreen       window_mapEditor = new MapScreen();
        private TilesetPreview  window_tileset = new TilesetPreview();
        private NewMapWindow    window_new = new NewMapWindow();

        /* Member Variables */

        public Map _map = new Map(10, 10, 1);
        public Image _tilesetImage;
        public MapTile[,] _loadedTiles = new MapTile[0, 0];
        public MapTile _currentTile = null;


        public Form1()
        {
            InitializeComponent();

            /* Set starting positions of MDI child-windows */

            window_settings.MdiParent = this;
            window_settings.StartPosition = FormStartPosition.Manual;
            window_settings.Location = new Point(0, 0);
            window_settings._mainWindow = this;

            window_mapEditor.MdiParent = this;
            window_mapEditor.StartPosition = FormStartPosition.Manual;
            window_mapEditor.Location = new Point(window_settings.Width + 12, 0);
            window_mapEditor._mainWindow = this;

            window_tileset.MdiParent = this;
            window_tileset.StartPosition = FormStartPosition.Manual;
            window_tileset.Location = new Point(0, window_settings.Height + 12);
            window_tileset._mainWindow = this;

            window_new._mainWindow = this;

            /* Create new map 10x10 */

            _map.CellSize = 1;
            _map.Width = 1;
            _map.Height = 1;
            window_settings.updateNUDValues();
        }

        public uint MapWidth
        {
            get { return _map.Width; }
            set { _map.Width = value; }
        }

        public uint MapHeight
        {
            get { return _map.Height; }
            set { _map.Height = value; }
        }

        public uint MapCellSize
        {
            get { return _map.CellSize; }
            set { _map.CellSize = value; }
        }

        public void updateTilesetImage()
        {
            window_tileset.UpdateImage();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            window_settings.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            window_settings.Show();
            window_mapEditor.Show();
            window_tileset.Show();
        }

        private void mapEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            window_mapEditor.Show();
        }

        private void tilesetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            window_tileset.Show();
        }

        private void closeAllWindows()
        {
            //TODO: CHECK IF SAVED WARNING SHOULD BE SHOWN
            window_settings.Close();
            window_mapEditor.Close();
            window_tileset.Close();
            window_new.Close();
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(e.CloseReason == CloseReason.UserClosing)
            {
                closeAllWindows();
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeAllWindows();
        }

        public void showNewMapDialog()
        {
            /* Allows the user to create a new map, as long as a tileset has first been chosen */

            if (_tilesetImage == null)
            {
                //  Prompt user to select a tileset first
                String message = "Please provide a Tileset before creating a new map";
                MessageBox.Show(message, "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                //  Show dialog for new map
                window_new.updateNUDValues();
                window_new.ShowDialog();
            }
            
        }

        public void settingsShowMapOptions()
        {
            window_settings.showMapOptions();
        }

        private void newMapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showNewMapDialog();
        }

        public void updateNUDValues()
        {
            window_settings.updateNUDValues();
        }

        public void generateMap()
        {
            window_mapEditor.generateMap();
        }

        public void regenMap(uint w, uint h, uint nW, uint nH)
        {
            _map.regenMap(w, h, nW, nH);
            window_mapEditor.regenMap(w, h, nW, nH);
        }
    }
}
