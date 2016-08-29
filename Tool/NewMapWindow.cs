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
    public partial class NewMapWindow : Form
    {
        public Form1 _mainWindow;

        public NewMapWindow()
        {
            InitializeComponent();
        }

        private void NewMapWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        private void btnApplyDimensions_Click(object sender, EventArgs e)
        {
            _mainWindow._map.Width = (uint)numUpDnMapWidth.Value;
            _mainWindow._map.Height = (uint)numUpDnMapHeight.Value;

            _mainWindow._map.newMap();
            _mainWindow.generateMap();

            _mainWindow.updateNUDValues();

            Hide();
        }

        public void updateNUDValues()
        {
            numUpDnMapWidth.Value = _mainWindow._map.Width;
            numUpDnMapHeight.Value = _mainWindow._map.Height;
        }
    }
}
