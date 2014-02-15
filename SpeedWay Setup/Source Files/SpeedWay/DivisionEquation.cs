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

namespace SpeedWay
{
    public class DivisionEquation : SpeedWay.IEquation
    {
        public int firstNumber;
        public int secondNumber;
        public string sign;
        private int answer;

        public int getNumber(int num)
        {
            if (num == 1)
                return firstNumber;
            return secondNumber;
        }

        public void computeAnswer()
        {
            answer = firstNumber + secondNumber;
        }

        public void buildEquation()
        {
            Random random = new Random();
            answer = random.Next(0, 12);
            secondNumber = random.Next(0, 12);
            firstNumber = answer * secondNumber;
        }

        public Boolean CheckSolution(int answerGiven)
        {
            if (firstNumber / secondNumber == answerGiven)
                return true;
            return false;
        }
    }
}