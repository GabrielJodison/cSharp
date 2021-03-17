using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace FourHorizon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int waparam, int lparan);
     

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void txtUser_Enter(object sender, EventArgs e)
        {
            if (txtUser_Name.Text == "USER"){
                txtUser_Name.Text = "";
                txtUser_Name.ForeColor = Color.Black;
            }
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (txtUser_Name.Text == ""){
                txtUser_Name.Text = "USER";
                txtUser_Name.ForeColor = Color.Black;
            }
        }
        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword_Name.Text == "PASSWORD"){
                txtPassword_Name.Text = "";
                txtPassword_Name.ForeColor = Color.Black;
                txtPassword_Name.UseSystemPasswordChar = true;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword_Name.Text == ""){
                txtPassword_Name.Text = "PASSWORD";
                txtPassword_Name.ForeColor = Color.Black;
                txtPassword_Name.UseSystemPasswordChar = false;

            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }

}
