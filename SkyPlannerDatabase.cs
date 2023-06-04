using SkyPlanner.Models;
using SQLite;
using System.Linq.Expressions;

namespace SkyPlanner
{
    public class SkyPlannerDatabase
    {
        private SQLiteAsyncConnection _connection;

        private SQLiteAsyncConnection Database =>
            (_connection ??= new SQLiteAsyncConnection(Constants.DatabasePath, Constants.Flags));

        public SkyPlannerDatabase()
        {

        }

      

       

        //async Task init()
        //{
        //    if (Database is not null)
        //        return;

        //    Database = new SQLiteAsyncConnection(Constants.DatabasePath, Constants.Flags);

        //    await Database.CreateTableAsync<User>();

        //    await Database.CreateTableAsync<Flight>();
        //    await Database.CreateTableAsync<Booking>();
        //}



        private async Task<AsyncTableQuery<TTable>> GetTableAsync<TTable>() where TTable : class, new()
        {
            await Database.CreateTableAsync<TTable>();

            return Database.Table<TTable>();
        }

        private async Task CreateTableIfNotExists<TTable>() where TTable : class, new()
        {
              await Database.CreateTableAsync<User>();
              await Database.CreateTableAsync<Flight>();
              await Database.CreateTableAsync<Booking>();
        }

        public async Task<IEnumerable<TTable>>  GetAllAsync<TTable>() where TTable: class, new()
        {
            var table = await GetTableAsync<TTable>();
            return await table.ToListAsync();
        }

        public async Task<IEnumerable<TTable>> GetFilteredAsync<TTable>(Expression<Func<TTable, bool>> predicate) where TTable : class, new()
        {
            var table = await GetTableAsync<TTable>();
            return await table.Where(predicate).ToListAsync();
        }


        public async Task<bool>  AddItemAsync<TTable>(TTable item) where TTable : class , new()
        {
            await CreateTableIfNotExists<TTable>();
          return  await Database.InsertAsync(item) > 0;

        }

        public async Task<bool> UpdateItemAsync<TTable>(TTable item) where TTable : class, new()
        {
            await CreateTableIfNotExists<TTable>();
            return await Database.UpdateAsync(item) > 0;

        }

        public async Task<bool> DeleteItemAsync<TTable>(TTable item) where TTable : class, new()
        {
            await CreateTableIfNotExists<TTable>();
            return await Database.DeleteAsync(item) > 0;

        }
        public async Task<bool> DeleteItemByKeyAsync<TTable>(object key) where TTable : class, new()
        {
            await CreateTableIfNotExists<TTable>();
            return await Database.DeleteAsync<TTable>(key) >0 ;

        }
    }
}
