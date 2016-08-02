using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ing_tema1_4
{
    class Stapan : IMeserieDeStapan
    {
        public string munciti()
        {
            String rezultatMunciti = null;

            foreach(Robot r in DAO.getInstance().list_robot)
            {
                rezultatMunciti += r.munceste();
            }

            return rezultatMunciti;
        }

        public string pregatitiva()
        {
            String rezultatPregatire = null;

            foreach(Robot r in DAO.getInstance().list_robot)
            {
               rezultatPregatire += r.pregatestete();
            }

            return rezultatPregatire;
        }

        public string valea()
        {
            String rezultatValea = null;

            foreach (Robot r in DAO.getInstance().list_robot)
            {
                rezultatValea += r.valea();
            }

            return rezultatValea;
        }
    }
}
