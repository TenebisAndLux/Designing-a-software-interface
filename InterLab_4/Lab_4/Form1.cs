using System.Data;
using System.Windows.Forms;

namespace lab_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            int n = dgvAdmin.Rows.Add();

            dgvAdmin.Rows[n].Cells["colAutor"].Value = tbAutor.Text;
            dgvAdmin.Rows[n].Cells["colName"].Value = tbName.Text;
            dgvAdmin.Rows[n].Cells["colYear"].Value = tbYear.Text;
            dgvAdmin.Rows[n].Cells["colIZD"].Value = tbIZD.Text;
            dgvAdmin.Rows[n].Cells["colJanr"].Value = tbJanr.Text;
            dgvAdmin.Rows[n].Cells["colCount"].Value = tbCount.Text;
        }

        private void bEdit_Click(object sender, EventArgs e)
        {
            dgvAdmin.SelectedRows[0].Cells["colAutor"].Value = tbAutor.Text;
            dgvAdmin.SelectedRows[0].Cells["colName"].Value = tbName.Text;
            dgvAdmin.SelectedRows[0].Cells["colYear"].Value = tbYear.Text;
            dgvAdmin.SelectedRows[0].Cells["colIZD"].Value = tbIZD.Text;
            dgvAdmin.SelectedRows[0].Cells["colJanr"].Value = tbJanr.Text;
            dgvAdmin.SelectedRows[0].Cells["colCount"].Value = tbCount.Text;
        }

        private void bDel_Click(object sender, EventArgs e)
        {
            if (dgvAdmin.SelectedRows.Count > 0)
            {
                dgvAdmin.Rows.Remove(dgvAdmin.SelectedRows[0]);
            }
        }

        private void bDow_Click(object sender, EventArgs e)
        {
            if (dgvAdmin.Rows.Count > 0)
            {
                MessageBox.Show("Clear table rows. Error.");
            }
            else
            {
                if (File.Exists("data.xml"))
                {
                    DataSet ds = new DataSet();
                    ds.ReadXml("data.xml");
                    foreach (DataRow r in ds.Tables["Admin"].Rows)
                    {
                        int n = dgvAdmin.Rows.Add();
                        dgvAdmin.Rows[n].Cells["colAutor"].Value = r["Autor"];
                        dgvAdmin.Rows[n].Cells["colName"].Value = r["Name"];
                        dgvAdmin.Rows[n].Cells["colYear"].Value = r["Year"];
                        dgvAdmin.Rows[n].Cells["colIZD"].Value = r["IZD"];
                        dgvAdmin.Rows[n].Cells["colJanr"].Value = r["Janr"];
                        dgvAdmin.Rows[n].Cells["colCount"].Value = r["Count"];
                    }
                }
                else
                {
                    MessageBox.Show("Download error: 1::9");
                }
            }
        }

        private void bSet_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                dt.TableName = "Admin";
                dt.Columns.Add("Autor");
                dt.Columns.Add("Name");
                dt.Columns.Add("Year");
                dt.Columns.Add("IZD");
                dt.Columns.Add("Janr");
                dt.Columns.Add("Count");

                ds.Tables.Add(dt);

                foreach (DataGridViewRow r in dgvAdmin.Rows)
                {
                    DataRow row = ds.Tables["Admin"].NewRow();
                    row["Autor"] = r.Cells["colAutor"].Value.ToString();
                    row["Name"] = r.Cells["colName"].Value.ToString();
                    row["Year"] = r.Cells["colYear"].Value.ToString();
                    row["IZD"] = r.Cells["colIZD"].Value.ToString();
                    row["Janr"] = r.Cells["colJanr"].Value.ToString();
                    row["Count"] = r.Cells["colCount"].Value.ToString();

                    ds.Tables["Admin"].Rows.Add(row);
                }
                ds.WriteXml("data.xml");
            }
            catch
            {
                MessageBox.Show("Save error: 1::7");
            }
        }

        private void bClear_Click(object sender, EventArgs e)
        {
            if (dgvAdmin.Rows.Count > 0)
            {
                dgvAdmin.Rows.Clear();
            }
        }

        private void bSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbAutorS.Text))
            {
                MessageBox.Show("Search parameter is empty!");
            }
            else
            {
                DataSet dss = new DataSet();
                DataTable dts = new DataTable();
                dts.TableName = "AdminSearch";
                dts.Columns.Add("Автор");
                dts.Columns.Add("Наименование");
                dts.Columns.Add("Год издания");
                dts.Columns.Add("Издательство");
                dts.Columns.Add("Жанр");
                dts.Columns.Add("Кол-во. страниц");

                dss.Tables.Add(dts);

                foreach (DataGridViewRow r in dgvAdmin.Rows)
                {
                    if (r.Cells["colAutor"].Value.ToString() == tbAutorS.Text)
                    {
                        DataRow row = dss.Tables["AdminSearch"].NewRow();
                        row["Автор"] = r.Cells["colAutor"].Value.ToString();
                        row["Наименование"] = r.Cells["colName"].Value.ToString();
                        row["Год издания"] = r.Cells["colYear"].Value.ToString();
                        row["Издательство"] = r.Cells["colIZD"].Value.ToString();
                        row["Жанр"] = r.Cells["colJanr"].Value.ToString();
                        row["Кол-во. страниц"] = r.Cells["colCount"].Value.ToString();

                        dss.Tables["AdminSearch"].Rows.Add(row);
                    }
                }

                if (dss.Tables["AdminSearch"].Rows.Count == 0)
                {
                    MessageBox.Show("Oops... It seems nothing was found.");
                }
                else
                {
                    Form2 fSearch = new Form2(dss, "AdminSearch");
                    fSearch.Show();
                }
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}