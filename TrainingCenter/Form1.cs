using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace TrainingCenter
{

    public partial class Form1 : Form
    {
        Trainee T = new Trainee();
        public Form1()
        {
            InitializeComponent();
            DataBase DB= new DataBase();
            DB.CreateTables();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegisterPanel.Visible = false;
            SigninPanel.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RegisterPanel.Visible = true;
            SigninPanel.Visible = false;
        }


        private void button4_Click(object sender, EventArgs e)
        {
            // Trainee T = new Trainee();
             if(FNametext.Text == "")
                     MessageBox.Show("Enter First Name");
            else if(LNametext.Text == "")
                     MessageBox.Show("Enter Last Name");
            else if(Emailtext.Text == "")
                     MessageBox.Show("Enter Email");
            else if (Phonetext.Text == "")
                     MessageBox.Show("Enter Phone");
            else if(CheckEmailValid(Emailtext.Text)==true && CheckPassword()==true )
            {
                GetRegistrationData();
                T.InsertInTrainee(T);
                MessageBox.Show((T.ID).ToString());
                T.InsertInLogin(T);

                FNametext.Text = "";
                LNametext.Text = "";
                Emailtext.Text = "";
                Phonetext.Text = "";
                Passwordtext.Text = "";
                AgainPasswordtext.Text = "";
                label10.Visible = false;
                label11.Visible = false;
                label12.Visible = false;

                if (MaleradioButton1.Checked)
                    MaleradioButton1.Checked = false;
                
                else
                    FemaleradioButton2.Checked = false;
                
            }
        }

        public void GetRegistrationData()
        {
            T.Firstname = FNametext.Text;
            T.Lastname = LNametext.Text;
            T.Phone = Phonetext.Text;
            T.Username= T.Email;

            if (MaleradioButton1.Checked)
            {
                T.Gender = "M";
            }
            else if (FemaleradioButton2.Checked)
            {
                T.Gender = "F";
            }
        }

        public bool CheckPassword()
        {
            if (Passwordtext.Text == AgainPasswordtext.Text)
            {
                T.password = Passwordtext.Text;
                label10.Visible = false;
                return true;
            }
            else
            {
                label10.Visible = true;
                return false;
            }

        }

        public bool CheckEmailValid(string Email)
        {
           string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";

            if (Regex.IsMatch(Email, pattern))
            {
                label11.Visible = false;
                if (T.CheckEmailExist(Email) == false)
                {
                    T.Email = Email;
                    label12.Visible = false;
                    return true;
                }
                else
                {
                    label12.Visible = true;
                    return false;
                }
            }
            else
            {

                label11.Visible = true;
                label12.Visible = false;
                return false;
            }
        }
    }
}
