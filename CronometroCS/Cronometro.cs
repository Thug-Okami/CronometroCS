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
        public FrmCronometro()
        {
            InitializeComponent();
        }

        public class Cronometro
        {
            Stopwatch stopwatch = new Stopwatch();
        }

        private void FrmCronometro_Load(object sender, EventArgs e)
        {

        }

        private void btnComecarPausar_Click(object sender, EventArgs e)
        {
            Stopwatch stopwatch = new Stopwatch();
            Stopwatch.Start();
        }
    }
}
