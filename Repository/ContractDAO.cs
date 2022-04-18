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
    class ContractDAO
    {
        DBconnection db = new DBconnection();
        SqlDataAdapter adapter = new SqlDataAdapter();

        public DataTable GetAllContracts()
        {

            DataTable dataTable = new DataTable(); //Хранилище для данных

            try
            {
                db.openConnection(); //открываем подключение
                string cmd = "SELECT Contracts.Id, [Number of Contract], Contracts.Date, Employees.FIO as 'Manager', Suppliers.FIO as 'Supplier' " +
                    "FROM Contracts " +
                    "INNER JOIN Employees ON Employees.Id = Contracts.Menejer " +
                    "INNER JOIN Suppliers ON Suppliers.Id = Contracts.[The supplier] " +
                    "WHERE Contracts.[Delete Data] IS NULL";  //Посылаем запрос
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

        public void Create(Contract contract)
        {
            try
            {
                db.openConnection(); //открываем подключение
                string cmd = $"INSERT INTO Contracts ([Number of Contract], Date, Menejer, [The supplier]) " +
                    $"VALUES ({contract.NumberOfContract}, '{contract.Date}', {contract.Menejer}, {contract.TheSupplier})";  //Посылаем запрос
                SqlCommand sqlComand = new SqlCommand(cmd, db.getConnection());//Преобразуем в SQL 
                sqlComand.ExecuteNonQuery();
                MessageBox.Show("Контракт создан!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error =" + ex);//В случае ошибки, вывод информации
            }

        }
        
        public void Update(Contract contract, int id)
        {
            try
            {
                db.openConnection(); //открываем подключение
                string cmd = $"UPDATE Contracts " +
                    $"SET [Number of Contract] = {contract.NumberOfContract}, Date = '{contract.Date}', " +
                    $"Menejer = {contract.Menejer}, [The supplier] = {contract.TheSupplier} " +
                    $"WHERE Contracts.Id = {id}";  //Посылаем запрос
                SqlCommand sqlComand = new SqlCommand(cmd, db.getConnection());//Преобразуем в SQL 
                sqlComand.ExecuteNonQuery();
                MessageBox.Show("Данные конракта изменены!");
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
                string cmd = $"UPDATE Contracts SET [Delete Data] = GETDATE() WHERE Contracts.Id = {id}";  //Посылаем запрос
                SqlCommand sqlComand = new SqlCommand(cmd, db.getConnection());//Преобразуем в SQL 
                sqlComand.ExecuteNonQuery();
                MessageBox.Show("Контракт удален!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error =" + ex);//В случае ошибки, вывод информации
            }

        }

        public Dictionary<int, string> GetManagers()
        {
            Dictionary<int, string> listOfManagers = new Dictionary<int, string>();

            try
            {
                db.openConnection(); //открываем подключение
                string cmd = "SELECT Employees.Id, FIO FROM Employees " +
                    "INNER JOIN Positions ON Positions.Id = Employees.Position " +
                    "WHERE Positions.Position = 'Menejer' AND Employees.[Delete data] IS NULL";  //Посылаем запрос
                SqlCommand sqlComand = new SqlCommand(cmd, db.getConnection());//Преобразуем в SQL 
                using (SqlDataReader reader = sqlComand.ExecuteReader())
                {

                    while (reader.Read())
                    {
                        int employeeId = reader.GetInt32(0);
                        string employeeFIO = reader.GetString(1);
                        listOfManagers.Add(employeeId, employeeFIO);
                    }

                    reader.Close();
                }

                return listOfManagers;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error =" + ex);//В случае ошибки, вывод информации
                return null;
            }
        }
        
        public Dictionary<int, string> GetSuppliers()
        {
            Dictionary<int, string> listOfSuppliers = new Dictionary<int, string>();

            try
            {
                db.openConnection(); //открываем подключение
                string cmd = "SELECT Suppliers.Id, FIO FROM Suppliers WHERE [Delete data] IS NULL";  //Посылаем запрос
                SqlCommand sqlComand = new SqlCommand(cmd, db.getConnection());//Преобразуем в SQL 
                using (SqlDataReader reader = sqlComand.ExecuteReader())
                {

                    while (reader.Read())
                    {
                        int supplierId = reader.GetInt32(0);
                        string supplierFIO = reader.GetString(1);
                        listOfSuppliers.Add(supplierId, supplierFIO);
                    }

                    reader.Close();
                }

                return listOfSuppliers;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error =" + ex);//В случае ошибки, вывод информации
                return null;
            }
        }


    }
}
