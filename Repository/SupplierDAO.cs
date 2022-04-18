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
    class SupplierDAO
    {
        DBconnection db = new DBconnection();
        SqlDataAdapter adapter = new SqlDataAdapter();

        public DataTable GetAllSuppliers()
        {

            DataTable dataTable = new DataTable(); //Хранилище для данных

            try
            {
                db.openConnection(); //открываем подключение
                string cmd = $"SELECT Id, FIO, INN, Adress, Phone FROM Suppliers WHERE [Delete data] IS NULL";  //Посылаем запрос
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

        public void create(Supplier supplier)
        {
            try
            {
                db.openConnection(); //открываем подключение
                string cmd = $"INSERT INTO Suppliers (FIO, INN, Adress, Phone) " +
                    $"VALUES('{supplier.FIO}', {supplier.INN}, '{supplier.Adress}', {supplier.Phone})";  //Посылаем 
                SqlCommand sqlComand = new SqlCommand(cmd, db.getConnection());//Преобразуем в SQL команду
                sqlComand.ExecuteNonQuery();
                MessageBox.Show("Поставщик создан!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error =" + ex);//В случае ошибки, вывод информации
            }
        }

        public void update(Supplier supplier, int Id)
        {
            try
            {
                db.openConnection(); //открываем подключение
                string cmd = "UPDATE Suppliers " +
                    $"SET FIO = '{supplier.FIO}', INN = {supplier.INN}, Adress = '{supplier.Adress}', Phone = {supplier.Phone} " +
                    $"WHERE Suppliers.Id = {Id}";  //Посылаем 
                SqlCommand sqlComand = new SqlCommand(cmd, db.getConnection());//Преобразуем в SQL команду
                sqlComand.ExecuteNonQuery();
                MessageBox.Show("Данные поставщика изменены!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error =" + ex);//В случае ошибки, вывод информации
            }
        }

        public void delete(int Id)
        {
            try
            {
                db.openConnection(); //открываем подключение
                string cmd = "UPDATE Suppliers " +
                    $"SET [Delete data] = GETDATE() " +
                    $"WHERE Suppliers.Id = {Id}";  //Посылаем 
                SqlCommand sqlComand = new SqlCommand(cmd, db.getConnection());//Преобразуем в SQL команду
                sqlComand.ExecuteNonQuery();
                MessageBox.Show("Поставщик удален!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error =" + ex);//В случае ошибки, вывод информации
            }
        }
    }
}
