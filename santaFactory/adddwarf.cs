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
    public partial class adddwarf : Form
    {
        public int id { get; set; }
        public string name { get; set; }
        public string age { get; set; }
        public string color {get; set;}
        public string department { get; set; }

        private string _action = "add";

        public adddwarf(string action)
        {
            InitializeComponent();
            this._action = action;

        }

        public void populateCombocBoxWDepartments()
        {
            try
            {
                using (MySqlConnection xyz = new MySqlConnection(helpers.connectionstring)) //garbage collection
                {
                    xyz.Open();
                    string sql = " SELECT * FROM department"; //selected all the columns from department table
                    MySqlCommand cmd = new MySqlCommand(sql, xyz); //executes the sql command
                    MySqlDataReader reader = cmd.ExecuteReader(); //must return a set of records

                    comboBox1.Items.Clear();
                    while (reader.Read())
                    {
                        comboBox1.Items.Add(reader["name"].ToString());
                    }



                }
            }
            catch (Exception ex) //object yung binibigay 
            {

                MessageBox.Show(ex.Message.ToString());
            }
        }

        public int findDepartmentByName(string name)
        {
            int result = 0; //to avoid multiple return statements // walang id na 0.
            try
            {
                using (MySqlConnection xyz = new MySqlConnection(helpers.connectionstring))
                {
                    xyz.Open();
                    string sql = "SELECT id FROM department WHERE name = @name";
                    MySqlCommand cmd = new MySqlCommand(sql, xyz);
                    cmd.Parameters.AddWithValue("name", name);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        result = int.Parse(reader["id"].ToString()); // this part retuturns an object id
                        
                    }

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
                result = 0;
            }

            return result;
        }

        private void adddwarf_Load(object sender, EventArgs e)
        {
            //put department data on the combobox when the form is loaded.
            populateCombocBoxWDepartments();

            if (_action == "edit")
            {
                txtname.Text = name;
                txtage.Text = age;
                txtcolor.Text = color;
                comboBox1.Text = department;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //DialogResult = DialogResult.OK;
            //MessageBox.Show(findDepartmentByName(comboBox1.Text).ToString());
            int departmentId = findDepartmentByName(comboBox1.Text);

            if (validateData(departmentId) == false)
            {
                return;
            }

          
            //validate data
            if (_action == "add")
            {
                //insert a new dwarf
                insertDwarf(departmentId); //if we're adding, call insert dwarf 
            }
            else
            {
                //edit a dwarf
                editDwarf(departmentId);
            }
        }

        public void insertDwarf(int departmentId)
        {
            try
            {
                using (MySqlConnection xyz = new MySqlConnection(helpers.connectionstring))
                {
                    xyz.Open();
                    string sql = "INSERT INTO dwarftable (name, age, color, department_id) VALUES ( @name, @age, @color, @department_id)";
                    MySqlCommand cmd = new MySqlCommand(sql, xyz);
                    cmd.Parameters.AddWithValue("name", txtname.Text); //buong textbox yung kukunin sa .text
                    cmd.Parameters.AddWithValue("age", txtage.Text);
                    cmd.Parameters.AddWithValue("color", txtcolor.Text);
                    cmd.Parameters.AddWithValue("department_id", departmentId);
                    cmd.ExecuteNonQuery();
                    DialogResult = DialogResult.OK;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
                DialogResult = DialogResult.Cancel;
            }
        }

        public void editDwarf(int departmentId)
        {
            try
            {
                using (MySqlConnection xyz = new MySqlConnection(helpers.connectionstring))
                {
                    xyz.Open();
                    string sql = "UPDATE dwarftable SET name = @name, age = @age, color = @color, department_id = @department_id WHERE id = @id";
                    MySqlCommand cmd = new MySqlCommand(sql, xyz);
                    cmd.Parameters.AddWithValue("name", txtname.Text); //buong textbox yung kukunin sa .text
                    cmd.Parameters.AddWithValue("age", txtage.Text);
                    cmd.Parameters.AddWithValue("color", txtcolor.Text);
                    cmd.Parameters.AddWithValue("department_id", departmentId);
                    cmd.Parameters.AddWithValue("id", id);
                    cmd.ExecuteNonQuery();
                    DialogResult = DialogResult.OK;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
                DialogResult = DialogResult.Cancel;
            }
        }

        private Boolean validateData(int departmentId)
        {
            bool result = true;

            if (txtname.Text == string.Empty)
            {
                MessageBox.Show("Please input a dwarf name");
                result = false;

            }
            else if (txtcolor.Text == string.Empty)
            {
                MessageBox.Show("Please input a dwarf color");
                result = false;
            }
            else if (txtage.Text == string.Empty)
            {
                MessageBox.Show("Please input the dwarf's age.");
                result = false;
            }
            else if (departmentId <= 0)
            {
                MessageBox.Show("Please select a department.");
                result = false;
            }

            return result;
        }
    }
}
