using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ing_tema1_4
{
    class Robot
    {
        //Fields
        private String nume;
        private Obiect obiect;

        //Constructors
        public Robot()
        {
            this.nume = null;
            this.obiect = null;
        }
        public Robot(string _nume, Obiect _obiect)
        {
            this.nume = _nume;
            this.obiect = _obiect;
        }


        //Properties
        public Obiect Obiect
        {
            get { return this.obiect; }
            set { this.obiect = value; }
        }

        public String Nume
        {
            get { return this.nume; }
            set { this.nume = value; }
        }

        //Methods
        public string deplasare()
        {
            return "Robot de tip " + this.GetType().Name + " cu numele " + this.nume + " ma deplasez" + Environment.NewLine;
        }

        public virtual string valea()
        {
            return "Robot de tip " + this.obiect.GetType().Name + " cu numele " + this.nume + " am plecat " + Environment.NewLine;
        }

        public virtual string munceste()
        {
            return "muncesc folosind un obiect de tip " + this.obiect.GetType().Name + Environment.NewLine;
        }

        public virtual string pregatestete()
        {
            return "Robot de tip " + this.GetType().Name + " cu numele " + this.nume + " am pregatit un obiect de tip " + this.obiect.GetType().Name + Environment.NewLine;
        }
    }
}
