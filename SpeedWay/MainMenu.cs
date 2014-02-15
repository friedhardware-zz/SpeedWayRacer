using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new ChooseRace().Show();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            try
            {
                using (FileStream stream = new FileStream("C:\\data.xml", FileMode.Open))
                {
                    XmlSerializer ser = new XmlSerializer(typeof(List<Score>));

                    foreach (Score score in (List<Score>)ser.Deserialize(stream))
                    {
                        MyGlobals.ListOfScores.Add(score);
                    }

                    stream.Flush();
                    stream.Close();
                }
            }
            catch (IOException)
            { }
        }

        private void MainExit_Click(object sender, EventArgs e)
        {
            {
                using (FileStream stream = new FileStream("C:\\data.xml", FileMode.Create))
                {
                    MyGlobals.ListOfScores.Sort();
                    XmlSerializer ser = new XmlSerializer(typeof(List<Score>));
                    ser.Serialize(stream, MyGlobals.ListOfScores);
                    stream.Flush();
                    stream.Close();
                }
            }

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        { new HighScores().Show(); }

        private void label2_Click(object sender, EventArgs e)
        { new License().Show(); }
    }
}