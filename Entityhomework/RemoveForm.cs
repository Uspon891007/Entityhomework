using Entityhomework.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entityhomework
{
    public partial class RemoveForm : Form
    {
        public RemoveForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ContactsModel contacts = new ContactsModel();
            var data = contacts.ContactsTable.ToList();
            if(data.Any((x) => x.Id == textBox1.Text))
            {
                foreach(var item in data)
                {
                    contacts.ContactsTable.Remove(item);
                    contacts.SaveChanges();

                }
                MessageBox.Show("此商品已刪除");
            }
            else
            {
                MessageBox.Show("沒有此商品無法刪除");
            }
        }
    }
}
