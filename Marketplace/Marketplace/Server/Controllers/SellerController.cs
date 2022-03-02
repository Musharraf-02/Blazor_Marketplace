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
    public class SellerController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> Add(Seller seller)
        {
            string connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MarketDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection con = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand("INSERT INTO Seller (addressId,emailAddress,shopName,phoneNumber,password) VALUES(@aId, @email, @sn, @ph, @pass)", con);

            SqlParameter aId = new SqlParameter("aId", seller.addressId);
            SqlParameter email = new SqlParameter("email", seller.emailAddress);
            SqlParameter sn = new SqlParameter("sn", seller.shopName);
            SqlParameter ph = new SqlParameter("ph", seller.phoneNumber);
            SqlParameter pass = new SqlParameter("pass", seller.password);

            cmd.Parameters.Add(aId);
            cmd.Parameters.Add(email);
            cmd.Parameters.Add(sn);
            cmd.Parameters.Add(ph);
            cmd.Parameters.Add(pass);


            con.Open();
            return Ok(cmd.ExecuteNonQuery());

        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            List<Seller> sellerList = new List<Seller>();
            string connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MarketDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection con = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand("Select * from Seller", con);
            con.Open();
            SqlDataReader data = cmd.ExecuteReader();
            while (data.Read())
            {
                Seller seller = new Seller();
                seller.id = data.GetInt32(0);
                seller.addressId = data.GetInt32(1);
                seller.emailAddress = data.GetString(2);
                seller.shopName = data.GetString(3);
                seller.phoneNumber = data.GetString(4);
                seller.password = data.GetString(5);
                sellerList.Add(seller);
            }

            return Ok(sellerList);
        }

    }
}
