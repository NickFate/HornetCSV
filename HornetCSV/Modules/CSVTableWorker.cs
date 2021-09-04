using HornetCSV.Intarfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;

namespace HornetCSV.Modules
{
    class CSVTableWorker : ICSVWorker
    {

        public DataTable OpenTable(string path)
        {
            DataTable data = new DataTable();
            StreamReader reader = new StreamReader(path);
            List<string[]> ms = new List<string[]>();
            while (true)
            {
                string str = reader.ReadLine();
                if (str == null)
                {
                    break;
                }
                string[] m = str.Split(';');
                ms.Add(m);
            }
            
            
            for (int i = 0; i < ms[0].Length; i++)
            {
                DataColumn c = new DataColumn();
                c.ColumnName = i.ToString();
                data.Columns.Add(c);
            }
            
            foreach (string[] i in ms)
            {
                DataRow row = data.NewRow();
                row.ItemArray = i;
                data.Rows.Add(row);
            }

            return data;
        }

        public Results SaveTable(string path, DataTable data)
        {
            StreamWriter writer = new StreamWriter(path, false);
            foreach (DataRow a in data.Rows)
            {
                
                writer.WriteLine(String.Join(";", a.ItemArray));
            }
            writer.Close();
            return Results.OK;

        }
    }
}
