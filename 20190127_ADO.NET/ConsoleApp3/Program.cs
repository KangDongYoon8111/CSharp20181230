using System;
using System.Data;
using Oracle.ManagedDataAccess.Client;

class Sample
{
    public static void Main()
    {
        String connString = "Data Source=topcredu;User Id = scott; Password = tiger";
        String sqlSelect = "SELECT * FROM emp";

        OracleConnection conn = new OracleConnection(connString);
        conn.Open();

        OracleDataAdapter da = new OracleDataAdapter(sqlSelect, conn);
        DataSet ds = new DataSet("EMPLOYEES");

        OracleCommandBuilder cb = new OracleCommandBuilder(da);
        da.Fill(ds, "EMP");

        Console.WriteLine("FILL 건수 : " + ds.Tables["EMP"].Rows.Count);

        OracleTransaction tran = conn.BeginTransaction();

        da.DeleteCommand = cb.GetDeleteCommand();
        da.InsertCommand = cb.GetInsertCommand();
        da.UpdateCommand = cb.GetUpdateCommand();

        da.DeleteCommand.Transaction = tran;
        da.InsertCommand.Transaction = tran;
        da.UpdateCommand.Transaction = tran;

        ds.Tables["EMP"].Rows[0]["ename"] = "0길동";
        ds.Tables["EMP"].Rows[1]["ename"] = "1길동";

        Console.WriteLine("삭제 대상 : " + ds.Tables["EMP"].Rows[9]["ename"]);
        ds.Tables["EMP"].Rows[9].Delete();

        DataRow r = ds.Tables["EMP"].NewRow();
        r[0] = 1119; r[1] = "JCLEE";
        ds.Tables["EMP"].Rows.Add(r);

        try
        {
            ds.AcceptChanges();

            Console.WriteLine(ds.GetXml());

            da.Update(ds, "EMP");

            tran.Commit();
            Console.WriteLine("Commit OK~");
        }

        catch (Exception e)
        {
            Console.WriteLine(e);
            tran.Rollback();
        }
        finally
        {
            conn.Close();
        }
    }
}