using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace CorridaDeCachorro
{
    public partial class frmMain : Form
    {

        public object locker = new object();
        private Random MyRandom = new Random();
        public List<Thread> listaThreads;
        private bool caoCampeao;

        public frmMain()
        {
            InitializeComponent();

            listaThreads = new List<Thread>{

                new Thread(c => MoveDog(pcbPrimeiroCao)){IsBackground = true},
                new Thread(c => MoveDog(pcbSegundoCao)){IsBackground = true},
                new Thread(c => MoveDog(pcbTerceiroCao)){IsBackground = true},
                new Thread(c => MoveDog(pcbQuartoCao)){IsBackground = true}
            };

        }

        private void btnTeste_Click(object sender, EventArgs e)
        {

        }

        private void MoveDog(PictureBox pcb)
        {

            while (!((pcb.Location.X) >= (pcbPistaCorrida.Width - pcb.Width)))
            {
                int distance = MyRandom.Next(4);
                Point p = pcb.Location;
                p.X += distance;

                pcb.Invoke(() => pcb.Location = p);
                pcbPistaCorrida.Invoke(() => pcbPistaCorrida.Refresh());
                Thread.Sleep(30);

            

            }

            TheWinnerDog(pcb);
        }


        private void TheWinnerDog(PictureBox pcb)
        {
            lock (locker)
            {
                if (!caoCampeao)
                    caoCampeao = true;
                this.Invoke(() => { MessageBox.Show("O grande campeao foi:" + pcb.Name); });
            }
        }
        

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            listaThreads.ForEach(caoThread => caoThread.Start());
        }
    }
}
