using System;
using Wpf_Pegadaian.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf_Pegadaian.Controllers
{
    
    class Login
    {
        PegadaianEntities1 _db = new PegadaianEntities1();
        public bool cekLogin(string username, string password)
        {
            bool cek = false;
            var temp = _db.USERs.FirstOrDefault();
            try
            {
                if (temp.USERNAME == username && temp.PASSWORD == password)
                {
                    cek = true;
                }
            }
            catch (Exception ex)
            {
                cek = false;
                ex.GetBaseException();
            }
            return cek;
        }

    }
}
