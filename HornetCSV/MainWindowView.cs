using HornetCSV.Intarfaces;
using HornetCSV.Modules;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            
            AddColumnButton.Enabled = false;
            AddColumnButton.Visible = false;
            RemoveColumnButton.Enabled = false;
            RemoveColumnButton.Visible = false;

            AddRowButton.Enabled = false;
            AddRowButton.Visible = false;
            RemoveRowButton.Enabled = false;
            RemoveRowButton.Visible = false;
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            
            string path;

            OpenFileDialog file = new OpenFileDialog();
            file.Title = "Выберите .csv файл";
            file.Filter = "Файлы *.csv|*.csv";
            if (file.ShowDialog() == DialogResult.OK)
            {
                AddColumnButton.Visible = true;
                AddColumnButton.Enabled = true;
                RemoveColumnButton.Enabled = true;
                RemoveColumnButton.Visible = true;

                AddRowButton.Enabled = true;
                AddRowButton.Visible = true;
                RemoveRowButton.Enabled = true;
                RemoveRowButton.Visible = true;

                path = file.FileName;
                data = worker.OpenTable(path);
                AppTable.DataSource = data;
            }

            
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {

            string path;

            SaveFileDialog file = new SaveFileDialog();
            file.Title = "Выберите .csv файл";
            file.Filter = "Файлы *.csv|*.csv";
            if (file.ShowDialog() == DialogResult.OK)
            {
                path = file.FileName;
                worker.SaveTable(path, data);
            }

            
        }

        private void AddColumnButton_Click(object sender, EventArgs e)
        {
            DataColumn c = new DataColumn();
            c.ColumnName = (data.Columns.Count).ToString();
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
    }
}
