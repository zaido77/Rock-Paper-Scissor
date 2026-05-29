using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissor
{
    public enum enPlayAgainst : byte
    {
        ePlayer = 0,
        eComputer = 1,
    }

    public enum enChoice
    {
        eRock = 0,
        ePaper = 1,
        eScissor = 2,
        eNoChoice = 3,
    }

    public enum enWinner
    {
        ePlayer1 = 0,
        ePlayer2 = 1,
        eDraw = 2,
    }

    public struct stRound
    {
        public byte RoundNumber;
        public enChoice Player1Choice;
        public enChoice Player2Choice;
        public enWinner RoundWinner;
    }

    public struct stGameInfo
    {
        public enPlayAgainst playAgainst;
        public byte NumberOfRounds;
        public byte CurrentRoundNumber;
        public string Player1Name;
        public string Player2Name;
        public byte Player1WinCount;
        public byte Player2WinCount;
        public byte DrawCount;
        public stRound[] Rounds;
        public enWinner GameWinner;
    }

}
