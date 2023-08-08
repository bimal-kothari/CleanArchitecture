using CleanArch.Application.Interfaces;
using CleanArch.Core.Models;
using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Infrastructure.Repositories
{
    public class ProductRepository : IProductRepository
    {
        // Make it possible to read a connection string from configuration
        private readonly IConfiguration _configuration;

        public ProductRepository(IConfiguration configuration)
        {
            // Injecting Iconfiguration to the contructor of the product repository
            _configuration = configuration;
        }      

        /// <summary>
        /// This method returns all products in database in a list object
        /// </summary>
        /// <returns>IEnumerable Product</returns>
        public async Task<IReadOnlyList<Product>> GetAllAsync()
        {
            var sql = "SELECT * FROM Products";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DapperConnection")))
            {
                connection.Open();

                // Map all products from database to a list of type Product defined in Models.
                // this is done by using Async method which is also used on the GetByIdAsync
                var result = await connection.QueryAsync<Product>(sql);
                return result.ToList();
            }
        }

    
    }
}

