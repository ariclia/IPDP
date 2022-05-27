using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicatie
{
    public partial class AirportForm : Form
    {
        Airport model = new Airport();
        public AirportForm()
        {
            InitializeComponent();
        }

        void Clear()
        {
            txtName.Text = txtLocality.Text = txtAdress.Text = txtType.Text = "";
            btnAdd.Text = "ADD";
            model.IDAirport = 0; 

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Hide();
            PilotForm Pilot = new PilotForm();
            Pilot.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();
            AirportForm Airport = new AirportForm();
            Airport.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            FlightForm Flight = new FlightForm();
            Flight.Show();
        }

        private void AirportForm_Load(object sender, EventArgs e)
        {
            Clear();
            PopulateDataGridView();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            model.Name = txtName.Text.Trim();
            model.Locality = txtLocality.Text.Trim();
            model.Adress = txtAdress.Text.Trim();
            model.Type = txtType.Text.Trim();
            using (DBApp1Entities db = new DBApp1Entities())
            { 
                db.Airports.Add(model);
                db.SaveChanges();
            }
            Clear();
            PopulateDataGridView();
            MessageBox.Show("Submitted Successfully");
        }

        void PopulateDataGridView()
        {
            dgvAirports.AutoGenerateColumns = false;
            using (DBApp1Entities db = new DBApp1Entities())
            { dgvAirports.DataSource = db.Airports.ToList<Airport>(); }
           
        }

        private void txtName_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void dgvAirports_DoubleClick(object sender, EventArgs e)
        {
            if (dgvAirports.CurrentRow.Index != -1)
            {
                model.IDAirport = Convert.ToInt32(dgvAirports.CurrentRow.Cells["IDAirport"].Value);
                using (DBApp1Entities db = new DBApp1Entities())
                {
                    model = db.Airports.Where(x => x.IDAirport == model.IDAirport).FirstOrDefault();
                    txtName.Text = model.Name;
                    txtLocality.Text = model.Locality;
                    txtAdress.Text = model.Adress;
                    txtType.Text = model.Type;
                }
                btnAdd.Text = "ADD";
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            model.Name = txtName.Text.Trim();
            model.Locality = txtLocality.Text.Trim();
            model.Adress = txtAdress.Text.Trim();
            model.Type = txtType.Text.Trim();
            using (DBApp1Entities db = new DBApp1Entities())
            {
                db.Entry(model).State = EntityState.Modified;
                db.SaveChanges();
            }
            Clear();
            MessageBox.Show("Client Successfully Updated");
            PopulateDataGridView();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to delete this record?", "EF CRUD Operation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (DBApp1Entities db = new DBApp1Entities())
                {
                    var entry = db.Entry(model);
                    if (entry.State == EntityState.Detached)
                        db.Airports.Attach(model);
                    db.Airports.Remove(model);
                    db.SaveChanges();
                    PopulateDataGridView();
                    Clear();
                    MessageBox.Show("Deleted Successfully");

                }
            }
        }
    }
}
