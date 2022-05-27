using log4net;
using log4net.Config;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicatie
{
    public partial class Form1 : Form
    {   
        LOGIN model = new LOGIN();
        FileStream fs = new FileStream("../../loGGing.xml", FileMode.Open);
        private protected ILog logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Form1()
        {
            InitializeComponent();
            XmlConfigurator.Configure(fs);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            //LOGIN login = new LOGIN();
            using (DBApp1Entities db = new DBApp1Entities())
            { 
                var dataset = db.LOGINs.Where(x => x.username == txtusername.Text && x.password == txtpassword.Text).Select(x => new { x.username, x.password }).FirstOrDefault();
                if (dataset != null)
                {
                    PilotForm mf = new PilotForm();
                    mf.Show();
                    this.Hide();
                    logger.Info("Bravo! Inca mai stii parola :))");

                }
                else
                {
                    Singleton s = Singleton.Instance;
                    s.Print("Wrong Username or Password!");
                    // MessageBox.Show("Wrong Username or Password!");
                    logger.Warn("Opaa! Da' ce am facut sefu' ?!");
                    logger.Error("Ai gresit parola sau/si usernameul!!! Noteaza daca nu tii minte!!!");
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
