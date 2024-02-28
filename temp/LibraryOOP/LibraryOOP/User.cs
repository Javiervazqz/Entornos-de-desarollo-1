using System;

namespace LibraryOOP
{
    public class User
    {
        string DNI, address, phoneNum;
        public bool IsSanctionated { get; set; }
        Loan[] loans = new Loan[5];
        public string fullName { get; set; }
        public User(string dni, string nombre, string direccion, string numtlf)
        {
            DNI = dni;
            fullName = nombre;
            address = direccion;
            phoneNum = numtlf;
        }
        ~User() //Destructor de user
        {

        }
    }
}
