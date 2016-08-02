using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ing_tema1_4
{
    //base class
    public abstract class Obiect
    {
        //Fields
        private string nume;

        //Methods
        public abstract void use();
    }


    //Obiecte de lucru
    public class ObiectDeLucru_1 : Obiect
    {
        public override void use()
        {
            // show in UI "Robot [getCurrentRobot] is using ObiectDeLucru_1"
        }
    }
    public class ObiectDeLucru_2 : Obiect
    {
        public override void use()
        {
            // show in UI "Robot [getCurrentRobot] is using ObiectDeLucru_1"
        }
    }


    //Obiecte de lupta
    public class ObiectDeLupta_1 : Obiect
    {
        public override void use()
        {
            // show in UI "Robot [getCurrentRobot] is using ObiectDeLupta_1"
        }
    }
    public class ObiectDeLupta_2 : Obiect
    {
        public override void use()
        {
            // show in UI "Robot [getCurrentRobot] is using ObiectDeLupta_1"
        }
    }
}
