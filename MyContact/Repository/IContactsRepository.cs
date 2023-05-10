using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace MyContact
{
    internal interface IContactsRepository
    {
        DataTable SelectAll();
        DataTable SelectRow(int ContactID);
        bool Insert(string Name, string family, string mobile, string email,
            int age, string address);
        bool Update(int ContactID, string Name, string family, string mobile, string email,
            int age, string address);
        bool Delete(int ContactID);
        
         
        
        
    }
}
