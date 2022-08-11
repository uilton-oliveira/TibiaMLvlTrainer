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
            tibia = new TrainMLvl();
        }

        private void activeButton_Click(object sender, EventArgs e)
        {
            tibia.processName = clientName.Text;
            if (tibia.active == false)
            {
                if (tibia.StartTimer((int)timerInterval.Value))
                {
                    timerInterval.Enabled = false;
                    activeButton.Text = "Stop";
                }
            }
            else
            {
                tibia.StopTimer();
                timerInterval.Enabled = true;
                activeButton.Text = "Start";
            }
        }
    }
}
