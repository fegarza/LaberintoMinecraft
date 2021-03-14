using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using WMPLib;


namespace Laberinto
{
    public static class Nucleo
    {
        public static bool ReiniciarTodo = false;
        public static void HurtSound()
        {
            WindowsMediaPlayer Hurt = new WindowsMediaPlayer();
            Hurt.URL = Application.StartupPath + @"\sounds\hurt.mp3";
            Hurt.controls.play();
        }
        public static void DeadSound()
        {

            WindowsMediaPlayer Hurt = new WindowsMediaPlayer();
            Hurt.URL = Application.StartupPath + @"\sounds\died.mp3";
            Hurt.controls.play();
        }
    }
}
