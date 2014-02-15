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
    public partial class RaceResults : Form
    {
        public RaceResults(Score current)
        {
            InitializeComponent();
            name.Text = current.Name;
            score.Text = current.playerScore + " ";
            time.Text = current.Time + " ";
            type.Text = current.type;
        }

        private void RaceResults_Load(object sender, EventArgs e)
        {
        }
    }
}