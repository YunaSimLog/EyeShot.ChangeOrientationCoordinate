using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransformCoordinate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUpZ_Click(object sender, EventArgs e)
        {
            design1.OrientationMode = devDept.Graphics.orientationType.UpAxisZ;
            design1.SetView(devDept.Eyeshot.viewType.Isometric);
            design1.Invalidate();
        }

        private void btnUpY_Click(object sender, EventArgs e)
        {
            design1.OrientationMode = devDept.Graphics.orientationType.UpAxisY;
            design1.SetView(devDept.Eyeshot.viewType.Isometric);
            design1.Invalidate();
        }
    }
}
