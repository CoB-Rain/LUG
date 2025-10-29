using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BE
{
    public class JUGADOR
    {
        private int _id;

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        private int _totalPartidasGanadas;

        public int TotalPartidasGanadas
        {
            get { return _totalPartidasGanadas; }
            set { _totalPartidasGanadas = value; }
        }

        private int _totalPartidasEmpatadas;

        public int TotalPartidasEmpatadas
        {
            get { return _totalPartidasEmpatadas; }
            set { _totalPartidasEmpatadas = value; }
        }

        private int _totalPartidasPerdidas;

        public int TotalPartidasPerdidas
        {
            get { return _totalPartidasPerdidas; }
            set { _totalPartidasPerdidas = value; }
        }
    }
}