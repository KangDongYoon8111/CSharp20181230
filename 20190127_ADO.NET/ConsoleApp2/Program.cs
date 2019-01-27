using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;

namespace ConsoleApplication20
{
    class Program
    {
        static void Main(string[] args)
        {
            OleDbConnection myOleDbConnection = new OleDbConnection("Provider=ORAOLEDB.ORACLE;data source=topcredu;User ID=scott;Password=tiger");
            OleDbCommand myOleDbCommand = myOleDbConnection.CreateCommand();

            myOleDbCommand.CommandType = CommandType.TableDirect;

            myOleDbCommand.CommandText = "EMP"; //테이블명이다.

            myOleDbConnection.Open();

            OleDbDataReader myOleDbDataReader = myOleDbCommand.ExecuteReader();

            for(int count =1;count <= 2; count++)
            {
                myOleDbDataReader.Read();
                Console.WriteLine("myOleDbDataReader[\" EMPNO\"] = " + myOleDbDataReader["EMPNO"]);
                Console.WriteLine("myOleDbDataReader[\" ENAME\"] = " + myOleDbDataReader["ENAME"]);
                Console.WriteLine("myOleDbDataReader[\" SAL\"] = " + myOleDbDataReader["SAL"]);
            }
            myOleDbDataReader.Close();
            myOleDbConnection.Close();
        }
    }
}