using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laberinto
{
    public partial class died : Form
    {
        public died()
        {
            InitializeComponent();
            Nucleo.DeadSound();
        }

        private void btnRespawn_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRespawn_Click(object sender, EventArgs e)
        {
            Nucleo.ReiniciarTodo = true;
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
