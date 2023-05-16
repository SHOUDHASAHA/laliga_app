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
using System.Data.OleDb;

namespace LoginForm
{
    public partial class Form2 : Form
    {
        private Form1 F1 { get; set; }
        public Form2()
        {
            InitializeComponent();
            this.Da = new DB();
            this.PopulateGridView1();
        }
        private DB Da { get; set; }

        string s;  

        public Form2 (string info) : this()
        {
            //string sql1 = "select* from OwnerTable where = ;" + ' ", '  info ; 
             s = "select * from OwnerTable where username ='" + info + "';";
           // MessageBox.Show(info);
            
           
          
           //this.PopulateGridView(sql1);
           //this.PopulateGridView1();

            InitializeComponent();

        }

        //string sql1 = @"select * from OwnerTable where TeamName =' " + this.textBox2.Text + "';";


        

        
        
        











        private void Form2_Load(object sender, EventArgs e)
        {
            this.PopulateGridView1();
            //this.PopulateGridView(s);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }


        private bool IsDataValidToSave()
        {
            string Serial = this.textBox1.ToString();
            string Team = this.textBox2.ToString();
            string Player= this.textBox3.ToString();
            string Country = this.textBox4.ToString();
            string Age = this.textBox5.ToString();

            if (String.IsNullOrEmpty(this.textBox1.Text) || String.IsNullOrEmpty(this.textBox2.Text) || String.IsNullOrEmpty(this.textBox3.Text) || String.IsNullOrEmpty(this.textBox4.Text) || String.IsNullOrEmpty(this.textBox5.Text))
            {

                return false;

            }

            else
                return true;

        }








        private void button1_Click(object sender, EventArgs e)
        {


            if (!IsDataValidToSave())
            {
                MessageBox.Show(" All Data are not filled . Fill all the Data and click insert");
                return;

            }
            else
            {

                string sql = @"INSERT INTO OwnerTable VALUES ('" + this.textBox1.Text + "', '" + this.textBox2.Text.ToString() + "', '" + this.textBox3.Text.ToString() + "', '" + this.textBox4.Text.ToString() + "', '" + this.textBox5.Text + "')";
                this.Da.ExecuteQuery(sql);

                string sql1 = @"select * from OwnerTable where TeamName =' " + this.textBox2.Text + "';";
                this.Da.ExecuteQuery(sql1);



                MessageBox.Show("Insertion successful");
               // PopulateGridView();


                textBox5.Text = null;
                textBox4.Text = null;
                textBox1.Text = null;
                //textBox2.Text = null;
                textBox3.Text = null;
            }

        }

        private void PopulateGridView(string sql)
        {
            var ds = this.Da.ExecuteQuery(sql);
            MessageBox.Show(sql);

         //  this.dataGridView1.AutoGenerateColumns = true;
            this.dataGridView1.DataSource = ds.Tables[0];
        }

        private void PopulateGridView1(string sql = "select * from OwnerTable ")
        {
            var ds = this.Da.ExecuteQuery(sql);

            this.dataGridView1.AutoGenerateColumns = true;
            this.dataGridView1.DataSource = ds.Tables[0];
        }




        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void NoOfPlayertext_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //this.PopulateGridView();
            this.PopulateGridView(s);


        }

        private void textBox5_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Show Button
            this.PopulateGridView1();

        
        }


         private void Deletebutton_Click(object sender, EventArgs e)
        {
            try
            {

               var id = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
                MessageBox.Show(id + " Deleted");
                // var sql = "Delete from OwnerTable where PlayerName = ' " + id "' ; "; 
                var sql = "DELETE FROM OwnerTable WHERE PlayerName = '" + id + "'; ";
                Da.ExecuteQuery(sql);


                MessageBox.Show(id + " Deleted");
               // PopulateGridView();

            }
             catch
            {
                MessageBox.Show("An error has occured"); 
            }


        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {


  
        }

       

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
