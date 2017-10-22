﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QLYVATTU.MODEL
{
    class ChiNhanh
    {

        public string tenchinhanh { get; set; }
        public string machinhanh { get;set; }

        public static String SP_LAYCHINHANH = "SP_LAYCHINHANH";
        public DataTable getChiNhanh() // lay chi nhanh
    	{
    		DataTable chinhanh = Access.execDataTableSP(SP_LAYCHINHANH,null);
    		return chinhanh;
    	}
    }
}
