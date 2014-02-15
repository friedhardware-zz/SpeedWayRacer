using System;

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
public class Score : IComparable<Score>, SpeedWay.IScoreBoard
{
    public String Name;
    public Int32 playerScore;
    public double Time;
    public string type;
    public DateTime date;

    public Score()
    {
    }

    public Score(string type, string name)
    {
        this.type = type;
        this.Name = name;
    }

    public int CompareTo(Score obj)
    {
        return playerScore.CompareTo(obj.playerScore);
    }
}