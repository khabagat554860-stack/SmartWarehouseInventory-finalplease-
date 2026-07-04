using System.Data;
using Microsoft.Data.SqlClient;

namespace SmartWarehouseInventory_finalplease_
{
    public partial class Form1 : Form
    {
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=WarehouseDB;Integrated Security=True;";

        public Form1()
        {
            InitializeComponent();
        }
        private void LoadInventory()
        {
            SqlConnection con = new SqlConnection(connectionString);

            try
            {
                con.Open();

                string query = "SELECT * FROM InventoryItems";

                SqlDataAdapter adapter = new SqlDataAdapter(query, con);

                DataTable dt = new DataTable();

                adapter.Fill(dt);

                dgvInventory.DataSource = dt;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);

            try
            {
                con.Open();
                MessageBox.Show("Connected Successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            InventoryItem item;
            SqlConnection con = new SqlConnection(connectionString);

            try
            {
                string itemID = txtItemID.Text;
                string itemName = txtItemName.Text;
                decimal baseCost = decimal.Parse(txtBaseCost.Text);
                int quantity = (int)numQuantity.Value;
                string itemType = cmbItemType.Text;
                string special = txtSpecial.Text;

                InventoryItem Item;

                if (itemType == "Perishable")
                {
                    double temperature = double.Parse(special);

                    item = new PerishableItem(itemID, itemName, baseCost, quantity, temperature);
                }
                else
                {
                    int cushioning = int.Parse(special);

                    item = new FragileItem(itemID, itemName, baseCost, quantity, cushioning);
                }

                decimal storageFee = item.CalculateStorageFee();
                lblStorageFee.Text = storageFee.ToString("C");

                con.Open();

                string query = @"INSERT INTO InventoryItems
                (ItemID, ItemName, BaseCost, Quantity, ItemType, SpecialAttribute)
                VALUES
                (@ItemID, @ItemName, @BaseCost, @Quantity, @ItemType, @SpecialAttribute)";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@ItemID", itemID);
                cmd.Parameters.AddWithValue("@ItemName", itemName);
                cmd.Parameters.AddWithValue("@BaseCost", baseCost);
                cmd.Parameters.AddWithValue("@Quantity", quantity);
                cmd.Parameters.AddWithValue("@ItemType", itemType);
                cmd.Parameters.AddWithValue("@SpecialAttribute", special);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Item inserted successfully!");

                LoadInventory();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadInventory();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);

            try
            {
                con.Open();

                string query = "DELETE FROM InventoryItems WHERE ItemID=@ItemID";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@ItemID", txtItemID.Text);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Item deleted successfully!");

                LoadInventory();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
