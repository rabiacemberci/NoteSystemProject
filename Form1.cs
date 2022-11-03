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

namespace NoteSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int grade;
        SqlConnection connect = new SqlConnection("Data Source=LAPTOP-EVPST4M6;Initial Catalog=oop2project;Integrated Security=True");

        void clear()
        {
            coursename.Text = "";
            coursegrade.Text = "";
            ectscredits.Text = "";
            coursecode.Text = "";
            terminformation.Text = "";
            searchname.Text = "";
            searchterm.Text = "";
            lettergrade.Text = "";
            coursename.Focus();

        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

            this.courseInformationTableAdapter.Fill(this.oop2projectDataSet.CourseInformation);
        }

        private void View_Click(object sender, EventArgs e)
        {
            connect.Open();
            string view = "Select * from CourseInformation";
            SqlCommand command = new SqlCommand(view, connect);
            SqlDataAdapter name = new SqlDataAdapter(command);

            DataTable dt = new DataTable();
            name.Fill(dt);
            dataGridView1.DataSource = dt;

            connect.Close();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand command = new SqlCommand("Insert into CourseInformation " +
                "(CourseName,CourseGrade,ECTSCredits,CourseCode,TermInformation," +
                "LetterGrade) values (@p1,@p2,@p3,@p4,@p5,@p6)", connect);
            command.Parameters.AddWithValue("@p1", coursename.Text);
            command.Parameters.AddWithValue("@p2", coursegrade.Text);
            command.Parameters.AddWithValue("@p3", ectscredits.Text);
            command.Parameters.AddWithValue("@p4", coursecode.Text);
            command.Parameters.AddWithValue("@p5", terminformation.Text);
            command.Parameters.AddWithValue("@p6", lettergrade.Text);
            command.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("Course Registered!!");

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selection = dataGridView1.SelectedCells[0].RowIndex;
            coursename.Text = dataGridView1.Rows[selection].Cells[1].Value.ToString();
            coursegrade.Text = dataGridView1.Rows[selection].Cells[5].Value.ToString();
            ectscredits.Text = dataGridView1.Rows[selection].Cells[2].Value.ToString();
            coursecode.Text = dataGridView1.Rows[selection].Cells[0].Value.ToString();
            terminformation.Text = dataGridView1.Rows[selection].Cells[3].Value.ToString();
            lettergrade.Text = dataGridView1.Rows[selection].Cells[4].Value.ToString();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand delete = new SqlCommand("Delete from CourseInformation where CourseName=@p1",connect);
            delete.Parameters.AddWithValue("@p1", coursename.Text);
            delete.ExecuteNonQuery();
            MessageBox.Show("Register Deleted!!");
            connect.Close();

        }

        private void update_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand update = new SqlCommand("Update CourseInformation Set CourseCode" +
                " =@p1,TermInformation=@p2,ECTSCredits=@p3,CourseGrade=@p4,LetterGrade=@p6 " +
                "where CourseName=@p5",connect);
            update.Parameters.AddWithValue("p1", coursecode.Text);
            update.Parameters.AddWithValue("p2", terminformation.Text);
            update.Parameters.AddWithValue("p3", ectscredits.Text);
            update.Parameters.AddWithValue("p4", coursegrade.Text);
            update.Parameters.AddWithValue("p6", lettergrade.Text);
            update.Parameters.AddWithValue("p5", coursename.Text);

            update.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("Course Updated!!");
        }

        private void allclear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void add_Click(object sender, EventArgs e)
        {
            
            SqlCommand add = new SqlCommand("Insert into CourseInformation (CourseName,CourseGrade,ECTSCredits,CourseCode,TermInformation,LetterGrade) values (@p1,@p2,@p3,@p4,@p5,@p6)", connect);
            add.Parameters.AddWithValue("@p1", coursename.Text);
            add.Parameters.AddWithValue("@p2", coursegrade.Text);
            add.Parameters.AddWithValue("@p3", ectscredits.Text);
            add.Parameters.AddWithValue("@p4", coursecode.Text);
            add.Parameters.AddWithValue("@p5", terminformation.Text);
            add.Parameters.AddWithValue("@p6", lettergrade.Text);
            connect.Open();
            add.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("Course Added!!");
        }

        private void insert_Click(object sender, EventArgs e)
        {
            
            SqlCommand command = new SqlCommand("Insert into CourseInformation (CourseName,CourseGrade" +
                ",ECTSCredits,CourseCode,TermInformation,LetterGrade) values (@p1,@p2,@p3,@p4,@p5,@p6)", connect);
            command.Parameters.AddWithValue("@p1", coursename.Text);
            command.Parameters.AddWithValue("@p2", coursegrade.Text);
            command.Parameters.AddWithValue("@p3", ectscredits.Text);
            command.Parameters.AddWithValue("@p4", coursecode.Text);
            command.Parameters.AddWithValue("@p5", terminformation.Text);
            command.Parameters.AddWithValue("@p6", lettergrade.Text);

            try
            {
                connect.Open();
                int validateOperation = command.ExecuteNonQuery();
                if (validateOperation > 0)
                {
                    MessageBox.Show("Course Inserted!!");
                }
                else
                {
                    MessageBox.Show("ERROR!!");
                }
            }
            catch (SqlException )
            {
                //Exception
            }
            finally
            {
                connect.Close();
            }
        }
        private void searchtext_TextChanged(object sender, EventArgs e)
        {
            connect.Open();
            DataTable tbl = new DataTable();
            SqlDataAdapter search = new SqlDataAdapter("Select * from CourseInformation where TermInformation like '%" +searchterm.Text+ "%' ", connect);
            search.Fill(tbl);
            connect.Close();
            dataGridView1.DataSource = tbl;
        }

        private void searchgrade_TextChanged(object sender, EventArgs e)
        {
            connect.Open();
            DataTable tbl = new DataTable();
            SqlDataAdapter search = new SqlDataAdapter("Select * from CourseInformation where CourseName like '%" + searchname.Text + "%' ", connect);
            search.Fill(tbl);
            connect.Close();
            dataGridView1.DataSource = tbl;
        }

        private void gpabutton_Click(object sender, EventArgs e)
        {
            int m1, m2, m3, m4, m5, m6, m7, m8;
            int u1, u2, u3, u4, u5, u6, u7, u8;
            m1 = int.Parse(txts1.Text);
            m2 = int.Parse(txts2.Text);
            m3 = int.Parse(txts3.Text);
            m4 = int.Parse(txts4.Text);
            m5 = int.Parse(txts5.Text);
            m6 = int.Parse(txts6.Text);
            m7 = int.Parse(txts7.Text);
            m8 = int.Parse(txts8.Text);

            u1 = int.Parse(txtu1.Text);
            u2 = int.Parse(txtu2.Text);
            u3 = int.Parse(txtu3.Text);
            u4 = int.Parse(txtu4.Text);
            u5 = int.Parse(txtu5.Text);
            u6 = int.Parse(txtu6.Text);
            u7 = int.Parse(txtu7.Text);
            u8 = int.Parse(txtu8.Text);

            int cgp = point(m1) * u1 + point(m2) * u2 + point(m3) * u3 + point(m4) * u4 + point(m5) * u5 + point(m6) * u6 + point(m7) * u7 + point(m8) * u8;
            int tu = u1 + u2 + u3 + u4 + u5 + u6+ u7 + u8;
            int ggpa = cgp / tu;
            lg1.Text = Grade(m1);
            lg2.Text = Grade(m2);
            lg3.Text = Grade(m3);
            lg4.Text = Grade(m4);
            lg5.Text = Grade(m5);
            lg6.Text = Grade(m6);
            lg7.Text = Grade(m7);
            lg8.Text = Grade(m8);
            lp1.Text = Convert.ToString(point(m1));
            lp2.Text = Convert.ToString(point(m2));
            lp3.Text = Convert.ToString(point(m3));
            lp4.Text = Convert.ToString(point(m4));
            lp5.Text = Convert.ToString(point(m5));
            lp6.Text = Convert.ToString(point(m6));
            lp7.Text = Convert.ToString(point(m7));
            lp8.Text = Convert.ToString(point(m8));
            lgpa.Text = Convert.ToString(tu);
            logp.Text = Convert.ToString(ggpa);


        }
        int point(int mark)
        {
            int p = 0;
            if (mark < 30)
            {
                p = 0;
            }
            else if (mark >= 30 && mark < 49)
            {
                p = 1;
            }
            else if (mark >= 50 && mark < 69)
            {
                p = 2;
            }
            else if (mark >= 70 && mark < 89)
            {
                p = 3;
            }
            else if (mark >= 90 && mark <= 100)
            {
                p = 4;
            }
            return p;
        }
        String Grade(int mark)
        {
            String p = "";
            if(mark < 30)
            {
                p = "FF";
            }
            else if (mark >= 30 && mark < 39)
            {
                p = "FD";
            }
            else if (mark >= 40 && mark < 49)
            {
                p = "DD";
            }
            else if (mark >= 50 && mark < 59)
            {
                p = "DC";
            }
            else if (mark >= 60 && mark < 69)
            {
                p = "CC";
            }
            else if (mark >= 70 && mark < 74)
            {
                p = "CB";
            }
            else if (mark >= 75 && mark < 79)
            {
                p = "BB";
            }
            else if (mark >= 80 && mark < 89)
            {
                p = "BA";
            }
            else if (mark >= 90 && mark <= 100)
            {
                p = "AA";
            }
            return p;
        }

        private void lettergradebutton_Click(object sender, EventArgs e)
        {
            grade = int.Parse(coursegrade.Text);
            if (grade < 30)
            {
                lettergrade.Text = "FF";
            }
            else if (grade >= 30 && grade < 39)
            {
                lettergrade.Text = "FD";
            }
            else if (grade >= 40 && grade < 49)
            {
                lettergrade.Text = "DD";
            }
            else if (grade >= 50 && grade < 59)
            {
                lettergrade.Text = "DC";
            }
            else if (grade >= 60 && grade < 69)
            {
                lettergrade.Text = "CC";
            }
            else if (grade >= 70 && grade < 74)
            {
                lettergrade.Text = "CB";
            }
            else if (grade >= 75 && grade < 79)
            {
                lettergrade.Text = "BB";
            }
            else if (grade >= 80 && grade < 89)
            {
                lettergrade.Text = "BA";
            }
            else if (grade >= 90 && grade <= 100)
            {
                lettergrade.Text = "AA";
            }
            

        }
    }
}
