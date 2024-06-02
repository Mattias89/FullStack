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

        public AppDbContext(IConfiguration config, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                _connString = config.GetConnectionString("LocalConnection");
            }
            else
            {
                _connString = config.GetConnectionString("DefaultConnection");
            }
        }

        public SqlConnection GetConnection()
        {
            return new SqlConnection(_connString);
        }
    }
}