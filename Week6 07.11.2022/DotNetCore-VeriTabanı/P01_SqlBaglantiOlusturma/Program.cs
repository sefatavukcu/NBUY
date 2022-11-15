using System.Data.SqlClient;

namespace P01_SqlBaglantiOlusturma;
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