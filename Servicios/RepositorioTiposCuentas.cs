using Dapper;
using ManejoPresupuesto.Models;
using Microsoft.Data.SqlClient;

namespace ManejoPresupuesto.Servicios;

public interface IRepositorioTiposCuentas
{
    void Crear(TipoCuenta tipoCuenta);
}

public class RepositorioTiposCuentas : IRepositorioTiposCuentas
{
    private readonly string connectionString;
    
    public RepositorioTiposCuentas(IConfiguration configuration)
    {
        connectionString = configuration.GetConnectionString("DefaultConnection");
    }

    public void Crear(TipoCuenta tipoCuenta) //Metodo para poder crear un Tipo Cuenta en la base de datos
    {
        using var connection = new SqlConnection(connectionString);
        var id = connection.QuerySingle<int>($@"INSERT INTO TiposCuentas (nombre, usuario_id, orden)
                                                    VALUES (@nombre, @usuario_id, 0);
                                                    SELECT SCOPE_IDENTITY();", tipoCuenta);
        tipoCuenta.id_tipo_cuenta = id;
    }
}
