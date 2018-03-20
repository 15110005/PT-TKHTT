using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Hoang_Tin.DataAccess;

namespace Hoang_Tin
{
    class MonBO
    {
        DBAccess db = new DBAccess();
        public DataTable getMaMon()
        {
            string query = "Select MaMon from tblDSMon";
            return db.getDS(query);
        }
    }
}
