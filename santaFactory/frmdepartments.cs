using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace santaFactory
{
    public partial class frmdepartments : Form
    {
        public string selectedId = "";
        public frmdepartments()
        {
            InitializeComponent();
        }
        //function to retrieve data from "departments"
        private void populateListView()
        {
            try
            {
                using (MySqlConnection xyz = new MySqlConnection(helpers.connectionstring))
                {
                    xyz.Open(); //opened the connection to mysql
                    string sql = "SELECT * FROM department";
                    MySqlCommand cmd = new MySqlCommand(sql, xyz);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    lstDepartments.Items.Clear();
                    while (reader.Read())
                    {
                        lstDepartments.Items.Add(reader["id"].ToString());
                        //count at this point is 1. first row. first loop.
                        //
                        lstDepartments.Items[lstDepartments.Items.Count-1].SubItems.Add(reader["name"].ToString());
                        //MessageBox.Show(reader["name"].ToString());

                    }
                    
                }
            }
            catch (Exception abc)
            {

                //throw error = messagebox
                MessageBox.Show(abc.Message.ToString());
            }
        }

      

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            //check the text name if it has some values.
            if (textBox1.Text != string.Empty)
            {
                //if values are present, insert to ddatabase
                try
                {
                    //purpose of using= garbage collection
                    using (MySqlConnection xyz = new MySqlConnection(helpers.connectionstring))
                    {
                        xyz.Open();
                        string sql = "INSERT INTO department(name) VALUES(@name)"; //parameterized query is the one with @
                        MySqlCommand cmd = new MySqlCommand(sql, xyz);
                        cmd.Parameters.AddWithValue("name", textBox1.Text); //TEXTBOX1.TEXT WILL BE INTERCHANGED @NAME
                        cmd.ExecuteNonQuery(); 
                    }
                }                
                catch (Exception ex)
                {
                    
                    MessageBox.Show(ex.Message.ToString());
                }

                //refresh listview to show new added item
                populateListView();

            }
            else
            {
                MessageBox.Show("Department name must have a value.");
            }
            
     

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                //purpose of using= garbage collection
                using (MySqlConnection xyz = new MySqlConnection(helpers.connectionstring))
                {
                    xyz.Open();
                    string sql = "DELETE FROM department WHERE id = @id"; //parameterized query is the one with @
                    MySqlCommand cmd = new MySqlCommand(sql, xyz);
                    cmd.Parameters.AddWithValue("id",lstDepartments.SelectedItems[0].Text); //TEXTBOX1.TEXT WILL BE INTERCHANGED @NAME
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }

            //refresh listview to show new added item
            populateListView();
        }

        private void frmdepartments_Load(object sender, EventArgs e)
        {
            populateListView();
        }

        private void lstDepartments_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstDepartments_Click(object sender, EventArgs e) //from events double clicked
        {
            textBox1.Text = lstDepartments.SelectedItems[0].SubItems[1].Text;
            //purpose of selectid: reference for editing 
            selectedId = lstDepartments.SelectedItems[0].Text;
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                //purpose of using= garbage collection
                using (MySqlConnection xyz = new MySqlConnection(helpers.connectionstring))
                {
                    xyz.Open();
                    //@id is 'hidden'
                    string sql = "UPDATE department SET name = @name WHERE id = @id"; //parameterized query is the one with @
                    MySqlCommand cmd = new MySqlCommand(sql, xyz);
                    cmd.Parameters.AddWithValue("name", textBox1.Text);
                    cmd.Parameters.AddWithValue("id", selectedId);//TEXTBOX1.TEXT WILL BE INTERCHANGED @NAME
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }

            //refresh listview to show new added item
            populateListView();
        }
    }
}
