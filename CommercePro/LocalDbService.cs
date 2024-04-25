using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommercePro
{
    public class LocalDbService
    {
        private const string DB_NAME = "shopDB.db3";
        private readonly SQLiteAsyncConnection _connection;

        public LocalDbService()
        {
            _connection = new SQLiteAsyncConnection(Path.Combine(FileSystem.AppDataDirectory, DB_NAME));
            _connection.CreateTableAsync<Product>();
        }
        public async Task<List<Product>> GetProducts()
        {
            return await _connection.Table<Product>().ToListAsync();
        }

        public async Task<Product> GetById(int id)
        {
            return await _connection.Table<Product>().Where(x => x.ProductID == id).FirstOrDefaultAsync();
        }

        public async Task Create(Product product)
        {
            await _connection.InsertAsync(product);
        }

        public async Task Update(Product product)
        {
            await _connection.UpdateAsync(product);
        }

        public async Task Delete(Product product)
        {
            await _connection.DeleteAsync(product);
        }
    }
}
