using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Db
{

    public static string connStr =
            @"Server=(localdb)\MSSQLLocalDB;Database=toymart;Trusted_Connection=True;TrustServerCertificate=True;";

    public static DataTable Query(string sql, params SqlParameter[] p)
    {
        using (var conn = new SqlConnection(connStr))
        using (var cmd = new SqlCommand(sql, conn))
        {
            cmd.Parameters.AddRange(p);
            var dt = new DataTable();
            new SqlDataAdapter(cmd).Fill(dt);
            return dt;
        }
    }

    public static int Execute(string sql, params SqlParameter[] p)
    {
        using (var conn = new SqlConnection(connStr))
        using (var cmd = new SqlCommand(sql, conn))
        {
            cmd.Parameters.AddRange(p);
            conn.Open();
            return cmd.ExecuteNonQuery();
        }
    }
}
