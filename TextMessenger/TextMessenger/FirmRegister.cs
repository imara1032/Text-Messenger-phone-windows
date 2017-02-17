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
        }


        private void confirm_Click(object sender, EventArgs e)
        {

        }
    }
}
