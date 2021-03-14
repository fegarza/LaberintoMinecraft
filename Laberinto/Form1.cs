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
    public partial class Form1 : Form
    {

        List<List<Cuadro>> listaBidimencional = new List<List<Cuadro>>();
        public static string ultimaDireccion = "inicio";
        public static int R = 0;
        public static int C = 0;
        Image Obstaculo = (Image.FromFile(Application.StartupPath + @"\img\cerrado.jpg").GetThumbnailImage(70, 70, null, IntPtr.Zero));
        Image Camino = (Image.FromFile(Application.StartupPath + @"\img\pasa.png").GetThumbnailImage(70, 70, null, IntPtr.Zero));
        Image Recorrido = (Image.FromFile(Application.StartupPath +@"\img\guija.png").GetThumbnailImage(70, 70, null, IntPtr.Zero));
        //SoundPlayer Hurt = new SoundPlayer(Application.StartupPath+@"\sounds\hurt.mp3");
        public Form1()
        {
            
            InitializeComponent();
            DataGridViewImageColumn imageCol = new DataGridViewImageColumn();
            IncializarDatos();
        }
        public void IncializarDatos()
        {
            listaBidimencional.Clear();

            for (int x = 1; x <= 10; x++)
            {
                visualizador.Columns.Add("", "");
            }
            for (int x = 1; x <= 10; x++)
            {
                visualizador.Rows.Add("");
            }

            for (int x = 0; x < 10; x++)
            {

                listaBidimencional.Add(new List<Cuadro>());
                for (int y = 0; y < 10; y++)
                {
                    if ((x == 9 && y == 9) || (x == 0 && y == 0))
                    {
                        listaBidimencional[x].Add(new Cuadro());
                        visualizador[y, x].Value = "1";
                        listaBidimencional[x][y].SePuedePasar = true;
                        visualizador[y, x].Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(137)))), ((int)(((byte)(220)))));
                    }
                    else {
                        visualizador[x, y].Value = "0";
                        listaBidimencional[x].Add(new Cuadro());
                    }
                    
                }
            }
        }
        async Task Esperar(int x)
        {
            await Task.Delay(x);
        }
        private void visualizador_SelectionChanged(object sender, EventArgs e)
        {
            int Fila = visualizador.CurrentCell.RowIndex;
            int Columna = visualizador.CurrentCell.ColumnIndex;
            if (!((Fila == 9 && Columna == 9) || (Fila == 0 && Columna == 0)))
            {
                if (listaBidimencional[Fila][Columna].SePuedePasar)
                {
                    visualizador[Columna, Fila].Value = "0";
                    listaBidimencional[Fila][Columna].SePuedePasar = false;
                    visualizador[Columna, Fila].Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(37)))), ((int)(((byte)(36)))));
                }
                else
                {
                    visualizador[Columna, Fila].Value = "1";
                    listaBidimencional[Fila][Columna].SePuedePasar = true;
                    visualizador[Columna, Fila].Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(137)))), ((int)(((byte)(220)))));
                }
            }

                
        }
        private async void btnIniciar_Click(object sender, EventArgs e)
        {



            #region  ACOMODAR TODO LO GRAFICO

            C = 0;
            R = 0;
            visualizador.Visible = false;
            Grafico.Visible = true;
            Grafico.Rows.Clear();
            Grafico.Columns.Clear();
           
            for (int x = 1; x <= 10; x++)
            {
                Grafico.Columns.Add(new DataGridViewImageColumn());
            }
            for (int x = 1; x <= 10; x++)
            {
                Grafico.Rows.Add(Image.FromFile(Application.StartupPath + @"\img\guija.png"));
            }
            Grafico.ClearSelection();
            for (int x = 0; x < 10; x++)
            {

                for (int y = 0; y < 10; y++)
                {

                    if (listaBidimencional[x][y].SePuedePasar)

                    {
                        Grafico.Rows[x].Cells[y].Value = Camino;
                    }
                    else
                    {
                        Grafico.Rows[x].Cells[y].Value = Obstaculo;
                    }

                }
            }
            Grafico.Rows[0].Cells[0].Value = (Image.FromFile(Application.StartupPath + @"\img\steve.jpg").GetThumbnailImage(70, 70, null, IntPtr.Zero));
            Grafico.Rows[9].Cells[9].Value = (Image.FromFile(Application.StartupPath + @"\img\fin.jpeg").GetThumbnailImage(70, 70, null, IntPtr.Zero));
            #endregion
            while (C != 9 || R != 9)
            {
                //Agregar pisadas
                listaBidimencional[R][C].Pisadas++;
                #region  VERIFICAR POSIBLES LUGARES A MOVERSE
                bool derecha, arriba, abajo, izquierda;
                //Verificar si se puede mover a la derecha
                derecha = (C == 9) ? false : listaBidimencional[R][C + 1].SePuedePasar;
                //Verificar si se puede mover a la izquierda
                izquierda = (C == 0) ? false : listaBidimencional[R][C - 1].SePuedePasar;
                //Verificar si se puede mover hacia arriba
                arriba = (R == 0) ? false : listaBidimencional[R - 1][C].SePuedePasar;
                //Verificar si se puede mover abajo
                abajo = (R == 9) ? false : listaBidimencional[R + 1][C].SePuedePasar;

                //Establecer el movimiento por el que se ingreso a la casillas
                if (String.IsNullOrEmpty(listaBidimencional[R][C].Movimiento))
                {
                    listaBidimencional[R][C].Movimiento = ultimaDireccion;
                    listaBidimencional[R][C].Arriba = arriba;
                    listaBidimencional[R][C].Abajo = abajo;
                    listaBidimencional[R][C].Izquierda = izquierda;
                    listaBidimencional[R][C].Derecha = derecha;
                }

                #endregion
                switch (ultimaDireccion)
                {
                    case "inicio":
                        Grafico.Rows[0].Cells[0].Value = Recorrido;
                        arriba = false;
                        izquierda = false;
                        break;
                    case "abajo":
                        Grafico.Rows[R - 1].Cells[C].Value = Recorrido;
                        arriba = false;
                        break;
                    case "izquierda":
                        Grafico.Rows[R].Cells[C + 1].Value = Recorrido;
                        derecha = false;
                        break;
                    case "derecha":
                        izquierda = false;
                        Grafico.Rows[R].Cells[C - 1].Value = Recorrido;

                        break;
                    case "arriba":
                        abajo = false;
                        Grafico.Rows[R + 1].Cells[C].Value = Recorrido;
                        break;
                }
                Grafico.Rows[R].Cells[C].Value = (Image.FromFile(Application.StartupPath + @"\img\steve.jpg").GetThumbnailImage(70, 70, null, IntPtr.Zero));
                switch (listaBidimencional[R][C].Movimiento)
                {
                    case "inicio":
                        if (listaBidimencional[R][C].Derecha)
                        {
                            ultimaDireccion = "derecha";
                            listaBidimencional[R][C].Derecha = false;
                            C++;
                        }
                        else if (listaBidimencional[R][C].Abajo)
                        {
                            ultimaDireccion = "abajo";
                            listaBidimencional[R][C].Abajo = false;
                            R++;
                        }
                        else
                        {
                             
                            await Esperar(50);
                            Nucleo.HurtSound(); 
                            died die = new died();
                            die.ShowDialog();
                            C = 9; R = 9;
                        }
                        break;
                    case "derecha":
                        if (listaBidimencional[R][C].Derecha)
                        {
                             ultimaDireccion = "derecha";
                            listaBidimencional[R][C].Derecha = false;

                            C++;
                        }
                        else if (listaBidimencional[R][C].Abajo)
                        {
                            ultimaDireccion = "abajo";
                            listaBidimencional[R][C].Abajo = false;

                            R++;
                        }
                        else if (listaBidimencional[R][C].Arriba)
                        {
                            ultimaDireccion = "arriba";
                            listaBidimencional[R][C].Arriba = false;

                            R--;
                        }
                        else if (listaBidimencional[R][C].Izquierda)
                        {

                            ultimaDireccion = "izquierda";
                            listaBidimencional[R][C].Izquierda = false;

                            C--;
                        }
                        break;
                    case "izquierda":
                        if (listaBidimencional[R][C].Izquierda)
                        {
                            ultimaDireccion = "izquierda";
                            listaBidimencional[R][C].Izquierda = false;

                            C--;
                        }
                        else if (listaBidimencional[R][C].Arriba)
                        {
                            ultimaDireccion = "arriba";
                            listaBidimencional[R][C].Arriba = false;

                            R--;
                        }
                        else if (listaBidimencional[R][C].Abajo)
                        {
                            ultimaDireccion = "abajo";
                            listaBidimencional[R][C].Abajo = false;

                            R++;
                        }

                        else if (listaBidimencional[R][C].Derecha)
                        {
                            ultimaDireccion = "derecha";
                            listaBidimencional[R][C].Derecha = false;

                            C++;
                        }
                        break;
                    case "abajo":

                        if (listaBidimencional[R][C].Derecha)
                        {
                            ultimaDireccion = "derecha";
                            listaBidimencional[R][C].Derecha = false;

                            C++;
                        }
                        else if (listaBidimencional[R][C].Abajo)
                        {
                            ultimaDireccion = "abajo";
                            listaBidimencional[R][C].Abajo = false;

                            R++;
                        }
                        else if (listaBidimencional[R][C].Izquierda)
                        {
                            ultimaDireccion = "izquierda";
                            listaBidimencional[R][C].Izquierda = false;

                            C--;
                        }
                        else if (listaBidimencional[R][C].Arriba)
                        {
                            ultimaDireccion = "arriba";
                            listaBidimencional[R][C].Arriba = false;

                            R--;
                        }
                        break;
                    case "arriba":
                        if (listaBidimencional[R][C].Derecha)
                        {
                            ultimaDireccion = "derecha";
                            listaBidimencional[R][C].Derecha = false;

                            C++;
                        }

                        else if (listaBidimencional[R][C].Izquierda)
                        {
                            ultimaDireccion = "izquierda";
                            listaBidimencional[R][C].Izquierda = false;

                            C--;
                        }
                        else if (listaBidimencional[R][C].Arriba)
                        {
                            ultimaDireccion = "arriba";
                            listaBidimencional[R][C].Arriba = false;
                            R--;
                        }
                        else if (listaBidimencional[R][C].Abajo)
                        {
                            ultimaDireccion = "abajo";
                            listaBidimencional[R][C].Abajo = false;

                            R++;
                        }
                        break;
                }
                /*switch (ultimaDireccion)
                {
                    case "arriba":
                        MessageBox.Show("SE MOVIA HACIA ARRIBA");
                        break;
                    case "derecha":
                        MessageBox.Show("SE MOVIA A LA DERECHA");

                        break;
                    case "izquierda":
                        MessageBox.Show("SE MOVIO A LA IZQUIERDA");

                        break;
                    case "abajo":
                        MessageBox.Show("SE MOVIO HACIA ABAJO");
                        break;

                }*/

                await Esperar(300);


            }
            MessageBox.Show("Juego terminado");

             
                visualizador.Visible = true;
                visualizador.Rows.Clear();
                visualizador.Columns.Clear();
                Grafico.Visible = false;
                Grafico.Rows.Clear();
                Grafico.Columns.Clear();
                IncializarDatos();
                 
                C = 0;
                R = 0;
                ultimaDireccion = "inicio";
            

        }




    }
}
