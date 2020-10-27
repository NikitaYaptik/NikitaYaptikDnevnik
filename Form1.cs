using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dnevnichochek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-DM1D35B\SQLEXPRESS;Initial Catalog=Dnevnik;Integrated Security=True");
        public int StudentID;


        private void Form1_Load(object sender, EventArgs e)
        {
            GetStudentsRecord();
        }

        private void GetStudentsRecord()
        {
            
            SqlCommand cmd = new SqlCommand("Select * from StudentsTb", con);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            StudentRecordDataGridView.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO StudentsTb VALUES(@name,@FatherName,@RollNumber,@Adress,@Mobile,@zadanie,@osenka)",con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@name", txtStudentName.Text);
                cmd.Parameters.AddWithValue("@FatherName", txtFatherName1.Text);
                cmd.Parameters.AddWithValue("@RollNumber", txtRollNumber1.Text);
                cmd.Parameters.AddWithValue("@Adress", txtAddress1.Text);
                cmd.Parameters.AddWithValue("@Mobile", txtMobile1.Text);
                cmd.Parameters.AddWithValue("@zadanie", txtZadanie.Text);
                cmd.Parameters.AddWithValue("@osenka", txtOsenka.Text);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("New student successfully saved database", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetStudentsRecord();
                ResetFormControls();
            }
        }

        private bool IsValid()
        {
            if(txtStudentName.Text== string.Empty)
            {
                MessageBox.Show("Student name is required", "Failed:503", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ResetFormControls();

        }

        private void ResetFormControls()
        {
            StudentID = 0;
            txtStudentName.Clear();
            txtFatherName1.Clear();
            txtRollNumber1.Clear();
            txtAddress1.Clear();
            txtMobile1.Clear();
            txtStudentName.Focus();
        }

        private void StudentRecordDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            StudentID = Convert.ToInt32(StudentRecordDataGridView.Rows[0].Cells[0].Value);
            txtStudentName.Text = StudentRecordDataGridView.SelectedRows[0].Cells[1].Value.ToString();
            txtFatherName1.Text = StudentRecordDataGridView.SelectedRows[0].Cells[2].Value.ToString();
            txtRollNumber1.Text = StudentRecordDataGridView.SelectedRows[0].Cells[3].Value.ToString();
            txtAddress1.Text = StudentRecordDataGridView.SelectedRows[0].Cells[4].Value.ToString();
            txtMobile1.Text = StudentRecordDataGridView.SelectedRows[0].Cells[5].Value.ToString();
            txtZadanie.Text = StudentRecordDataGridView.SelectedRows[0].Cells[6].Value.ToString();
            txtOsenka.Text = StudentRecordDataGridView.SelectedRows[0].Cells[7].Value.ToString();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (StudentID > 0)
            {
                SqlCommand cmd = new SqlCommand("UPDATE StudentsTb SET Name = @name,FatherName=@FatherName,RollNumber=@RollNumber,Address=@Address,Mobile=@Mobile,zadanie=@zadanie,osenka=@osenka WHERE StudentID = @ID", con);

                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@name", txtStudentName.Text);
                cmd.Parameters.AddWithValue("@FatherName", txtFatherName1.Text);
                cmd.Parameters.AddWithValue("@RollNumber", txtRollNumber1.Text);
                cmd.Parameters.AddWithValue("@Address", txtAddress1.Text);
                cmd.Parameters.AddWithValue("@Mobile", txtMobile1.Text);
                cmd.Parameters.AddWithValue("@zadanie", txtZadanie.Text);
                cmd.Parameters.AddWithValue("@osenka", txtOsenka.Text);
                cmd.Parameters.AddWithValue("@ID", this.StudentID);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Student Information successfully saved database", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
                GetStudentsRecord();
                ResetFormControls();
            }
            else
            {
                MessageBox.Show("Please Select an student update", "Select?", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (StudentID > 0)
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM StudentsTb WHERE StudentID = @ID", con);

                cmd.CommandType = CommandType.Text;
               
                cmd.Parameters.AddWithValue("@ID", this.StudentID);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Student Deleted", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetStudentsRecord();
                ResetFormControls();
            }
            else
            {
                MessageBox.Show("Please Select an student delete", "Select?", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
