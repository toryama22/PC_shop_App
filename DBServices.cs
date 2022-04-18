using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Project_1
{
    class DBServices   //Хранение функционала 
    {
        //Метод для SELECT
        public DataTable getData(string TableName)
        {
            DBconnection db = new DBconnection();
            DataTable dataTable = new DataTable(); //Хранилище для данных

            try
            {
                db.openConnection(); //открываем подключение
                //string cmd = $"SELECT * FROM {TableName} WHERE [Deleted date] IS NULL";  //Посылаем запрос
                string cmd = $"SELECT * FROM {TableName}";  //Посылаем запрос
                SqlCommand sqlComand = new SqlCommand(cmd, db.getConnection());//Преобразуем в SQL команду
                SqlDataAdapter adapter = new SqlDataAdapter();      
                adapter.SelectCommand = sqlComand; //Результат передается в Adapter
                adapter.Fill(dataTable); //Fill Заполняет полученными данными через Adapter
                return dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error ="+ex);//В случае ошибки, вывод информации
                return null;
            }
        
        }

        public DataTable getDataFromEmployeesWithPositions()
        {
            DBconnection db = new DBconnection();
            DataTable dataTable = new DataTable(); //Хранилище для данных

            try
            {
                db.openConnection(); //открываем подключение
                string cmd = "SELECT Employees.Id, Employees.FIO, Employees.[Employee number], Employees.Male, " +
                             "Employees.[Date of BirthDay], Employees.Passport, Employees.Adress, " +
                             "Employees.Phone, Positions.Position, Employees.Salary " +
                             "FROM Positions " +
                             "INNER JOIN Employees ON Employees.Position = Positions.Id";
                SqlCommand sqlComand = new SqlCommand(cmd, db.getConnection());//Преобразуем в SQL команду
                SqlDataAdapter adapter = new SqlDataAdapter();
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




    }
}
