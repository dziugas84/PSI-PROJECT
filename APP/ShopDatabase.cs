using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP
{
    public class ShopDatabase
    {
        public static List<Game> GetGames(string TableName)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<Game>("select * from " + TableName, new DynamicParameters());
                return output.ToList();
            }
        }
        public static void SaveGames(string TableName, Game u)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into " + TableName + " values (@Name, @Price, @Year)", u);
            }
        }
        public static void DeleteGames(string TableName, Game u)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("delete from " + TableName + " where name = @name", u);
            }
        }
        public static List<User> GetUser(string TableName)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<User>("select * from " + TableName, new DynamicParameters());
                return output.ToList();
            }
        }
        public static void SaveUser(string TableName, User u)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into " + TableName + " values (@Username, @Password, @Name, @Surname)", u);
            }
        }
        public static List<PaymentClass> GetPayment(string TableName)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<PaymentClass>("select * from " + TableName, new DynamicParameters());
                return output.ToList();
            }
        }
        public static void SavePayment(string TableName, PaymentClass P)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                _ = cnn.Execute("insert into Payment values (@ID, @Amount, @Username)", P);
            }
        }
        public static void SaveBoughtGames(string TableName, int id, string game)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into " + TableName + " values (?ID)", id);
                cnn.Execute("insert into " + TableName + " values (?Name)", game);
            }
        }

        private static string LoadConnectionString(string id = "DataBase")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
