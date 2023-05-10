using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace MyContact
{
    class Contacts_Repository : IContactsRepository
    {
        private string connectionString = "Data Source=.;Initial Catalog=Contact_DB;Integrated Security=true";
        public bool Delete(int ContactID)
        {
            throw new NotImplementedException();
        }

        public bool Insert(string Name, string family, string mobile, string email, int age, string address)
        {
            throw new NotImplementedException();
        }

        public DataTable SelectAll()
        {
            string query = "Select * From MyContacts";
            SqlConnection connction=new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter(query, connction);
            DataTable data=new DataTable();
            adapter.Fill(data);
            return data;

        }

        public DataTable SelectRow(int ContactID)
        {
            throw new NotImplementedException();
        }

        public bool Update(int ContactID, string Name, string family, string mobile, string email, int age, string address)
        {
            throw new NotImplementedException();
        }
    }
}
