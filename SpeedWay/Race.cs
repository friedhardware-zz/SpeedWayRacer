using System;
using System.Windows.Forms;

//Copyright 2012 Josh Schumacher
//This file is part of SpeedWay.
//
//SpeedWay is free software: you can redistribute it and/or modify it
//under the terms of the GNU General Public License as published by the
//Free Software Foundation, either version 3 of the License, or any later version.
//
//SpeedWay is distributed in the hope that it will be useful, but WITHOUT ANY
//WARRANTY; without even the implied warranty of MECHANTABILITY or FITNESS FOR
//A PARTICULAR PURPOSE. See the GNU General Public License for more details.
//
//You should have received a copy of the GNU General Public License
//along with SpeedWay.  If not, see <http://www.gnu.org/licenses/>.
//

namespace SpeedWay
{
    public partial class Race : Form
    {
        int numberofQuestions = 100;
        Random random = new Random();
        DateTime startTime = DateTime.Now;
        TimeSpan stopTime;
        IEquation equation;
        Score player;

        public Race(Score player)
        {
            this.player = player;
            player.date = DateTime.Now;
            InitializeComponent();
            SetDefault(this.button1);
            if (player.type == "+")
            {
                sign.Text = "+";
                equation = new AdditionEquation();
            }
            else if (player.type == "-")
            {
                sign.Text = "-";
                equation = new SubtractionEquation();
            }
            else if (player.type == "*")
            {
                sign.Text = "x";
                equation = new MultiplicationEquation();
            }
            else if (player.type == "/")
            {
                sign.Text = "÷";
                equation = new DivisionEquation();
            }
            equation.buildEquation();
            x.Text = equation.getNumber(1) + " ";
            y.Text = equation.getNumber(2) + " ";
            equation.computeAnswer();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.answerField.Text.Equals(""))
                {
                    return;
                }

                if (equation.CheckSolution(Int32.Parse(answerField.Text)))
                {
                    player.playerScore++;
                }

                increaseCounter();
                equation.buildEquation();
                x.Text = equation.getNumber(1) + " ";
                y.Text = equation.getNumber(2) + " ";
                equation.computeAnswer();

                this.answerField.Text = "";
            }
            catch (FormatException) { }
        }

        private void ExitRace_Click(object sender, EventArgs e)
        { this.Close(); }

        private void increaseCounter()
        {
            this.number.Text = (Int32.Parse(this.number.Text) + 1) + " ";
            if (Int32.Parse(this.number.Text) <= numberofQuestions)
            { }
            else
            { RaceOver(); }
        }

        private void RaceOver()
        {
            stopTime = DateTime.Now.Subtract(startTime);
            player.Time = Math.Truncate(stopTime.TotalSeconds);
            MyGlobals.ListOfScores.Add(player);
            new RaceResults(player).Show();
            this.Close();
        }

        private void SetDefault(Button myDefaultBtn)
        {
            this.AcceptButton = myDefaultBtn;
        }
    }
}