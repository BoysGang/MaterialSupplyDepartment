using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MTO.Models;

namespace MTO
{
    public partial class FormLogin : Form
    {
        private FormContracts formContracts;

        public FormLogin()
        {
            InitializeComponent();


            var Contractlines = Program.db.Contractlines.Find(1);
            
            //MessageBox.Show(Contractlines.Count.ToString());
            MessageBox.Show(Contractlines.Contract.ConclusionCity + " " + Contractlines.Contract.ContractNumber.ToString());
            //Unit unit = new Unit() { Name = "Zhenya", Cipher = "3333" };

            //Program.db.Add(unit);
            //Program.db.SaveChanges();

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            this.Hide();
            
            formContracts = new FormContracts();
            formContracts.Closed += (s, args) => this.Close();

            formContracts.Show();
        }
    }
}
