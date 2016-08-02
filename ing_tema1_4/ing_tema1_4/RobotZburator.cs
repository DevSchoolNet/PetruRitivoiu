using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ing_tema1_4
{
    class RobotZburator : Robot
    {
        //Constructors
        public RobotZburator() : base () { }
        public RobotZburator(String _nume, Obiect _obiect) : base(_nume, _obiect) { }
        public override string munceste()
        {
            return "Robot de tip " + this.GetType().Name + " cu numele " + this.Nume + " " + base.munceste();
        }
    }
}
