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
    public partial class frmGameSetup : Form
    {
        public stGameInfo GameInfo;

        public frmGameSetup(stGameInfo gameInfo)
        {
            GameInfo = gameInfo;

            InitializeComponent();

            LockChangingPlayer2Name();
        }

        void LockChangingPlayer2Name()
        {
            if (GameInfo.playAgainst == enPlayAgainst.eComputer)
            {
                txtPlayer2.Enabled = false;
                txtPlayer2.Text = "Computer";
            }
        }


        // ==== EVENTS ====

        private void nudRounds_ValueChanged(object sender, EventArgs e)
        {
            GameInfo.NumberOfRounds = Convert.ToByte(((NumericUpDown)sender).Value);
        }

        private void txtPlayer_TextChanged(object sender, EventArgs e)
        {
            GameInfo.Player1Name = txtPlayer1.Text.Trim();
            GameInfo.Player2Name = txtPlayer2.Text.Trim();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            GameInfo.Player1Name = txtPlayer1.Text.Trim();
            GameInfo.Player2Name = txtPlayer2.Text.Trim();

            Form frm = new frmGame(GameInfo);
            frm.Show(this);
            this.Hide();
        }

        private void frmGameSetup_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Show();
        }
    }
}
