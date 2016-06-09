using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace isoraSurvey
{
    public partial class ISORA_Form : Form
    {
        public ISORA_Form()
        {
            InitializeComponent();
        }

        private void CantRunProgramButton_Click(object sender, EventArgs e)
        {
            IpAndMac mac = new IpAndMac();
            IDText.Enabled = false;
            mac.ShowDialog();
        }

        private bool enableMove = false;
        private Point startingMousePoint = new Point(0, 0);
        private void ISORA_Form_MouseUp(object sender, MouseEventArgs e)
        {
            enableMove = false;
        }

        private void ISORA_Form_MouseDown(object sender, MouseEventArgs e)
        {
            enableMove = true;
            startingMousePoint = new Point(e.X, e.Y);
        }

        private void ISORA_Form_MouseMove(object sender, MouseEventArgs e)
        {
            if (enableMove)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - startingMousePoint.X - 5, p.Y - startingMousePoint.Y - 30);
            }
        }
    }
}
