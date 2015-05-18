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
    public partial class frmdwarves : Form
    {
        public frmdwarves()
        {
            InitializeComponent();
        }

        private void populateListView()
        {
            try
            {
                using (MySqlConnection xyz = new MySqlConnection(helpers.connectionstring))
                {
                    xyz.Open(); //opened the connection to mysql
                    string sql = "SELECT dwarftable.*, (department.name) AS depname FROM dwarftable INNER JOIN department ON department.id = dwarftable.department_id";
                    MySqlCommand cmd = new MySqlCommand(sql, xyz);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    lstDwarves.Items.Clear();
                    while (reader.Read())
                    {
                        lstDwarves.Items.Add(reader["id"].ToString());
                        //count at this point is 1. first row. first loop.
                        //
                        lstDwarves.Items[lstDwarves.Items.Count - 1].SubItems.Add(reader["name"].ToString());
                        lstDwarves.Items[lstDwarves.Items.Count - 1].SubItems.Add(reader["age"].ToString());
                        lstDwarves.Items[lstDwarves.Items.Count - 1].SubItems.Add(reader["color"].ToString());
                        lstDwarves.Items[lstDwarves.Items.Count - 1].SubItems.Add(reader["depname"].ToString());
                        //MessageBox.Show(reader["name"].ToString());

                    }

                }
            }
            catch (Exception abc)
            {

               // throw error = messagebox
                MessageBox.Show(abc.Message.ToString());
            }
        }

        private void frmdwarves_Load(object sender, EventArgs e)
        {
            populateListView();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            adddwarf frm = new adddwarf("add");
            if (frm.ShowDialog() == DialogResult.OK)
            {
                //after saving data, populate list view in the list of dwarves.
                populateListView();
                //MessageBox.Show(" You're saving a dwarf.");
            }
           


        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            adddwarf frm = new adddwarf("edit");
            frm.id = int.Parse(lstDwarves.SelectedItems[0].Text);
            frm.name = (lstDwarves.SelectedItems[0].SubItems[1].Text);
            frm.age = (lstDwarves.SelectedItems[0].SubItems[2].Text);
            frm.color = (lstDwarves.SelectedItems[0].SubItems[3].Text);
            frm.department = lstDwarves.SelectedItems[0].SubItems[4].Text;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                //after saving data, populate list view in the list of dwarves.
                populateListView();
                //MessageBox.Show(" You're saving a dwarf.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection xyz = new MySqlConnection(helpers.connectionstring))
                {
                    xyz.Open();
                    string sql = "DELETE FROM dwarftable WHERE id = @id";
                    MySqlCommand cmd = new MySqlCommand(sql, xyz);
                    cmd.Parameters.AddWithValue("id", lstDwarves.SelectedItems[0].Text);
                    cmd.ExecuteNonQuery();
                    populateListView();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
                
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            int id = int.Parse(lstDwarves.SelectedItems[0].Text);
            string name = lstDwarves.SelectedItems[0].SubItems[1].Text;
            viewToysCreated frm = new viewToysCreated(id);
            frm.Dwarfname = name;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                
            }
            
        }

        

        //view toys created



    }
}
