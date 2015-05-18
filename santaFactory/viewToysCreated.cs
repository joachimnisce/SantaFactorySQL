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
    public partial class viewToysCreated : Form
    {
        public string Dwarfname { get; set; }

        private int _dwarfId;

        public viewToysCreated(int dwarfId)
        {
            InitializeComponent();
            this._dwarfId = dwarfId;
        }
        
        public void populateToys()
        {
            try
	        {	
                using(MySqlConnection xyz = new MySqlConnection(helpers.connectionstring))
	                {
		                xyz.Open();
                        string sql = "SELECT * FROM createdtoys WHERE dawrf_id = @dwarfId"; //dawrf_id is the foreign key
                        MySqlCommand cmd = new MySqlCommand(sql, xyz);
                        cmd.Parameters.AddWithValue("dwarfId", _dwarfId);

                        MySqlDataReader reader = cmd.ExecuteReader();
                        lstToys1.Items.Clear();

                    while (reader.Read())
	                    {
	                        lstToys1.Items.Add(reader["id"].ToString());
                            lstToys1.Items[lstToys1.Items.Count - 1].SubItems.Add(reader["nameoftoy"].ToString());

	                    }
	                }
		
	        }
	        catch (Exception ex)
	        {
		
		        MessageBox.Show(ex.Message.ToString());
	        }
        }
        private void viewToysCreated_Load(object sender, EventArgs e)
        { 
            populateToys();

            label1.Text = Dwarfname;
        }
    }
}
