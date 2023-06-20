using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// need to add sql namespace
using System.Data.SqlClient;


namespace GetSTUFF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen; //starts application on launch at center of screen
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Select City to Search";
            dataGridView1.ReadOnly = true;//makes sure form cant be edited by double clicking
            dataGridView1.RowHeadersVisible = false;//hides the index column
            button1.Text = "Open Editing Form";
               

            //on form load populate the combobox
            using (SqlDataAdapter adapter = new SqlDataAdapter(DB_Connections.SqlQueries.GetFormLoad, DB_Connections.SqlConnections.DB_Conn_SalesLT))
            {
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet, "TableName");

                
                // Set the ComboBox's DataSource and display member
                comboBox1.DataSource = dataSet.Tables["TableName"];
                comboBox1.DisplayMember = "City";
                // Assuming you have a ComboBox control named comboBox1
                comboBox1.DisplayMember = "City";
                comboBox1.ValueMember = "City";
                comboBox1.DataSource = dataSet.Tables["TableName"];
                
                
                DataTable defaultTable = new DataTable();//create table to then add columns into
                defaultTable.Columns.Add("City", typeof(string));//we want to add a new column
                defaultTable.Rows.Add("ALL");//the name of the entry
                DataTable mergedTable = dataSet.Tables["TableName"].Copy();//copy dataset so dont mess up data
                mergedTable.Merge(defaultTable);
                mergedTable.DefaultView.Sort = "City ASC";
                comboBox1.DataSource = mergedTable;

                comboBox1.SelectedIndex = -1; // set default value selection
                comboBox1.Text = "ALL"; // Set the default text

            }

            //on form load populate datagrid box
            using (SqlDataAdapter dataAdapter = new SqlDataAdapter(DB_Connections.SqlQueries.GetDataGridFormLoad,DB_Connections.SqlConnections.DB_Conn_SalesLT))
            {
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet, "tablename");
                dataGridView1.DataSource = dataSet.Tables["TableName"];
                dataGridView1.Columns["OrderiD"].Visible = false;
            }
        }
        private void comboBox1_DropDownClosed(object sender, EventArgs e)
        {
            string selectedValue = comboBox1.SelectedValue.ToString();//grab the value from the comboxbox to update datagridview
                                                                      // Perform data retrieval or update operations based on the selected value
            if (selectedValue == "ALL")//if combobox selects ALL we need to pull all default values
            {
                using (SqlDataAdapter dataAdapter = new SqlDataAdapter(DB_Connections.SqlQueries.GetDataGridFormLoad, DB_Connections.SqlConnections.DB_Conn_SalesLT))
                {
                    DataSet dataSet = new DataSet();
                    dataAdapter.Fill(dataSet, "tablename");
                    dataGridView1.DataSource = dataSet.Tables["TableName"];
                    dataGridView1.Columns["OrderiD"].Visible = false;
                }
            }

            else//if combobox pulls back anything else other than 'ALL' we need to filter data
            {
            DataTable updatedData = GetUpdatedData(selectedValue);

            // Update the DataGridView with the retrieved data
            dataGridView1.DataSource = updatedData;
            }



        }
       
        private DataTable GetUpdatedData(string selectedValue)
        {
            
                // Construct the SQL query with a parameter
                string query = "SELECT orderid, Orderdate, customerName, City,amount FROM [SalesLT].[dbo].[Orders] where city = @SelectedValue";
               
                // Create a SqlCommand with the query and connection
                using (SqlCommand command = new SqlCommand(query, DB_Connections.SqlConnections.DB_Conn_SalesLT))
                {
                    // Add the parameter to the command
                    command.Parameters.AddWithValue("@SelectedValue", selectedValue);

                    // Create a data adapter to retrieve the data
                    SqlDataAdapter adapter = new SqlDataAdapter(command);

                    // Create a DataTable to hold the retrieved data
                    DataTable data = new DataTable();

                    // Fill the DataTable with the data from the database
                    adapter.Fill(data);

                    // Return the updated data
                    return data;
                }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EditingFrm editingFrmVAR = new EditingFrm(this);
            editingFrmVAR.StartPosition = FormStartPosition.Manual; // Set the start position to manual
            editingFrmVAR.Location = this.Location; // Set the location of EditingFrm to the same as Form1
            editingFrmVAR.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            GetSTUFF.Forms.GuessingGameFrm guessingGameFormVAR = new GetSTUFF.Forms.GuessingGameFrm(this); // Create an instance of GuessingGameFrm
            guessingGameFormVAR.StartPosition = FormStartPosition.Manual;
            guessingGameFormVAR.Location = this.Location;
            guessingGameFormVAR.Show(); // Show GuessingGameFrm
            this.Hide(); // Hide Form1

        }

        private void btnLoopGame_Click(object sender, EventArgs e)
        {
            GetSTUFF.Forms.LoopingGuessingFrm loopingGuessingFrmVar = new GetSTUFF.Forms.LoopingGuessingFrm(this); // Create an instance of GuessingGameFrm
            loopingGuessingFrmVar.StartPosition = FormStartPosition.Manual;
            loopingGuessingFrmVar.Location = this.Location;
            loopingGuessingFrmVar.Show(); // Show GuessingGameFrm
            this.Hide(); // Hide Form1
        }
    }
}
