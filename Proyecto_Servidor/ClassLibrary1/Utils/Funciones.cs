using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Utils
{
    public static class Funciones
    {
        public static bool esNumero(string num) 
        {
            try
            {
                int.Parse(num);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        } 
    }
}
