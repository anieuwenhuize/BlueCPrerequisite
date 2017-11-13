using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Camper
    {
        private int AantalRamen;
        private int AantalDeuren;
        private bool Antenne;

        public Camper( bool heeftAntenne )
        {
            this.AantalRamen = 4;
            this.AantalDeuren = 3;
            this.Antenne = heeftAntenne;
        }

        public bool HeeftAntenne()
        {
            return this.Antenne;
        }

        public int GeefAantalRamen()
        {
            return this.AantalRamen;
        }
        public void VoegEenRaamToe(int aantal)
        {

        }

        public void VoegEenRaamToe()
        {
            this.AantalRamen += 1;
            //this.AantalRamen = this.AantalRamen + 1;
        }
    }
}
