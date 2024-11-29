using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using smartstick1.Models;

namespace smartstick1.Data
{
    class DatabaseServices
    {
        private readonly SQLiteAsyncConnection _database;

        public DatabaseServices(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<User>().Wait();
        }

        public Task<User> GetUserAsync(string username)
        {
            return _database.Table<User>().FirstOrDefaultAsync(u => u.Username == username);
        }

        public Task<int> SaveUserAsync(User user)
        {
            return _database.InsertAsync(user);
        }

        public Task<int> UpdateUserAsync(User user)
        {
            return _database.UpdateAsync(user);
        }
    }
}
