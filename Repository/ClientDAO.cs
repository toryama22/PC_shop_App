using Project_1.Models;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
//using Project_1.Models;

namespace Project_1.Repository
{
    class ClientDAO
    {
        DBconnection db = new DBconnection();
        SqlDataAdapter adapter = new SqlDataAdapter();

        public DataTable GetAllClients()
        {
            
            DataTable dataTable = new DataTable(); //Хранилище для данных

            try
            {
                db.openConnection(); //открываем подключение
                string cmd = "SELECT Id, Fio, Phone FROM Klients WHERE Klients.[Delete date] IS NULL";  //Посылаем запрос
                SqlCommand sqlComand = new SqlCommand(cmd, db.getConnection());//Преобразуем в SQL 
                adapter.SelectCommand = sqlComand; //Результат передается в Adapter
                adapter.Fill(dataTable); //Fill Заполняет полученными данными через Adapter
                return dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error =" + ex);//В случае ошибки, вывод информации
                return null;
            }

        }

        public void Сreate(Client client)
        {
            try
            {                
                db.openConnection(); //открываем подключение
                string cmd = $"INSERT INTO Klients (Fio, Phone) VALUES('{client.Fio}', {client.Phone})";  //Посылаем 
                SqlCommand sqlComand = new SqlCommand(cmd, db.getConnection());//Преобразуем в SQL команду
                sqlComand.ExecuteNonQuery();
                MessageBox.Show("Клиент создан!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error =" + ex);//В случае ошибки, вывод информации
            }
        }
        
        public void Update(Client client, int id)
        {
            try
            {                
                db.openConnection(); //открываем подключение
                string cmd = $"UPDATE Klients SET Fio = '{client.Fio}', Phone = {client.Phone} WHERE Klients.Id = {id}";  //Посылаем 
                SqlCommand sqlComand = new SqlCommand(cmd, db.getConnection());//Преобразуем в SQL команду
                sqlComand.ExecuteNonQuery();
                MessageBox.Show("Данные клиента изменены!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error =" + ex);//В случае ошибки, вывод информации
            }
        }
        
        public void Delete(int id)
        {
            try
            {                
                db.openConnection(); //открываем подключение
                string cmd = $"UPDATE Klients SET [Delete date] = GETDATE() WHERE Klients.Id = {id}";  //Посылаем 
                SqlCommand sqlComand = new SqlCommand(cmd, db.getConnection());//Преобразуем в SQL команду
                sqlComand.ExecuteNonQuery();
                MessageBox.Show("Клиент удален!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error =" + ex);//В случае ошибки, вывод информации
            }
        }
    }
}
