using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;//get sql

namespace GetSTUFF
{
    public partial class EditingFrm : Form
    {

        private Form1 _form1;//use this to jump back to main form. also used to set values of the main form

        //public EditingFrm() ***TODO DELETE IF DOESNT BREAK
        //{***TODO DELETE IF DOESNT BREAK
        //    InitializeComponent();***TODO DELETE IF DOESNT BREAK
        //}***TODO DELETE IF DOESNT BREAK



        public EditingFrm(Form1 form1)//controls for returning to main form
        {
            InitializeComponent();
            _form1 = form1;
        }

    

        private void EditingFrm_Load(object sender, EventArgs e)
        {
            button1.Text = "Go Back";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            // Create a DataTable to hold the data
            DataTable dataTable = new DataTable();
            // Create a SqlConnection and SqlCommand to retrieve the data
            using (SqlCommand command = new SqlCommand(DB_Connections.SqlQueries.GetEditFrmData, DB_Connections.SqlConnections.DB_Conn_SalesLT))
            {
                // Create a SqlDataAdapter to fill the DataTable
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    // Fill the DataTable with the data from the database
                    adapter.Fill(dataTable); //**************this automatically opens the connection and closes it
                }
            }
                 // Set the DataTable as the DataSource of the DataGridView
                 dataGridView1.DataSource = dataTable;
         }




        private void button1_Click(object sender, EventArgs e)//controls returning to main form
        {

            _form1.StartPosition = FormStartPosition.Manual; // Set the start position to manual
            _form1.Location = this.Location; // Set the location of EditingFrm to the same as Form1
            _form1.Show();
            this.Hide();

        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try

            {
                if (e.RowIndex >= 0)//if user selects the heading this if statement will prevent code from running and throwing an out of index error
                {
                    // Get the selected row from the DataGridView
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                    // Retrieve the values from the selected row
                    string value1 = selectedRow.Cells["OrderID"].Value.ToString(); // 
                    string value2 = selectedRow.Cells["CustomerID"].Value.ToString(); //
                    string value3 = selectedRow.Cells["OrderDate"].Value.ToString(); // 
                    string value4 = selectedRow.Cells["TotalAmount"].Value.ToString(); // 

                    ActualEditFrm ActualEditFrm = new ActualEditFrm(this); //create an instance of form 2

                    // Pass the values to the TextBox on Form2
                    ActualEditFrm.txtbxID.Text = value1;
                    ActualEditFrm.txtbxCustID.Text = value2;
                    ActualEditFrm.txtbxDate.Text = value3;
                    ActualEditFrm.txtbxAmt.Text = value4;
                    

                    ActualEditFrm.StartPosition = FormStartPosition.Manual; // Set the start position to manual
                    ActualEditFrm.Location = this.Location; // Set the location of EditingFrm to the same as Form1
                    ActualEditFrm.Show();
                    this.Hide();
                }
            }
         catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)//if any part of the cell is clicked the entire row will be highlighted. this will help avoid errors where they dont select the 'index' column
        {
            try
            {
                if (e.RowIndex >= 0)//if user selects the heading this if statement will prevent code from running and throwing an out of index error
                {
                    dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    dataGridView1.Rows[e.RowIndex].Selected = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        public void RefreshDataGridView() //this public method is used to reshresh the datagrid view from ActualEditFrm. When the button ok is clicked on that form this method is called apon to refresh the table
        {
            DataTable dataTable = new DataTable();
            // Create a SqlConnection and SqlCommand to retrieve the data
            using (SqlCommand command = new SqlCommand(DB_Connections.SqlQueries.GetEditFrmData, DB_Connections.SqlConnections.DB_Conn_SalesLT))
            {
                // Create a SqlDataAdapter to fill the DataTable
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    // Fill the DataTable with the data from the database
                    adapter.Fill(dataTable); //**************this automatically opens the connection and closes it
                }
            }
            // Set the DataTable as the DataSource of the DataGridView
            dataGridView1.DataSource = dataTable;
        }
    }
}
