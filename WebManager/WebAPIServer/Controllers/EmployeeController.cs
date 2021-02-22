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
    public class EmployeeController : ApiController
    {
        public ServiceSystemClass ssc = new ServiceSystemClass();
        //Lay du lieu
        public HttpResponseMessage Get()
        {
            string query = @"select * from Employee";
            return Request.CreateResponse(HttpStatusCode.OK, ssc.ExceptionConnectSql(query));
        }
        //Them du lieu
        [HttpPost]
        public string Post(Employee emp)
        {
            try
            {
                string query = @"insert into dbo.Employee values ('" + emp.Name + @"','" + emp.Department + @"','" + emp.DateOfJoining +@"','" + emp.PhotoFileName + @"')";
                DataTable table = ssc.ExceptionConnectSql(query);
                return "Added Successfully!!";
            }
            catch
            {
                return "Failed  to Add";
            }
        }
        //Sua du lieu
        public string Put(Employee emp)
        {
            try
            {
                string query = @"update dbo.Department set Name='" + emp.Name + @"',Department = '"+emp.Department+@"', DateOfJoining = '"+emp.DateOfJoining+@"', PhotoFileName = '"+emp.PhotoFileName+@"' where ID=" + emp.ID + @"";
                DataTable table = ssc.ExceptionConnectSql(query);
                return "Updated Successfully!!";
            }
            catch (Exception)
            {
                return "Failed to Update!!";
            }
        }
        public string Delete(int id)
        {
            try
            {
                string query = @"delete from dbo.Employee where ID=" + id + @"";
                DataTable table = ssc.ExceptionConnectSql(query);
                return "Deleted Successfully!!";
            }
            catch
            {
                return "Failed to Delete!!";
            }
        }
        [Route("api/Employee/GetAllDepartmentNames")]
        [HttpGet]
        public HttpResponseMessage GetAllDepartmentNames()
        {
            string query = @"select Name from dbo.Department";
            return Request.CreateResponse(HttpStatusCode.OK, ssc.ExceptionConnectSql(query));
        }
        [Route("api/Employee/SaveFile")]
        public string SaveFile()
        {
            try
            {
                var httpRequest = HttpContext.Current.Request;
                var postedFile = httpRequest.Files[0];
                string filename = postedFile.FileName;
                var physicalPath = HttpContext.Current.Server.MapPath("~/Photos/" + filename);

                postedFile.SaveAs(physicalPath);

                return filename;
            }
            catch (Exception)
            {

                return "anonymous.png";
            }
        }
    }
}
