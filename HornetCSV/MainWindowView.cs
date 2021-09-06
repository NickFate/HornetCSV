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
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            
            string path;

            OpenFileDialog file = new OpenFileDialog();
            file.Title = "Выберите .csv файл";
            file.Filter = "Файлы *.csv|*.csv";
            if (file.ShowDialog() == DialogResult.OK)
            {
                AddColumnButton.Enabled = true;
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
    }
}
