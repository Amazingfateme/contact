using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyContact
{
    public partial class btnnewcontact : Form
    {
        IContactsRepository repository;

        public btnnewcontact()
        {
            InitializeComponent();
            repository= new Contacts_Repository();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BindGrid();

        }

        private void BindGrid()
        {
            dgContacts.AutoGenerateColumns = false;
            dgContacts.DataSource = repository.SelectAll();
        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void dgContacts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
