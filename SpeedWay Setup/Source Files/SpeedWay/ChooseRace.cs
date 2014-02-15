using System;
using System.Windows.Forms;

namespace SpeedWay
{
    public partial class ChooseRace : Form
    {
        public ChooseRace()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            Score newPlayer = new Score("+", this.Nameinput.Text);
            new Race(newPlayer).Show();
            this.Close();
        }

        private void subtract_Click(object sender, EventArgs e)
        {
            Score newPlayer = new Score("-", this.Nameinput.Text);
            new Race(newPlayer).Show();
            this.Close();
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            Score newPlayer = new Score("*", this.Nameinput.Text);
            new Race(newPlayer).Show();
            this.Close();
        }

        private void divide_Click(object sender, EventArgs e)
        {
            Score newPlayer = new Score("/", this.Nameinput.Text);
            new Race(newPlayer).Show();
            this.Close();
        }

        private void all_Click(object sender, EventArgs e)
        {
            Score newPlayer = new Score("a", this.Nameinput.Text);
            new Race(newPlayer).Show();
            this.Close();
        }
    }
}