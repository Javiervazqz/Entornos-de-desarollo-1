using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace NDUPcopy
{
    public class Archivo
    {
        public byte[] bytes;
        long hash;
        SHA256 sha;
    }
}
