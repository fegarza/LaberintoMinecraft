using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laberinto
{
    class Cuadro
    {
        

        public Cuadro()
        {
            Pisadas = 0;
            SePuedePasar = false;
            Abajo = false;
            Arriba = false;
            Derecha = false;
            Izquierda = false;
            Movimiento = "";
        }

        private string _strEntroPorMovimiento;

        public string Movimiento
        {
            get { return _strEntroPorMovimiento; }
            set { _strEntroPorMovimiento = value; }
        }


        private bool _boolSePuedePasar;

        public bool SePuedePasar
        {
            get { return _boolSePuedePasar; }
            set { _boolSePuedePasar = value; }
        }
        private int _intPisadas;

        public int Pisadas
        {
            get { return _intPisadas; }
            set { _intPisadas = value; }
        }

        private bool _boolDerecha;

        public bool Derecha
        {
            get { return _boolDerecha; }
            set { _boolDerecha = value; }
        }

        private bool _boolIzquierda;

        public bool Izquierda
        {
            get { return _boolIzquierda; }
            set { _boolIzquierda = value; }
        }
        private bool _boolArriba;

        public bool Arriba
        {
            get { return _boolArriba; }
            set { _boolArriba = value; }
        }
        private bool _boolAbajo;

        public bool Abajo
        {
            get { return _boolAbajo; }
            set { _boolAbajo = value; }
        }



    }
}
