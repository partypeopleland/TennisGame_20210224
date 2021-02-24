using System;
using System.Collections.Generic;

namespace TennisGame_20210224
{
    public class TennisGame
    {
        private readonly string _player1Name;
        private readonly string _player2Name;

        private readonly Dictionary<int, string> _scoreMap = new()
        {
            {0, "Love"},
            {1, "Fifteen"},
            {2, "Thirty"},
            {3, "Forty"}
        };

        private int _player1Score;
        private int _player2Score;

        public TennisGame(string player1Name, string player2Name)
        {
            _player1Name = player1Name;
            _player2Name = player2Name;
        }

        public string Score()
        {
            if (IsSameScore()) return IsDeuce() ? ResultDeuce() : ResultSameScore();

            if (IsReadyToWin()) return IsAdv() ? ResultAdv() : ResultWin();

            return ResultMapScore();
        }

        private string ResultMapScore()
        {
            return $"{_scoreMap[_player1Score]} {_scoreMap[_player2Score]}";
        }

        private bool IsSameScore()
        {
            return _player1Score == _player2Score;
        }

        private bool IsDeuce()
        {
            return _player1Score >= 3;
        }

        private static string ResultDeuce()
        {
            return "Deuce";
        }

        private string ResultSameScore()
        {
            return $"{_scoreMap[_player1Score]} All";
        }

        private string ResultWin()
        {
            return $"{AdvPlayer()} Win";
        }

        private string ResultAdv()
        {
            return $"{AdvPlayer()} Adv";
        }

        private bool IsReadyToWin()
        {
            return _player1Score > 3 || _player2Score > 3;
        }

        private bool IsAdv()
        {
            return Math.Abs(_player1Score - _player2Score) == 1;
        }

        private string AdvPlayer()
        {
            return _player1Score > _player2Score ? _player1Name : _player2Name;
        }

        public void SetPlayer1(int score)
        {
            _player1Score = score;
        }

        public void SetPlayer2(int score)
        {
            _player2Score = score;
        }
    }
}