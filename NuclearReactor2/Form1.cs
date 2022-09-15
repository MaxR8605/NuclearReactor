using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace NuclearReactor2
{
    public partial class nuclearPowerPlant : Form
    {
        public nuclearPowerPlant()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            SoundPlayer alertPlayer = new SoundPlayer(Properties.Resources.alert);
            alertPlayer.Play();
            outputLabel.Text = "Meltdown Imminent";
            reactor1StateLabel.BackColor = Color.Red;
            reactor2StateLabel.BackColor = Color.Red;
            outputLabel.ForeColor = Color.Red;
            outputLabel.BackColor = Color.White;
            Refresh();
            Thread.Sleep(1000);
            reactor1StateLabel.BackColor = Color.White;
            reactor2StateLabel.BackColor = Color.White;
            outputLabel.ForeColor = Color.White;
            outputLabel.BackColor = Color.Red;
            Refresh();
            Thread.Sleep(1000);
            reactor1StateLabel.BackColor = Color.Red;
            reactor2StateLabel.BackColor = Color.Red;
            outputLabel.ForeColor = Color.Red;
            outputLabel.BackColor = Color.White;
            Refresh();
            Thread.Sleep(1000);
            reactor1StateLabel.BackColor = Color.White;
            reactor2StateLabel.BackColor = Color.White;
            outputLabel.ForeColor = Color.White;
            outputLabel.BackColor = Color.Red;
            Refresh();
            Thread.Sleep(1000);
            reactor1StateLabel.BackColor = Color.Red;
            reactor2StateLabel.BackColor = Color.Red;
            outputLabel.ForeColor = Color.Red;
            outputLabel.BackColor = Color.White;
            Refresh();
            Thread.Sleep(1000);
            reactor1StateLabel.BackColor = Color.White;
            reactor2StateLabel.BackColor = Color.White;
            outputLabel.ForeColor = Color.White;
            outputLabel.BackColor = Color.Red;
            Refresh();
            Thread.Sleep(1000);
        }
    }
}
