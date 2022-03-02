using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Marketplace.Shared;
using System.Data.SqlClient;

namespace Marketplace.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressController : ControllerBase
    {
        [HttpPost]
        public async Task<int> Add(Address address)
        {
            string connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MarketDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection con = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand("INSERT INTO Address (address) VALUES(@a)", con);
            SqlParameter a = new SqlParameter("a", address.address);
            cmd.Parameters.Add(a);
            con.Open();
            cmd.ExecuteNonQuery();
  
            SqlCommand cmd2 = new SqlCommand("SELECT MAX(id) FROM Address",con);
            SqlDataReader data = cmd2.ExecuteReader();
            data.Read();

            return data.GetInt32(0);
          
        }
    }
}
