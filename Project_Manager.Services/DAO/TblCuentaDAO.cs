using Project_Manager.Services.BO;
using System.Data;
using System.Data.SqlClient;

namespace Project_Manager.Services.DAO
{
    public class TblCuentaDAO
{
	SqlConnection con = new SqlConnection();
	SqlCommand cmd = new SqlCommand();
	Conexion con2 = new Conexion();
	string sql;

		public int Crear(object obj)
	{

		TblCuentaBO datos = (TblCuentaBO)obj;
		cmd.Connection = con2.establecerconexion();
		con2.AbrirConexion();
		sql = "Insert into TblCuenta(CorreoCuenta ,ContraCuenta)"+
		"Values(@CorreoCuenta ,@ContraCuenta)";
		cmd.Parameters.Add("@IDCuenta", SqlDbType.Int);
		cmd.Parameters.Add("@CorreoCuenta", SqlDbType.VarChar);
		cmd.Parameters.Add("@ContraCuenta", SqlDbType.VarChar);

		cmd.Parameters["@IDCuenta"].Value = datos.IDCuenta;
		cmd.Parameters["@CorreoCuenta"].Value = datos.CorreoCuenta;
		cmd.Parameters["@ContraCuenta"].Value = datos.ContraCuenta;
		cmd.CommandText = sql;


		int i = cmd.ExecuteNonQuery();
		cmd.Parameters.Clear();

		if(i <= 0)
		{
			return 0;
		}
		return 1;
	}


		public int Modificar(object obj)
	{

		TblCuentaBO datos = (TblCuentaBO)obj;
		cmd.Connection = con2.establecerconexion();
		con2.AbrirConexion();
		sql = "update TblCuenta"+
		" set "+
		"CorreoCuenta = @CorreoCuenta,"+
		"ContraCuenta = @ContraCuenta"+
		" where IDCuenta = @IDCuenta";

		cmd.Parameters.Add("@IDCuenta", SqlDbType.Int);
		cmd.Parameters.Add("@CorreoCuenta", SqlDbType.VarChar);
		cmd.Parameters.Add("@ContraCuenta", SqlDbType.VarChar);

		cmd.Parameters["@IDCuenta"].Value = datos.IDCuenta;
		cmd.Parameters["@CorreoCuenta"].Value = datos.CorreoCuenta;
		cmd.Parameters["@ContraCuenta"].Value = datos.ContraCuenta;

		cmd.CommandText = sql;

		int i = cmd.ExecuteNonQuery();
		cmd.Parameters.Clear();

		if(i <= 0)
		{
			return 0;
		}
		return 1;
	}


		public int Eliminar(object obj)
	{
		TblCuentaBO datos = (TblCuentaBO)obj;
		cmd.Connection = con2.establecerconexion();
		con2.AbrirConexion();
		sql = "DELETE FROM TblCuenta where IDCuenta = @IDCuenta";
		cmd.Parameters.Add("@IDCuenta", SqlDbType.Int);
		cmd.Parameters["@IDCuenta"].Value = datos.IDCuenta;
		cmd.CommandText = sql;

		int i = cmd.ExecuteNonQuery();
		cmd.Parameters.Clear();

		if(i <= 0)
		{
			return 0;
		}
		return 1;
	}


		public DataSet devuelveAlumno(object obj)
	{
		string cadenaWhere = "";
		bool edo = false;
		TblCuentaBO data = (TblCuentaBO)obj;
		SqlCommand cmd = new SqlCommand();
		DataSet ds = new DataSet();
		SqlDataAdapter da = new SqlDataAdapter();
		cmd.Connection = con2.establecerconexion();
		con2.AbrirConexion();

		if (data.IDCuenta > 0)
		{
			cadenaWhere = cadenaWhere + " IDCuenta = @IDCuenta and";
			cmd.Parameters.Add("@IDCuenta", SqlDbType.Int);
			cmd.Parameters["@IDCuenta"].Value = data.IDCuenta;
			edo = true;
		}
		if (data.CorreoCuenta !=null)
		{
			cadenaWhere = cadenaWhere + " CorreoCuenta = @CorreoCuenta and";
			cmd.Parameters.Add("@CorreoCuenta", SqlDbType.VarChar);
			cmd.Parameters["@CorreoCuenta"].Value = data.CorreoCuenta;
			edo = true;
		}
		if (data.ContraCuenta !=null)
		{
			cadenaWhere = cadenaWhere + " ContraCuenta = @ContraCuenta and";
			cmd.Parameters.Add("@ContraCuenta", SqlDbType.VarChar);
			cmd.Parameters["@ContraCuenta"].Value = data.ContraCuenta;
			edo = true;
		}

		if (edo == true)
		{
			 cadenaWhere = " WHERE " +cadenaWhere.Remove(cadenaWhere.Length - 3, 3);
		}
		sql = "SELECT * FROM TblCuenta"  + cadenaWhere;
		cmd.CommandText = sql;
		da.SelectCommand = cmd;
		da.Fill(ds);
		con2.CerrarConexion();
		return ds;
	}


		public DataTable ListarTabla()
	{
		sql = "Select * from TblCuenta";
		SqlDataAdapter da = new SqlDataAdapter(sql, con2.establecerconexion());
		DataTable tabla = new DataTable();
		da.Fill(tabla);
		return tabla;
	}

	}
}