using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MyERP.DBContext;

namespace MyERP.Controllers
{  
    public class EmployeeAPIController : BaseAPIController
    {
        public HttpResponseMessage Get()
        {
            return ToJson(MyERPDB.TblEmployees.AsEnumerable());
        }

        public HttpResponseMessage Post([FromBody]TblEmployee value)
        {
            MyERPDB.TblEmployees.Add(value);
            return ToJson(MyERPDB.SaveChanges());
        }

        public HttpResponseMessage Put(int id, [FromBody]TblEmployee value)
        {
            MyERPDB.Entry(value).State = EntityState.Modified;
            return ToJson(MyERPDB.SaveChanges());
        }
        public HttpResponseMessage Delete(int id)
        {
            MyERPDB.TblEmployees.Remove(MyERPDB.TblEmployees.FirstOrDefault(x => x.Id == id));
            return ToJson(MyERPDB.SaveChanges());
        }
    }
}
