using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rock_Paper_Scissor
{
    public partial class frmMain : Form
    {
        stGameInfo _GameInfo;

        public frmMain()
        {
            InitializeComponent();

            btnVsPlayer.Tag = enPlayAgainst.ePlayer;
            btnVsComputer.Tag = enPlayAgainst.eComputer;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            _GameInfo.playAgainst = (enPlayAgainst)((Button)sender).Tag;

            Form frm = new frmGameSetup(_GameInfo);
            frm.Show(this);
            this.Hide();
        }

    }
}
