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

namespace GetSTUFF
{
    public partial class ActualEditFrm : Form
    {

        private EditingFrm _EditFrm;//controls returning to main form

        public ActualEditFrm(EditingFrm EditFrm)//controls for returning to main form
        {
            InitializeComponent();
            _EditFrm = EditFrm;//creates and object _EditFrm
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _EditFrm.StartPosition = FormStartPosition.Manual; // Set the start position to manual
            _EditFrm.Location = this.Location; // Set the location of EditingFrm to the same as Form1
            _EditFrm.Show();
            this.Hide();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {

                string newAmount = txtbxEditAmt.Text;//grabs new amount
                string OrderID = txtbxID.Text;//grabs orderid which is primary key
                decimal value;

                if(decimal.TryParse(newAmount, out value))//audits the texbox value to make sure its a valid input
                {
                    using (SqlCommand command = new SqlCommand(DB_Connections.SqlQuerieUpdates.UpdateOrderAMT, DB_Connections.SqlConnections.DB_Conn_SalesLT))//creates command using sql connection and sql query
                    {
                 
                            command.Parameters.AddWithValue("@newAmount", newAmount);
                            command.Parameters.AddWithValue("@OrderId", OrderID);
                            command.Connection.Open();
                            command.ExecuteNonQuery();
                            command.Connection.Close();


                        _EditFrm.StartPosition = FormStartPosition.Manual; // Set the start position to manual
                        _EditFrm.Location = this.Location; // Set the location of EditingFrm to the same as Form1
                        _EditFrm.RefreshDataGridView();//refreshes the datagrid view on editfrm
                        _EditFrm.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid input");
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            
        }
    }
}
