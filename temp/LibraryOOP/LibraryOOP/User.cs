using System;

namespace LibraryOOP
{
    public class User
    {
        string DNI, fullName, address, phoneNum;
        public bool IsSanctionated { get; set; }
        Loans[] loans = new Loans[5];
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
