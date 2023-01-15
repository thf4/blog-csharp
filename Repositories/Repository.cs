using Blog.Models;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;

namespace Blog.Repositories

{
  public class Repository<TModel> where TModel : class
  {
    private SqlConnection _connection;

    public Repository(SqlConnection connection) => this._connection = connection;

    public void Create(TModel model) => _connection.Insert<TModel>(model);

    public IEnumerable<TModel> Read() => _connection.GetAll<TModel>();

    public TModel Get(int Id) => _connection.Get<TModel>(Id);

    public void Update(TModel model) => _connection.Update<TModel>(model);


    public void Delete(int id)
    {
      var model = this.Get(id);
      _connection.Delete<TModel>(model);
    }
  }
}