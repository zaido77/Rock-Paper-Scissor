using Rock_Paper_Scissor.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Permissions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rock_Paper_Scissor
{
    public partial class frmGame : Form
    {
        public stGameInfo _GameInfo;

        stGameInfo _InitializeGameInfo(stGameInfo GameInfo)
        {
            if (GameInfo.NumberOfRounds == 0)
                GameInfo.NumberOfRounds = 1;

            GameInfo.Rounds = new stRound[GameInfo.NumberOfRounds];

            for (int i = 0; i < GameInfo.NumberOfRounds; i++)
            {
                GameInfo.Rounds[i].RoundNumber = Convert.ToByte(i + 1);
                GameInfo.Rounds[i].Player1Choice = enChoice.eNoChoice;
                GameInfo.Rounds[i].Player2Choice = enChoice.eNoChoice;
            }
            
            GameInfo.CurrentRoundNumber = 1;

            return GameInfo;
        }

        public frmGame(stGameInfo GameInfo)
        {
            _GameInfo = _InitializeGameInfo(GameInfo);
            
            InitializeComponent();

            lblRounds.Text = $" 1 / {_GameInfo.NumberOfRounds}";
            lblPlayer1.Text = _GameInfo.Player1Name;
            lblPlayer2.Text = _GameInfo.Player2Name;

            btnRockPlayer1.Tag = enChoice.eRock;
            btnPaperPlayer1.Tag = enChoice.ePaper;
            btnScissorPlayer1.Tag = enChoice.eScissor;

            btnRockPlayer2.Tag = enChoice.eRock;
            btnPaperPlayer2.Tag = enChoice.ePaper;
            btnScissorPlayer2.Tag = enChoice.eScissor;

            if (_GameInfo.playAgainst == enPlayAgainst.eComputer)
            {
                foreach (Control control in pnlPlayer2Btns.Controls)
                {
                    control.Visible = false;
                }
            }
        }
        
        Image SetImageOpacity(Image image, float opacity) // AI Help
        {
            Bitmap bmp = new Bitmap(image.Width, image.Height);

            using (Graphics g = Graphics.FromImage(bmp))
            {
                ColorMatrix matrix = new ColorMatrix();
                matrix.Matrix33 = opacity;

                ImageAttributes attributes = new ImageAttributes();
                attributes.SetColorMatrix(matrix);

                g.DrawImage(
                    image,
                    new Rectangle(0, 0, bmp.Width, bmp.Height),
                    0, 0, image.Width, image.Height,
                    GraphicsUnit.Pixel,
                    attributes);
            }

            return bmp;
        }

        enWinner GetRoundWinner()
        {
            if (_GameInfo.Rounds[_GameInfo.CurrentRoundNumber - 1].Player1Choice ==
                _GameInfo.Rounds[_GameInfo.CurrentRoundNumber - 1].Player2Choice)
            {
                _GameInfo.DrawCount++;
                lblDraws.Text = _GameInfo.DrawCount.ToString();
                return enWinner.eDraw; 
            }

            if ((_GameInfo.Rounds[_GameInfo.CurrentRoundNumber - 1].Player1Choice == enChoice.eRock &&
                _GameInfo.Rounds[_GameInfo.CurrentRoundNumber - 1].Player2Choice == enChoice.eScissor)
                ||
                _GameInfo.Rounds[_GameInfo.CurrentRoundNumber - 1].Player1Choice == enChoice.ePaper &&
                _GameInfo.Rounds[_GameInfo.CurrentRoundNumber - 1].Player2Choice == enChoice.eRock
                ||
                _GameInfo.Rounds[_GameInfo.CurrentRoundNumber - 1].Player1Choice == enChoice.eScissor &&
                _GameInfo.Rounds[_GameInfo.CurrentRoundNumber - 1].Player2Choice == enChoice.ePaper)

            {
                _GameInfo.Player1WinCount++;
                lblPlayer1Wins.Text = _GameInfo.Player1WinCount.ToString();
                return enWinner.ePlayer1;
            }

            else
            {
                _GameInfo.Player2WinCount++;
                lblPlayer2Wins.Text = _GameInfo.Player2WinCount.ToString();
                return enWinner.ePlayer2;
            }
        }

        void GoToNextRound()
        {
            _GameInfo.CurrentRoundNumber++;
            lblRounds.Text = $" {_GameInfo.CurrentRoundNumber} / {_GameInfo.NumberOfRounds}";

            pnlPlayer1Btns.Enabled = true;
            pnlPlayer2Btns.Enabled = true;

            lblPlayer2.ForeColor = Settings.SecondaryColor;
            pnlPlayer2Btns.BackColor = SystemColors.ActiveCaption;
            lblPlayer1.ForeColor = Settings.SecondaryColor;
            pnlPlayer1Btns.BackColor = SystemColors.ActiveCaption;

            pbPlayer1Choice.Image = null;
            pbPlayer2Choice.Image = null;
        }

        enWinner GetGameWinner()
        {
            if (_GameInfo.Player1WinCount == _GameInfo.Player2WinCount)
                return enWinner.eDraw;
            else if (_GameInfo.Player1WinCount > _GameInfo.Player2WinCount)
                return enWinner.ePlayer1;
            else 
                return enWinner.ePlayer2;
        }

        void EndGame()
        {
            _GameInfo.GameWinner = GetGameWinner();

            Form frm = new frmResults(_GameInfo);
            frm.Show(this);
            this.Hide();
        }

        void PerformRoundResultAction()
        {
            if (_GameInfo.Rounds[_GameInfo.CurrentRoundNumber - 1].RoundWinner == enWinner.ePlayer1)
            {
                lblPlayer1.ForeColor = Color.Green;
                pnlPlayer1Btns.BackColor = Color.Green;
                lblPlayer2.ForeColor = Settings.LoseRedColor;
                pnlPlayer2Btns.BackColor = Settings.LoseRedColor;
            }
            else if (_GameInfo.Rounds[_GameInfo.CurrentRoundNumber - 1].RoundWinner == enWinner.ePlayer2)
            {
                lblPlayer2.ForeColor = Color.Green;
                pnlPlayer2Btns.BackColor = Color.Green;
                lblPlayer1.ForeColor = Settings.LoseRedColor;
                pnlPlayer1Btns.BackColor = Settings.LoseRedColor;
            }
            else
            {
                lblPlayer2.ForeColor = Color.Orange;
                pnlPlayer2Btns.BackColor = Color.Orange;
                lblPlayer1.ForeColor = Color.Orange;
                pnlPlayer1Btns.BackColor = Color.Orange;
            }

            RoundTimer.Start();
        }

        void EvaluateRound()
        {
            _GameInfo.Rounds[_GameInfo.CurrentRoundNumber - 1].RoundWinner = GetRoundWinner();

            PerformRoundResultAction();
        }

        void SetPlayer2RandomChoice()
        {
            Random random = new Random();
            enChoice choice = (enChoice)(random.Next() % 3);

            if (choice == enChoice.eRock)
            {
                PerformPlayer2Click(btnRockPlayer2);
            }
            else if (choice == enChoice.ePaper)
            {
                PerformPlayer2Click(btnPaperPlayer2);
            }
            else if (choice == enChoice.eScissor)
            {
                PerformPlayer2Click(btnScissorPlayer2);
            }
        }

        bool AreChoicesDone()
        {
            return _GameInfo.Rounds[_GameInfo.CurrentRoundNumber - 1].Player1Choice != enChoice.eNoChoice &&
                _GameInfo.Rounds[_GameInfo.CurrentRoundNumber - 1].Player2Choice != enChoice.eNoChoice;
        }

        void PerformPlayer1Click(Button btn)
        {
            if (_GameInfo.playAgainst == enPlayAgainst.eComputer)
            {
                SetPlayer2RandomChoice();
                Thread.Sleep(100);
            }

            _GameInfo.Rounds[_GameInfo.CurrentRoundNumber - 1].Player1Choice = (enChoice)btn.Tag;

            pbPlayer1Choice.Image = btn.BackgroundImage;

            pnlPlayer1Btns.Enabled = false;

            if (AreChoicesDone())
                EvaluateRound();
        }

        void PerformPlayer2Click(Button btn)
        {
            _GameInfo.Rounds[_GameInfo.CurrentRoundNumber - 1].Player2Choice = (enChoice)btn.Tag;

            pbPlayer2Choice.Image = btn.BackgroundImage;

            pnlPlayer2Btns.Enabled = false;

            if (AreChoicesDone())
                EvaluateRound();
        }

        void PerformRoundTimerTick()
        {
            RoundTimer.Stop();

            if (_GameInfo.CurrentRoundNumber < _GameInfo.NumberOfRounds)
                GoToNextRound();
            else
                EndGame();
        }

        // ==== EVENTS ====

        private void btnRockPaperScissorPlayer1_MouseEnter(object sender, EventArgs e)
        {
            if (_GameInfo.Rounds[_GameInfo.CurrentRoundNumber - 1].Player1Choice == enChoice.eNoChoice)
                pbPlayer1Choice.Image = SetImageOpacity(((Button)sender).BackgroundImage, 0.5f);
        }

        private void btnRockPaperScissorPlayer2_MouseEnter(object sender, EventArgs e)
        {
            if (_GameInfo.Rounds[_GameInfo.CurrentRoundNumber - 1].Player2Choice == enChoice.eNoChoice)
                pbPlayer2Choice.Image = SetImageOpacity(((Button)sender).BackgroundImage, 0.5f);
        }

        private void btnRockPaperScissorPlayer1_MouseLeave(object sender, EventArgs e)
        {
            if (_GameInfo.Rounds[_GameInfo.CurrentRoundNumber - 1].Player1Choice == enChoice.eNoChoice)
                pbPlayer1Choice.Image = null;
        }

        private void btnRockPaperScissorPlayer2_MouseLeave(object sender, EventArgs e)
        {
            if (_GameInfo.Rounds[_GameInfo.CurrentRoundNumber - 1].Player2Choice == enChoice.eNoChoice)
                pbPlayer2Choice.Image = null;
        }

        private void btnRockPaperScissorPlayer1_Click(object sender, EventArgs e)
        {
            Button btn = ((Button)sender);
            PerformPlayer1Click(btn);
        }

        private void btnRockPaperScissorPlayer2_Click(object sender, EventArgs e)
        {
            Button btn = ((Button)sender);
            PerformPlayer2Click(btn);
        }

        private void RoundTimer_Tick(object sender, EventArgs e)
        {
            PerformRoundTimerTick();
        }

        private void frmGame_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Show();
        }
    }
}