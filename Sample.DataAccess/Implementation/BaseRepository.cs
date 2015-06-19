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
    public abstract class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {
        private string _connString =
            "mongodb://admin:admin@ds041651.mongolab.com:41651/sample_enterprise_architecture";

        private readonly IMongoCollection<T> _collection;
        
        protected BaseRepository(string connString)
        {
            var client = new MongoClient(_connString);

            var db = client.GetDatabase("test");

            _collection = db.GetCollection<T>(typeof(T).Name);
        }
        
        public virtual T GetById(long id)
        {

            var filter = Builders<T>.Filter.Eq("_id", id);

            var result  = _collection.Find(filter).FirstOrDefaultAsync();

            var a = result.Result;

            return a;
        }

        public virtual ICollection<T> GetAll(Func<T, bool> expression = null)
        {
            throw new NotImplementedException();
        }

        public virtual T Add(T entity)
        {
            _collection.InsertOneAsync(entity);

            return entity;
        }

        public virtual bool Update(T entity)
        {
            throw new NotImplementedException();
        }

        public virtual bool Delete(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
