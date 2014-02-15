using System.IO;
using System.Linq;
using System.Text;
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
    public partial class HighScores : Form
    {
        public HighScores()
        {
            InitializeComponent();
        }

        private void sortButton_Click(object sender, System.EventArgs e)
        {
            dataGrid.Rows.Clear();
            if (sortByList1.Text == "Name")
                SortScoresbyName();
            else if (sortByList1.Text == "Date")
                SortScoresbyDate();
            else
                SortScoresbyScore();
        }

        public void SortScoresbyScore()
        {
            MyGlobals.ListOfScores.Sort();
            int n = 0;

            foreach (Score score in MyGlobals.ListOfScores.OrderByDescending(c => c.playerScore).ThenBy(c => c.Time).Take(150))
            {
                n = addRow(n, score);
            }
        }

        public void SortScoresbyDate()
        {
            MyGlobals.ListOfScores.Sort();
            int n = 0;

            foreach (Score score in MyGlobals.ListOfScores.OrderByDescending(c => c.date).ThenBy(c => c.Name).Take(150))
            {
                n = addRow(n, score);
            }
        }

        public void SortScoresbyName()
        {
            MyGlobals.ListOfScores.Sort();
            int n = 0;

            foreach (Score score in MyGlobals.ListOfScores.OrderBy(c => c.Name).ThenBy(c => c.date).Take(150))
            {
                n = addRow(n, score);
            }
        }

        private int addRow(int n, Score score)
        {
            n = dataGrid.Rows.Add();

            dataGrid.Rows[n].Cells[0].Value = score.Name;
            dataGrid.Rows[n].Cells[1].Value = score.playerScore;
            dataGrid.Rows[n].Cells[2].Value = score.Time;
            dataGrid.Rows[n].Cells[3].Value = score.date;
            return n;
        }

        private void outbutton_Click(object sender, System.EventArgs e)
        {
            string filePath = @"C:\records.csv";
            string delimiter = ";";
            string[] scoreObject = new string[5];

            StringBuilder sb = new StringBuilder();
            foreach (Score score in MyGlobals.ListOfScores.OrderBy(c => c.Name).ThenBy(c => c.date))
            {
                scoreObject[0] = score.Name;
                scoreObject[1] = score.date + " ";
                scoreObject[2] = score.Time + " ";
                scoreObject[3] = score.playerScore + " ";
                scoreObject[4] = score.type + " ";

                sb.AppendLine(string.Join(delimiter, scoreObject));
            }

            File.WriteAllText(filePath, sb.ToString());
        }
    }
}