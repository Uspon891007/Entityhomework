using Entityhomework.Models;
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

namespace Entityhomework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form = new ViewForm();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var form = new AddForm();
            form.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var form = new RemoveForm();
            form.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var form = new ReviesForm();
            form.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var form = new SelectForm();
            form.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            List<ContactsTable> products = CreatesList();
            ContactsModel contacts= new ContactsModel();
            try
            {
                foreach (var items in products)
                {
                    contacts.ContactsTable.Add(items);
                }
                contacts.SaveChanges();
                MessageBox.Show("匯入資料成功");
            }
            catch(Exception ex) 
            { 
                MessageBox.Show("已匯入過資料");
            }
            
        }

        private static List<ContactsTable> CreatesList()
        {
            string csvFilePath = @"product.csv";
            using (var reader = new StreamReader(csvFilePath))
            {
                // Skip the first line (header)
                reader.ReadLine();
                var list = new List<ContactsTable>();
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] values = line.Split(',');
                    var good = new ContactsTable();



                    good.Id = values[0];
                    good.Name = values[1];
                    good.Total = int.Parse(values[2]);
                    good.Price = int.Parse(values[3]);
                    good.category = values[4];
                    list.Add(good);

                }

                return list;

            }


        }
    }
}
