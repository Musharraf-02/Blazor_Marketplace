using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Marketplace.Shared;

namespace Marketplace.Server.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpPost]
        [ActionName("")]
        public async Task<IActionResult> Add(Product product)
        {
            string connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MarketDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection con = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand("INSERT INTO Products (sellerId,name,price,description,category,image) VALUES(@sId, @n, @p, @d, @cat,@im)", con);

            SqlParameter sId = new SqlParameter("sId", product.sellerId);
            SqlParameter n = new SqlParameter("n", product.name);
            SqlParameter p = new SqlParameter("p", product.price);
            SqlParameter d = new SqlParameter("d", product.description);
            SqlParameter cat = new SqlParameter("cat", product.category);
            SqlParameter im = new SqlParameter("im", product.image);


            cmd.Parameters.Add(sId);
            cmd.Parameters.Add(n);
            cmd.Parameters.Add(p);
            cmd.Parameters.Add(d);
            cmd.Parameters.Add(cat);
            cmd.Parameters.Add(im);


            con.Open();
            return Ok(cmd.ExecuteNonQuery());

        }

        [HttpPut]
        [ActionName("")]
        public async Task<IActionResult> Update([FromQuery]string key,Product product)
        {
            string connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MarketDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection con = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand("UPDATE Products SET sellerId=@sId,name=@n,price=@p,description=@d,category=@cat,image=@im where id=@i", con);
            SqlParameter sId = new SqlParameter("sId", product.sellerId);
            SqlParameter n = new SqlParameter("n", product.name);
            SqlParameter p = new SqlParameter("p", product.price);
            SqlParameter d = new SqlParameter("d", product.description);
            SqlParameter cat = new SqlParameter("cat", product.category);
            SqlParameter im = new SqlParameter("im", product.image);
            SqlParameter id = new SqlParameter("i", Int32.Parse(key));

            cmd.Parameters.Add(sId);
            cmd.Parameters.Add(n);
            cmd.Parameters.Add(p);
            cmd.Parameters.Add(d);
            cmd.Parameters.Add(cat);
            cmd.Parameters.Add(im);
            cmd.Parameters.Add(id);

            con.Open();
            return Ok(cmd.ExecuteNonQuery());
        }

        [HttpDelete]
        [ActionName("")]
        public async Task<IActionResult> Delete([FromQuery]string id)
        {
            string connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MarketDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection con = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand("Delete from Products where id=@i", con);
            SqlParameter i = new SqlParameter("i", Int32.Parse(id));
            cmd.Parameters.Add(i);
            con.Open();
            return Ok(cmd.ExecuteNonQuery());
        }

        [HttpGet]
        [ActionName("")]
        public async Task<IActionResult> Get()
        {
            List<Product> productsList = new List<Product>();
            string connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MarketDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection con = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand("Select * from Products", con);
            con.Open();
            SqlDataReader data = cmd.ExecuteReader();
            while (data.Read())
            {
                Product product = new Product();
                product.id = data.GetInt32(0);
                product.sellerId = data.GetInt32(1);
                product.name = data.GetString(2);
                product.price = data.GetDouble(3);
                product.description = data.GetString(4);
                product.category = data.GetString(5);
                product.image = data.GetString(6);
                productsList.Add(product);
            }

            return Ok(productsList);
        }

        /* Use this URLhttps://localhost:44371/api/Product/GetBySellerID?sId=2*/
        [HttpGet]
        [ActionName("GetBySellerID")]
        public async Task<IActionResult> Get([FromQuery] string sId)
        {
            List<Product> productsList = new List<Product>();
            string connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MarketDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection con = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand("Select * from Products where sellerId=@sId", con);
            SqlParameter id = new SqlParameter("sId", Int32.Parse(sId));
            cmd.Parameters.Add(id);
            con.Open();
            SqlDataReader data = cmd.ExecuteReader();

            while (data.Read())
            {
                Product product = new Product();
                product.id = data.GetInt32(0);
                product.sellerId = data.GetInt32(1);
                product.name = data.GetString(2);
                product.price = data.GetDouble(3);
                product.description = data.GetString(4);
                product.category = data.GetString(5);
                product.image = data.GetString(6);
                productsList.Add(product);
            }

            return Ok(productsList);
        }

        /*Use this URLhttps:// localhost:44371/api/Product/GetByProductID?pId=1003 */
        [HttpGet]
        [ActionName("GetByProductID")]
        public async Task<IActionResult> GetByAddressId([FromQuery] string pId)
        {
            string connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MarketDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection con = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand("Select * from Products where id=@i", con);
            SqlParameter id = new SqlParameter("i", Int32.Parse(pId));
            cmd.Parameters.Add(id);
            con.Open();
            SqlDataReader data = cmd.ExecuteReader();
            data.Read();

            Product product = new Product();
            product.id = data.GetInt32(0);
            product.sellerId = data.GetInt32(1);
            product.name = data.GetString(2);
            product.price = data.GetDouble(3);
            product.description = data.GetString(4);
            product.category = data.GetString(5);
            product.image = data.GetString(6);


            return Ok(product);
        }

    }
}
