using EMS.login;
using EMS.usercontrol;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMS
{
    public partial class EMS2 : Form
    {
        public EMS2()
        {
            InitializeComponent();
            cdesing();


            pay py = new pay();
            adduserControl(py);

            Upcomings upcomings = new Upcomings();
            adduserControl(upcomings);

            Eventform eventform = new Eventform();
            adduserControl(eventform);

           

            Rform rF = new Rform();
            adduserControl(rF);

            Email email = new Email();
            adduserControl(email);

            backup bk = new backup();
            adduserControl(bk);


           


            Dashboard dF = new Dashboard();
            adduserControl(dF);
        }
       private void adduserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panel3.Controls.Clear();
            panel3.Controls.Add(userControl);
            userControl.BringToFront();
        }
       
        private void guna2Button6_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to Logout", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Form1 EMS = new Form1();
                EMS.Show();
                this.Hide();
            }
            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
           
            Dashboard dF = new Dashboard();
            adduserControl(dF);
           

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {

             Rform rF = new Rform();
            adduserControl(rF);
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
           
        }

        private void guna2Button7_Click_1(object sender, EventArgs e)
        {
            Email email = new Email();
            adduserControl(email);
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            backup bk = new backup();
            adduserControl(bk);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2Button8_Click_1(object sender, EventArgs e)
        {
              
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {
            Eventform eventform = new Eventform();
            adduserControl(eventform);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
           
        }

        private void guna2Button3_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {
           
        }

        private void Upcoming_Click(object sender, EventArgs e)
        {
            Upcomings upcomings = new Upcomings();
            adduserControl(upcomings);
        }

        private void guna2Button2_Click_2(object sender, EventArgs e)
        {
           
        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click_3(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
            this.BackColor = Color.White;
        }
       
        private void lo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void imgSlide_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void EMS2_Load(object sender, EventArgs e)
        {
          //  int w = Screen.PrimaryScreen.Bounds.Width;
            //int h = Screen.PrimaryScreen.Bounds.Height;
            //this.Location = new Point(0, 0);
            //this.Size = new Size(w, h);

          lbUser.Text = userlogin.user;
            
        }

        private void User_Click(object sender, EventArgs e)
        {
            
        }
        private void cdesing()
        {
            
            
        }
        private void hidemenu()
        {
            
        } 
        private void showmenu(Panel panel4)
        {
            if (panel4.Visible == false)
            {
                hidemenu();
                panel4.Visible = true;
            }
            else {
                panel4.Visible = false;
            }

        }

        private void guna2Button2_Click_4(object sender, EventArgs e)
        {
            
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
        }

        private void guna2Button3_Click_2(object sender, EventArgs e)
        {
           
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click_2(object sender, EventArgs e)
        {

            pay py = new pay();
            adduserControl(py);
        }



    }
}
