using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ing_tema1_4
{
    class DAO
    {
        //Object reference
        private static DAO instance;

        //Colectii
        public List<Robot> list_robot;
        public Stapan stapan;

        //Singleton
        private DAO()
        {
            list_robot = new List<Robot>();
        }
        public static DAO getInstance()
        {
            if (instance == null)
            {
                instance = new DAO();
            }

            return instance;
        }
    }
}
