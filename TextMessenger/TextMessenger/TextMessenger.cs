using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WhatsAppApi;

namespace TextMessenger
{
    public partial class TextMessenger : Form
    {
        WhatsApp wa;

        public TextMessenger()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            singOutToolStripMenuItem.Visible = false;
            panel1.BringToFront();
            if (Properties.Settings.Default.Remember)
            {
                Phonenumber.Text = Properties.Settings.Default.PhoneNumber;
                password.Text = Properties.Settings.Default.Password;
                remember.Checked = Properties.Settings.Default.Remember;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void remember_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Remember = remember.Checked;
            Properties.Settings.Default.PhoneNumber = Phonenumber.Text;
            Properties.Settings.Default.Password = password.Text;
            Properties.Settings.Default.Save();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void newAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (FirmRegister frm = new FirmRegister()) {
                if (frm.ShowDialog() == DialogResult.OK) {
                    Phonenumber.Text = Properties.Settings.Default.PhoneNumber;
                    password.Text = Properties.Settings.Default.Password;

                }
            }
        }
    }
}
