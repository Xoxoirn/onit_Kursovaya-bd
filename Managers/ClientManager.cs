using Kursovaya_ONIT_3.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Kursovaya_ONIT_3.Managers
{
    class ClientManager
    {
        //ссылка на объект, визуализирующий таблицу на интерфейсе.
        DataGrid dataGrid;
        DataSet ds = new DataSet("Client");
        //строка подключения
        string connectString = "Integrated Security = SSPI;" +
        "Initial Catalog=BeautySaloon;" +
        "Data Source=(localdb)\\MSSQLLocalDB";
        //адаптер данных
        SqlDataAdapter dAdapt;
        public ClientManager(DataGrid tableGrid)
        {
            dataGrid = tableGrid;
            //создаем новый объект SqlDataAdapter
            dAdapt = new SqlDataAdapter("", connectString);
        }

        public void GetFullTable()
        {
            //задаем команду для выбора всей таблицы.
            dAdapt.SelectCommand.CommandText = "SELECT * FROM Client";
            GetTable();
        }
        public void GetTable()
        {
            ds.Clear();
            try
            {
                //наполняем DataSet запрашиваемой таблицей
                dAdapt.Fill(ds, "Client");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButton.OK,
                MessageBoxImage.Error);
                return;
            }
            //передаем таблицу в DataGrid
            dataGrid.ItemsSource = ds.Tables[0].DefaultView;
        }

        public void AddClient(Client client)
        {
            //создаем текст команды с параметрами
            string cmd = "INSERT INTO Client VALUES (@fio, @telnum)";
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                //создаем команду, используя ее текст и объект подключения
                SqlCommand InsertCmd = new SqlCommand(cmd, connection);
                //вставляем в команду на места параметров фактические значения
                InsertCmd.Parameters.Add("@fio", SqlDbType.NVarChar);
                InsertCmd.Parameters["@fio"].Value = client.FIO;
                InsertCmd.Parameters.Add("@telnum", SqlDbType.VarChar);
                InsertCmd.Parameters["@telnum"].Value = client.TelNum;

                try
                {
                    //попытка отправить запрос на севрер
                    connection.Open();
                    InsertCmd.ExecuteScalar();
                    GetTable();
                }
                catch (Exception ex)
                {
                    // сообщение о неудаче
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public void DeleteSelectedRow(string TelNum)
        {
   
            //создаем текст запроса на удаление
            string cmd = "DELETE FROM Client WHERE [Номер телефона] = " + "'" + TelNum + "'";
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                //создаем команду
                SqlCommand DelCmd = new SqlCommand(cmd, connection);
                try
                {
                    connection.Open();
                    DelCmd.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка удаления!", MessageBoxButton.OK,
                    MessageBoxImage.Error);
                }
                GetFullTable();
            }
        }
        public void SearchClient(string FIO)
        {

            //создаем текст запроса на удаление
            string cmd = "SELECT * FROM Client WHERE [ФИО] = " + "N'" + FIO + "'";
            dAdapt.SelectCommand.CommandText = cmd;
            ds.Clear();
            try
            {
                dAdapt.Fill(ds, "client");
                if (ds.Tables[0].DefaultView.Count == 0)
                    MessageBox.Show("Пользователь не найден!");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Пользователь не найден!", MessageBoxButton.OK,
                MessageBoxImage.Error);
            }
            dataGrid.ItemsSource = ds.Tables[0].DefaultView;
        }

        public List<Client> ComboBox1()
        {
            string cmd = "SELECT Client.[ФИО], Client.[Номер телефона] FROM Client";
            dAdapt.SelectCommand.CommandText = cmd;
            ds.Clear();
            try
            {
                dAdapt.Fill(ds, "client");
                if (ds.Tables[0].DefaultView.Count == 0)
                    MessageBox.Show("Пользователь не найден!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Пользователь не найден!", MessageBoxButton.OK,
                MessageBoxImage.Error);
            }
            var result = new List<Client>();
            for (int i = 0; i < ds.Tables[0].DefaultView.Count; i++)
            {
                result.Add(new Client(ds.Tables[0].DefaultView.Table.Rows[i].ItemArray[0].ToString(), ds.Tables[0].DefaultView.Table.Rows[i].ItemArray[1].ToString()));
            }

            return (result);
        }

        
    }
}


