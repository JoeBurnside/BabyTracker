using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewbornApp
{
   static class Global
    {
       private static string m_name;
       public static string Globalname
       {
           get { return m_name; }
           set { m_name = value; }
       }

    }
}
