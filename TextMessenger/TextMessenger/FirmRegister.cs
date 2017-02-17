using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextMessenger
{
    public partial class FirmRegister : Form
    {
        string password;
        public FirmRegister()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void request_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(phoneNumber.Text)) {
                MessageBox.Show("Please Enter the Phone Number.","Message", MessageBoxButtons.OK,MessageBoxIcon.Information);
                phoneNumber.Focus();
                return;
            }
            if (string.IsNullOrEmpty(name.Text)) {
                MessageBox.Show("Please Enter your Fukk Name.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                name.Focus();
                return;
            }
            if (WhatsAppApi.Register.WhatsRegisterV2.RequestCode(phoneNumber.Text,out password, "sms")) {

            }
        }
        private void save() {
            this.grbRequestCode.Enabled = false;
            this.grbConfirmCode.Enabled = false;
            Properties.Settings.Default.PhoneNumber = phoneNumber.Text;
            Properties.Settings.Default.Password = password;
            Properties.Settings.Default.FullName = name.Text;
            Properties.Settings.Default.Save();
           // if (Globals.DB.Account.FindByAccountId(phoneNumber.Text) == null) {
                AppData.AccountRow row = Globals.DB.Account.NewAccountRow();
                row.AccountId = phoneNumber.Text;
                row.FullName = name.Text;
                row.password = password;
                Globals.DB.Account.AddAccountRow(row);
                Globals.DB.Account.AcceptChanges();
                Globals.DB.Account.WriteXml(string.Format("{0}\\accounts.dat", Application.StartupPath));
            //  }
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }


        private void confirm_Click(object sender, EventArgs e)
        {

        }
    }
}
