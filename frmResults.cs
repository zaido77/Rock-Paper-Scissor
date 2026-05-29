using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rock_Paper_Scissor
{
    public partial class frmResults : Form
    {
        stGameInfo _GameInfo;

        void ShowWinnerName()
        {
            if (_GameInfo.GameWinner == enWinner.ePlayer1)
            {
                lblWinner.Text = _GameInfo.Player1Name + " Won!";
                pnlWinner.BackColor = Color.Green;
            }
            else if (_GameInfo.GameWinner == enWinner.ePlayer2)
            {
                lblWinner.Text = _GameInfo.Player2Name + " Won!";
                
                if (_GameInfo.playAgainst == enPlayAgainst.ePlayer)
                    pnlWinner.BackColor = Color.Green;
                else
                    pnlWinner.BackColor = Settings.LoseRedColor;
            }
            else
            {
                lblWinner.Text = "      Draw!";
                pnlWinner.BackColor = Color.Orange;
            }
        }

        public frmResults(stGameInfo GameInfo)
        {
            _GameInfo = GameInfo;

            InitializeComponent();

            ShowWinnerName();

            lblPlayer1WinsTitle.Text = _GameInfo.Player1Name + " Wins";
            lblPlayer2WinsTitle.Text = _GameInfo.Player2Name + " Wins";

            lblDraws.Text = _GameInfo.DrawCount.ToString();
            lblPlayer1Wins.Text = _GameInfo.Player1WinCount.ToString();
            lblPlayer2Wins.Text = _GameInfo.Player2WinCount.ToString();
        }

        void RestartGame()
        {
            Form OldGameForm = this.Owner;
            Form GameSetupForm = OldGameForm.Owner;

            stGameInfo gameInfo = ((frmGameSetup)GameSetupForm).GameInfo;

            Form NewGameForm = new frmGame(gameInfo);
            NewGameForm.Show(GameSetupForm);

            OldGameForm.Dispose();
            this.Close();
        }

        void GoBackToMainForm()
        {
            Form GameForm = this.Owner;
            Form GameSetupForm = GameForm.Owner;
            Form MainForm = GameSetupForm.Owner;

            MainForm.Show();

            GameForm.Dispose();
            GameSetupForm.Dispose();
            this.Close();
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            RestartGame();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            GoBackToMainForm();
        }

        private void frmResults_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form GameForm = this.Owner;
            Form GameSetupForm = GameForm.Owner;

            GameSetupForm.Show();

            GameForm.Dispose();
        }
    }
}
