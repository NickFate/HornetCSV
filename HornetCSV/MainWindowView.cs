using HornetCSV.Intarfaces;
using HornetCSV.Modules;
using System;
using System.Data;
using System.Windows.Forms;

namespace HornetCSV
{
    public partial class MainAppView : Form
    {
        private DataTable data;
        private ICSVWorker worker;

        public MainAppView()
        {
            InitializeComponent();
            worker = new CSVTableWorker();

            AppTable.AllowUserToDeleteRows = true;
            AppTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            AppTable.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;

            ChangeVisible(false);
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            
            string path;

            OpenFileDialog file = new OpenFileDialog
            {
                Title = "Выберите .csv файл",
                Filter = "Файлы *.csv|*.csv"
            }
            ;
            if (file.ShowDialog() == DialogResult.OK)
            {
                ChangeVisible(true);

                path = file.FileName;
                data = worker.OpenTable(path);
                AppTable.DataSource = data;
            }

            
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {

            string path;

            if (data == null)
            {
                MessageBox.Show(
                    "Data is null",
                    "Error Message",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
                return;
            }

            SaveFileDialog file = new SaveFileDialog
            {
                Title = "Выберите .csv файл",
                Filter = "Файлы *.csv|*.csv"
            };
            if (file.ShowDialog() == DialogResult.OK)
            {
                path = file.FileName;
                worker.SaveTable(path, data);
            }

            
        }

        private void AddColumnButton_Click(object sender, EventArgs e)
        {
            DataColumn c = new DataColumn
            {
                ColumnName = (data.Columns.Count).ToString()
            };
            data.Columns.Add(c);
        }

        private void RemoveColumnButton_Click(object sender, EventArgs e)
        {
            if (data.Columns.Count - 1 < 0)
            {
                return;
            }
            data.Columns.RemoveAt(data.Columns.Count - 1);
        }

        private void AddRowButton_Click(object sender, EventArgs e)
        {
            DataRow r = data.NewRow();
            data.Rows.Add(r);
        }

        private void RemoveRowButton_Click(object sender, EventArgs e)
        {
            if (data.Rows.Count - 1 < 0)
            {
                return;
            }
            data.Rows.RemoveAt(data.Rows.Count - 1);
        }

        private void NewTableButton_Click(object sender, EventArgs e)
        {
            data = new DataTable();

            AppTable.DataSource = data;
            ChangeVisible(true);
        }

        private void ChangeVisible(bool mode)
        {
            AddColumnButton.Visible = mode;
            AddColumnButton.Enabled = mode;
            RemoveColumnButton.Enabled = mode;
            RemoveColumnButton.Visible = mode;

            AddRowButton.Enabled = mode;
            AddRowButton.Visible = mode;
            RemoveRowButton.Enabled = mode;
            RemoveRowButton.Visible = mode;
        }
    }
}
