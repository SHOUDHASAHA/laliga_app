using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LoginForm
{           
    
    public partial class Form1 : Form
    {

        private DB Da { get; set; }

        public Form1()
        {
            InitializeComponent();
            this.Da = new DB();
        }


         

        

        private void label2_Click(object sender, EventArgs e)
        {

           
        }

        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                string Qury = "select* from login_table where username ='" + this.textBox1.Text + "' and password='" + this.textBox2.Text + "';";

                var ds = this.Da.ExecuteQuery(Qury);

                if (ds.Tables[0].Rows.Count >= 1)
                {

                    MessageBox.Show("Login Successfull");

                    var Owner = this.textBox1.Text;

                    //Form2 f2 = new Form2();
                    Form2 f2 = new Form2(Owner);
                    this.Visible = false;
                    MessageBox.Show("Form 2 loading");
                    f2.Visible = true;





                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("Invalid Info");
                    return;
                }


            }
            finally { 
            
            }



            }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
