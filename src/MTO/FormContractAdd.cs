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
    public partial class FormContractAdd : Form
    {
        private Contract currContract = null;

        private const string formHeaderText = "Редактирование договора";
        private const string btnAddText = "Изменить";

        public FormContractAdd(Contract contract = null)
        {
            InitializeComponent();

            List<Provider> providers = Program.db.Providers.ToList();
            cb_provider.DataSource = providers;

            if (contract != null)
            {
                this.currContract = contract;
                this.Text = formHeaderText;
                btn_AddNClose.Text = btnAddText;
                btn_add.Visible = false;

                fillDataFromSource();
            }
        }

        private void fillDataFromSource()
        {
            tb_actNumber.Text = currContract.ContractNumber;
            tb_conclusionCity.Text = currContract.ConclusionCity;

            tb_customerAgentName.Text = currContract.CustomerAgentName;
            tb_customerAgentRole.Text = currContract.CustomerAgentRole;

            tb_providerAgentName.Text = currContract.ProviderAgentName;
            tb_providerAgentRole.Text = currContract.ProviderAgentRole;

            dtp_conclusionDate.Value = currContract.ConclusionDate;
            dtp_startDate.Value = currContract.StartDate;
            dtp_expiredDate.Value = currContract.ExpiredDate;

            nud_customerPenalty.Value = currContract.CustomerPenalty;
            nud_supplierPenalty.Value = currContract.SupplierPenalty;

            cb_provider.Text = currContract.Provider.Name;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_cancelAdd_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private bool validateInput()
        {
            if(tb_actNumber.Text == String.Empty)
            {
                MessageBox.Show("Пустой номер договора!");
                return false;
            }
            else if (tb_conclusionCity.Text == String.Empty)
            {
                MessageBox.Show("Пустое место заключения!");
                return false;
            }
            else if (cb_provider.Text == String.Empty)
            {
                MessageBox.Show("Пустой поставщик!");
                return false;
            }
            else if (dtp_startDate.Value > dtp_expiredDate.Value)
            {
                MessageBox.Show("Ошибка в датах договора");
                return false;
            }
            else
                return true;
        }
        //сохранение контракта в БД
        private bool saveModel()
        {
            if (validateInput())
            {
                if (currContract != null)
                {
                    currContract.ContractNumber = tb_actNumber.Text;
                    currContract.ConclusionCity = tb_conclusionCity.Text;

                    currContract.CustomerAgentName = tb_customerAgentName.Text;
                    currContract.CustomerAgentRole = tb_customerAgentRole.Text;
                    currContract.ProviderAgentName = tb_providerAgentName.Text;
                    currContract.ProviderAgentRole = tb_providerAgentRole.Text;

                    currContract.PK_Provider = ((Provider)cb_provider.SelectedItem).PK_Provider;

                    currContract.ConclusionDate = dtp_conclusionDate.Value;
                    currContract.ExpiredDate = dtp_expiredDate.Value;
                    currContract.StartDate = dtp_startDate.Value;

                    currContract.SupplierPenalty = nud_supplierPenalty.Value;
                    currContract.CustomerPenalty = nud_customerPenalty.Value;


                    Program.db.Contracts.Update(currContract);


                    //refresh contract lines
                }
                else
                {
                    Contract newContract = new Contract()
                    {
                        ContractNumber = tb_actNumber.Text,
                        ConclusionCity = tb_conclusionCity.Text,

                        ConclusionDate = dtp_conclusionDate.Value,
                        StartDate = dtp_startDate.Value,
                        ExpiredDate = dtp_expiredDate.Value,

                        ProviderAgentName = tb_providerAgentName.Text,
                        ProviderAgentRole = tb_providerAgentRole.Text,
                        CustomerAgentName = tb_customerAgentName.Text,
                        CustomerAgentRole = tb_customerAgentRole.Text,

                        SupplierPenalty = nud_supplierPenalty.Value,
                        CustomerPenalty = nud_customerPenalty.Value,

                        PK_Provider = ((Provider)cb_provider.SelectedItem).PK_Provider,
                        PK_OrganizationDescription = Program.db.OrganizationDescriptions.FirstOrDefault().PK_OrganizationDescription
                    };

                    Program.db.Contracts.Add(newContract);

                    //add contractLines
                }

                Program.db.SaveChanges();
                return true;
            }
            else
                return false;
        }

        //очистка данных в полях ввода
        private void clearData()
        {
            tb_actNumber.Clear();
            tb_conclusionCity.Clear();

            tb_customerAgentName.Clear();
            tb_customerAgentRole.Clear();
            tb_providerAgentName.Clear();
            tb_providerAgentRole.Clear();

            dtp_conclusionDate.Value = DateTime.Now;
            dtp_startDate.Value = DateTime.Now;
            dtp_expiredDate.Value = DateTime.Now;

            cb_provider.SelectedIndex = -1;

            nud_customerPenalty.Value = 0;
            nud_supplierPenalty.Value = 0;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (saveModel())
            {
                if(currContract == null)
                    MessageBox.Show("Успешно добавлен!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Успешно изменена!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearData();
            }
        }

        private void btn_AddNClose_Click(object sender, EventArgs e)
        {
            if (saveModel())
            {
                if (currContract == null)
                    MessageBox.Show("Успешно добавлен!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Успешно изменена!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
        }
    }
}
