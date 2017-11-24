using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TibiaMLVL;

namespace TibiaMLVL
{
    public partial class Form1 : Form
    {
        private TrainMLvl tibia;
        
        public Form1()
        {
            InitializeComponent();
            tibia = new TrainMLvl("client");
        }

        private void activeButton_Click(object sender, EventArgs e)
        {
            if (tibia.active == false)
            {
                tibia.StartTimer((int)timerInterval.Value, checkBox1.Checked);
                timerInterval.Enabled = false;
                checkBox1.Enabled = false;
                label1.Text = "Wlaczone";
                activeButton.Text = "Stop";
            }
            else
            {
                tibia.StopTimer();
                timerInterval.Enabled = true;
                checkBox1.Enabled = true;
                label1.Text = "Wylaczone";
                activeButton.Text = "Start";
            }
        }
    }
}
