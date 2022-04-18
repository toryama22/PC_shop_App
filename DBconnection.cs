using System.Data.SqlClient;

namespace Project_1
{
    class DBconnection
    {
        static string connString = "Server=.;Database=Project_1_Sp;Trusted_Connection=True;";
        //Оставь для меня эту строку
        SqlConnection sqlConnection = new SqlConnection(connString);


        public void openConnection()    // Для подключения к Бд
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
                sqlConnection.Open();        
        }

        public void closeConne0tion() // Для отключения от БД
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
                sqlConnection.Close();
        }

        public SqlConnection getConnection()  //Запрос на состояние подключения к БД
        {
            return sqlConnection;
        }
    }
}
