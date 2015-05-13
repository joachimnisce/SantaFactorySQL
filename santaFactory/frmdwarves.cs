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

                //throw error = messagebox
                MessageBox.Show(abc.Message.ToString());
            }
        }

        private void frmdwarves_Load(object sender, EventArgs e)
        {
            populateListView();
        }
    }
}
