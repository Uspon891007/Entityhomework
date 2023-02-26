using Entityhomework.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entityhomework
{
    public partial class ReviesForm : Form
    {
        public ReviesForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ContactsModel contacts = new ContactsModel();
            var data = contacts.ContactsTable.ToList();
            if(data.Any((x) => x.Id == textBox1.Text))
            {
                var datas = contacts.ContactsTable.Where((x) => x.Id == textBox1.Text).ToList();
                foreach(var item in datas)
                {
                    item.Name= textBox2.Text;
                    item.Price= int.Parse(textBox4.Text);
                    item.Total= int.Parse(textBox3.Text);
                    item.category = textBox5.Text;
                }
                contacts.SaveChanges();
                MessageBox.Show("修改完成");

            }
            else
            {
                MessageBox.Show("修改失敗");
            }
        }
    }
}
