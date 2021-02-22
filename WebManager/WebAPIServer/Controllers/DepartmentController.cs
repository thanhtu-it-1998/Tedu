using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using WebAPIServer.Models;
using WebAPIServer.Service;

namespace WebAPIServer.Controllers
{
    public class DepartmentController : ApiController
    {
        public ServiceSystemClass ssc = new ServiceSystemClass();
        //Lay du lieu
        public HttpResponseMessage Get()
        {
            string query = @"select ID, Name from Department";
            return Request.CreateResponse(HttpStatusCode.OK, ssc.ExceptionConnectSql(query));
        }
        // Them du lieu
        public string Post(Department dep)
        {
            try
            {
                string query = @"insert into dbo.Department values('" + dep.Name + @"')";
                DataTable table = ssc.ExceptionConnectSql(query);
                return "Added Successfully!!";
            }
            catch (Exception)
            {
                return "Failed to Add!!";
            }
        }
        //Sua du lieu
        public string Put(Department dep)
        {
            try
            {
                string query = @"update dbo.Department set Name='" + dep.Name + @"'where ID=" + dep.ID + @"";
                DataTable table = ssc.ExceptionConnectSql(query);
                return "Updated Successfully!!";
            }
            catch (Exception)
            {
                return "Failed to Update!!";
            }
        }

        //Xoa du lieu
        public string Delete(int id)
        {
            try
            {
                string query = @"delete from dbo.Department where ID=" + id + @"";

                DataTable table = ssc.ExceptionConnectSql(query);
                return "Deleted Successfully!!";
            }
            catch (Exception)
            {

                return "Failed to Delete!!";
            }
        }

        
    }
}

