﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace CapaDatos
{
   public  class Conexion
    {

        public Conexion()
            {}
       public string getConex() 
        {
            string strConex = ConfigurationManager.ConnectionStrings["cnnString"].ConnectionString;
           if (object.ReferenceEquals(strConex,string.Empty))
            {
                return string.Empty;
            }
           else
            {
                return strConex;
            }

        }
    }
}
