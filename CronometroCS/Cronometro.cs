using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;

namespace CronometroCS
{
    public partial class FrmCronometro : Form
    {

        private System.Windows.Forms.Timer timer;
        private Stopwatch stopWatch;

        public FrmCronometro()
        {
            InitializeComponent();
            stopWatch = new Stopwatch();
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1;
            timer.Tick += new EventHandler(UpdateLabel);
        }

        //Inicia e pausa a contagem do cronômetro
        private void btnComecarPausar_Click_1(object sender, EventArgs e)
        {
            if (stopWatch.IsRunning)
            {
                stopWatch.Stop();
                timer.Stop();
            }
            else
            {
                stopWatch.Start();
                timer.Start();
            }
        }


        private void UpdateLabel(object sender, EventArgs e)
        {
            TimeSpan ts = stopWatch.Elapsed;

            // Formatação e visualização do valor de TimeSpan.
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:000}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 1); 

            lblTempo.Text = elapsedTime;
        }

        //Reseta o valor do cronômetro e zera a contagem
        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            stopWatch.Stop();
            timer.Stop();
            stopWatch.Reset();

            lblTempo.Text = "00:00:00.000";
        }
    }
}
