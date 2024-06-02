using Microsoft.Data.SqlClient;

namespace MattiasHandel.Extras
{
    public interface IDBContext
    {
        SqlConnection GetConnection();
    }

    public class AppDbContext : IDBContext
    {
        private readonly string? _connString;

        public AppDbContext(IConfiguration config)
        {
            _connString = config.GetConnectionString("LocalConnection");
        }

        public SqlConnection GetConnection()
        {
            return new SqlConnection(_connString);
        }
    }
}