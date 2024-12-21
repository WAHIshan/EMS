using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using Rectangle = System.Drawing.Rectangle;
using Word = Microsoft.Office.Interop.Word;

namespace EMS.usercontrol
{
    public partial class Upcomings : UserControl
    {
        private Button printButton;
        private PrintDocument printDocument1;
        public Upcomings()
        {
            InitializeComponent();
           
           

        }
        SqlConnection con = new SqlConnection("Data Source=MSI\\MSSQLSERVER01;Initial Catalog=EMS;Integrated Security=True;Encrypt=False");
        public void autogen()
        {
            string num = "12345678";
            int len = num.Length;
            string arr = string.Empty;
            int arrdigit = 5;
            string finaldigit;

            int getdigit;

            for (int i = 0; i < arrdigit; i++)
            {
                do
                {
                    getdigit = new Random().Next(0, len);
                    finaldigit = num.ToCharArray()[getdigit].ToString();

                } while (arr.IndexOf(finaldigit) != -1);
                arr += finaldigit;

            }
            UEventID.Text = (arr);
        }
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            {
                if (dataGridView1.Rows.Count > 0)
                {
                    SaveFileDialog save = new SaveFileDialog
                    {
                        Filter = "PDF (*.pdf)|*.pdf",
                        FileName = "Upcoming Event Details Sheet"
                    };

                    bool errorMessage = false;

                    if (save.ShowDialog() == DialogResult.OK)
                    {
                        if (File.Exists(save.FileName))
                        {
                            try
                            {
                                File.Delete(save.FileName);
                            }
                            catch (Exception ex)
                            {
                                errorMessage = true;
                                MessageBox.Show("Unable to write data to disk: " + ex.Message);
                            }
                        }

                        if (!errorMessage)
                        {
                            try
                            {
                                PdfPTable pTable = new PdfPTable(dataGridView1.Columns.Count)
                                {
                                    DefaultCell = { Padding = 2 },
                                    WidthPercentage = 100,
                                    HorizontalAlignment = Element.ALIGN_LEFT
                                };

                                foreach (DataGridViewColumn col in dataGridView1.Columns)
                                {
                                    PdfPCell pdfPCell = new PdfPCell(new Phrase(col.HeaderText));
                                    pTable.AddCell(pdfPCell);
                                }

                                foreach (DataGridViewRow viewRow in dataGridView1.Rows)
                                {
                                    foreach (DataGridViewCell dcell in viewRow.Cells)
                                    {
                                        if (dcell.Value != null)
                                        {
                                            pTable.AddCell(dcell.Value.ToString());
                                        }
                                    }
                                }

                                using (FileStream fileStream = new FileStream(save.FileName, FileMode.Create))
                                {
                                    Document document = new Document(PageSize.A4, 8f, 16f, 16f, 8f);
                                    PdfWriter.GetInstance(document, fileStream);
                                    document.Open();
                                    document.Add(pTable);
                                    document.Close();
                                }

                                MessageBox.Show("Data Exported Successfully", "info");
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error while exporting data: " + ex.Message);
                            }
                        }
                    }
                   cr4 form4 = new cr4();   
                    form4.Show();
                }
                else
                {
                    MessageBox.Show("No Record Found", "info");
                }
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            autogen();
        }
        void BindData()
        {
            SqlCommand cmd = new SqlCommand("select * from UEvent", con);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void Addevent_Click(object sender, EventArgs e)
        {

            try
            {
                con.Open();

                string query = "INSERT INTO UEvent (UEventID, EventName, EventCatgory, TimeDuration, Date) VALUES (@UEventID, @EventName, @EventCatgory, @TimeDuration, @Date)";


                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@UEventID", UEventID.Text);
                    cmd.Parameters.AddWithValue("@EventName", EventName.Text);
                    cmd.Parameters.AddWithValue("@EventCatgory", EventCatgory.Text);
                    cmd.Parameters.AddWithValue("@TimeDuration", TimeDuration.Text);
                    cmd.Parameters.AddWithValue("@Date", date.Text);
                   


                    cmd.ExecuteNonQuery();
                }


                MessageBox.Show("Successfully Inserted.");
            }
            catch (Exception ex)
            {

                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {

                con.Close();
                BindData();
            }
        }
        private void edit(bool value)
        {
            UEventID.Enabled = value;
            TimeDuration.Enabled = value;
            EventName.Enabled = value;
            date.Enabled = value;
            TimeDuration.Enabled = value;
        }

        private void save_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Are you sure you want to Clear Data?", "Clear Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                UEventID.Text = String.Empty;

                TimeDuration.Text = String.Empty;

                EventName.Text = String.Empty;

                date.Text = String.Empty;

                EventCatgory.Text = String.Empty;

            }
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to Detete Data?", "Detete Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Delete UEvent Where UEventID = '" + int.Parse(EID.Text) + "'",con);
                cmd.ExecuteNonQuery();
                con.Close();
                BindData();

            }
            else 
            {
                MessageBox.Show(" you Are Data is not Detete Data?", "Not Deleted", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            }
        }

        private void Upcomings_Load(object sender, EventArgs e)
        {
            BindData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UEventID_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
           
        }
        
       
    }
}
