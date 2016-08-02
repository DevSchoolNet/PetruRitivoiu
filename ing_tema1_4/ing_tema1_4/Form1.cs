using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ing_tema1_4
{
    public partial class Form1 : Form
    {
        //Constructori
        public Form1()
        {
            InitializeComponent();

            //Initializarea stapanului
            DAO.getInstance().stapan = new Stapan();
        }


        //Eventuri
        private void button_addRobot_Click(object sender, EventArgs e)
        {
            Robot temp = null;

            //Instantierea Robotului
            switch(getTipRobot()) {

                case "Zburator":
                    temp = new RobotZburator();
                    break;

                case "Inotator":
                    temp = new RobotInotator();
                    break;

                case "Terestru":
                    temp = new RobotInotator();
                    break;

                case "Subteran":
                    temp = new RobotSubteran();
                    break;

                default:
                    throw new Exception("Eroare la instantierea obiectului de tip Robot");

            }

            //Adaugarea obiectului
            switch (getObiectRobot())
            {
                case "ObiectDeLucru_1":
                    temp.Obiect = new ObiectDeLucru_1();
                    break;

                case "ObiectDeLucru_2":
                    temp.Obiect = new ObiectDeLucru_2();
                    break;

                case "ObiectDeLupta_1":
                    temp.Obiect = new ObiectDeLupta_1();
                    break;

                case "ObiectDeLupta_2":
                    temp.Obiect = new ObiectDeLupta_2();
                    break;

                default:
                    throw new Exception("Eroare la adaugarea obiectului de lucru/lupta robotului");

            }

            temp.Nume = textBox_numeRobot.Text;

            DAO.getInstance().list_robot.Add(temp);
            textBox_console.Text += "A fost creat un obiectul de tip " + temp.GetType().Name + " cu numele " + temp.Nume + Environment.NewLine;
            textBox_console.Text += Environment.NewLine + "---------------------" + Environment.NewLine;

        } // de facut refactor !!
        private void button1_Click(object sender, EventArgs e)
        {
            textBox_console.Text += DAO.getInstance().stapan.pregatitiva();
            textBox_console.Text += Environment.NewLine + "---------------------" + Environment.NewLine;
        }
        private void button_munciti_Click(object sender, EventArgs e)
        {
            textBox_console.Text += DAO.getInstance().stapan.munciti();
            textBox_console.Text += Environment.NewLine + "---------------------" + Environment.NewLine;
        }
        private void button_valea_Click(object sender, EventArgs e)
        {
            textBox_console.Text += DAO.getInstance().stapan.valea();
            textBox_console.Text += Environment.NewLine + "---------------------" + Environment.NewLine;

            DAO.getInstance().list_robot.Clear();
        }
        private void button_deplasare_Click(object sender, EventArgs e)
        {
            Form2 myForm2 = new Form2();
            myForm2.ShowDialog();

            foreach (Robot r in DAO.getInstance().list_robot)
            {
                if (r.Nume.Equals(myForm2.NumeRobot)) // de modificat cu equals ignore case
                {
                    textBox_console.Text += r.deplasare();
                }
            }
        }


        //Utilitare
        private string getTipRobot()
        {
            String tip = null;
                      
            foreach(RadioButton rb in groupBox_robot_tip.Controls)
            {
                if (rb.Checked == true)
                {
                    tip = rb.Text;
                }
            }

            return tip;
        }
        private string getObiectRobot()
        {
            String obiect = null;

            foreach (RadioButton rb in groupBox_robot_obiect.Controls)
            {
                if (rb.Checked == true)
                {
                    obiect = rb.Text;
                }

            }

            return obiect;
        }
    }
}
