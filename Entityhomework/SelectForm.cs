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
    public partial class SelectForm : Form
    {
        public SelectForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ContactsModel contacts = new ContactsModel();
            var data = contacts.ContactsTable.ToList();
            if(data.Any((x) => x.Id == textBox1.Text))
            {
                dataGridView1.DataSource = data;
            }
            else
            {
                MessageBox.Show("查無此商品");
            }
            
        }
    }
}
