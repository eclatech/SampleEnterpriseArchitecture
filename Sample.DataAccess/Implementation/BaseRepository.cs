using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using Sample.DataAccess.Interfaces;
using Sample.Objects;

namespace Sample.DataAccess.Implementation
{
    public class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {
        private IMongoDatabase _db;

        private IMongoCollection<T> _collection;

        public BaseRepository(string connStr)
        {
            var client = new MongoClient(connStr);

            _db = client.GetDatabase("test");

            _collection = _db.GetCollection<T>(typeof(T).Name);
        }

        public ICollection<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public T GetById(long id)
        {

            var filter = Builders<T>.Filter.Eq("_id", id);

            var result  = _collection.Find(filter).FirstOrDefaultAsync();

            var a = result.Result;

            return a;
        }
    }
}
