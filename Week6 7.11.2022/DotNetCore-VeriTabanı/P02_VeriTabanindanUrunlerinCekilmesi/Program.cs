using System.Data.SqlClient;

namespace P02_VeriTabanindanUrunlerinCekilmesi;
class Program
{
    static void Main(string[] args)
    {
        GetSqlConnection();
        
    }
    static void GetSqlConnection()
    {
        //1.Adım = Connection string oluşturmak   @:kaçış işareti 
        string connectionString = @"Server=DESKTOP-OFVK2FD\SQLEXPRESS; Database=Northwind; User Id=sa; Password=123";
        using (var connection = new SqlConnection(connectionString))
        {
            //connection nesnesi sadece bu scope içinde yaşayıp bu bittiğinde bellekten kaldırılmış olacak.
            try
            {
                connection.Open();
                Console.WriteLine("Bağlantı Sağlandı");
                string queryString = "select * from Products ";
                SqlCommand sqlCommand = new SqlCommand(queryString, connection);  // listelenmesi istenen bilgiler ve bağlanacağı yer
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                int sayac = 1;
                while (sqlDataReader.Read())
                {
                    System.Console.WriteLine($"Sıra: {sayac} - Name: {sqlDataReader[1]} - Price: {sqlDataReader[5]}");
                    sayac++;
                }
                sqlDataReader.Close();
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}