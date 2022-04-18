using Project_1.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_1.Repository
{
    class EmployeeDAO
    {

        DBconnection db = new DBconnection();
        SqlDataAdapter adapter = new SqlDataAdapter();

        public DataTable GetAllEmployees()
        {

            DataTable dataTable = new DataTable(); //Хранилище для данных

            try
            {
                db.openConnection(); //открываем подключение
                string cmd = "SELECT Employees.Id, FIO, [Employee number], Male, [Date of birthday], Passport, " +
                    "Adress, Phone, Positions.Position, Password, Salary FROM Employees " +
                    "INNER JOIN Positions ON Positions.Id = Employees.Position " +
                    "WHERE Employees.[Delete data] IS NULL";  //Посылаем запрос
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

        public void Сreate(Employee employee)
        {
            try
            {
                
                db.openConnection(); //открываем 
                string cmd = "INSERT INTO Employees (FIO, [Employee number], Male, [Date of BirthDay], Passport, Adress, Phone, Position, Password, Salary) " +
                    $"VALUES('{employee.FIO}', '{employee.EmployeeNumber}', '{employee.Male}', '{employee.DateOfBirthday:yyyy-MM-dd}', " +
                    $"{employee.Passport}, '{employee.Adress}', {employee.Phone}, {employee.Position}, {employee.Password}, {employee.Salary})";  //Посылаем 

                SqlCommand sqlComand = new SqlCommand(cmd, db.getConnection());//Преобразуем в SQL команду
                sqlComand.ExecuteNonQuery();
                MessageBox.Show("Сотрудник создан!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error =" + ex);//В случае ошибки, вывод информации
            }
        }

        public void Update(Employee employee, int Id)
        {
            try
            {

                db.openConnection(); //открываем 
                string cmd = "UPDATE Employees " +
                    $"SET FIO = '{employee.FIO}', [Employee number] = {employee.EmployeeNumber}, Male = '{employee.Male}', " +
                    $"[Date of BirthDay] = '{employee.DateOfBirthday}', Passport = {employee.Passport}, " +
                    $"Adress = '{employee.Adress}', Phone = {employee.Phone}, Position = {employee.Position}, " +
                    $"Password = '{employee.Password}', Salary = {employee.Salary} " +
                    $"WHERE Employees.Id = {Id}";

                SqlCommand sqlComand = new SqlCommand(cmd, db.getConnection());//Преобразуем в SQL команду
                sqlComand.ExecuteNonQuery();
                MessageBox.Show("Данные сотрудника изменены!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error =" + ex);//В случае ошибки, вывод информации
            }
        }

        public void Delete(int Id)
        {
            try
            {

                db.openConnection(); //открываем 
                string cmd = "UPDATE Employees " +
                    "SET [Delete data] = GETDATE() " +
                    $"WHERE Employees.Id = {Id}";

                SqlCommand sqlComand = new SqlCommand(cmd, db.getConnection());//Преобразуем в SQL команду
                sqlComand.ExecuteNonQuery();
                MessageBox.Show("Сотрудник удален!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error =" + ex);//В случае ошибки, вывод информации
            }
        }

        public List<String> GetPositions()
        {
            List<String> listOfPositions = new List<string>();

            try
            {
                db.openConnection(); //открываем подключение
                string cmd = "SELECT Position FROM Positions";  //Посылаем запрос
                SqlCommand sqlComand = new SqlCommand(cmd, db.getConnection());//Преобразуем в SQL 
                using(SqlDataReader reader = sqlComand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        listOfPositions.Add(reader.GetString(0));
                    }

                    reader.Close();
                }
                /*string positionsAsString = "";
                foreach (var position in listOfPositions)
                {
                    positionsAsString = positionsAsString + position + " ";
                }*/
                return listOfPositions;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error =" + ex);//В случае ошибки, вывод информации
                return null;
            }
        }
    }
}

