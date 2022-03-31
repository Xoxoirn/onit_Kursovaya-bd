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
    class LogOfRecordsManager
    {
        //ссылка на объект, визуализирующий таблицу на интерфейсе.
        DataGrid dataGrid;
        DataSet ds = new DataSet("LogOfRecords");
        //строка подключения
        string connectString = "Integrated Security = SSPI;" +
        "Initial Catalog=BeautySaloon;" +
        "Data Source=(localdb)\\MSSQLLocalDB";
        //адаптер данных
        SqlDataAdapter dAdapt;
        public LogOfRecordsManager(DataGrid tableGrid)
        {
            dataGrid = tableGrid;
            //создаем новый объект SqlDataAdapter
            dAdapt = new SqlDataAdapter("", connectString);
        }

        public void GetFullTable()
        {
            //задаем команду для выбора всей таблицы.
            dAdapt.SelectCommand.CommandText = "SELECT * FROM LogOfRecords";
            ds.Tables.Clear();
            GetTable();
        }
        public void GetTable()
        {
            ds.Clear();
            try
            {
                //наполняем DataSet запрашиваемой таблицей
                dAdapt.Fill(ds, "LogOfRecords");
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

        public void GetClientsToo()
        {
            string cmd = "SELECT L.N AS [Номер записи], L.[Дата и время записи] AS[Дата и время записи], " +
            "L.[Телефон клиента] AS [Телефон клиента], C.[ФИО] AS [ФИО клиента] " +
            "FROM LogOfRecords AS L " +
            "LEFT JOIN Client AS C ON L.[Телефон клиента] = C.[Номер телефона]";
            dAdapt.SelectCommand.CommandText = cmd;
            ds.Tables.Clear();
            ds.Clear();
            try
            {
                dAdapt.Fill(ds, "client");
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButton.OK,
                MessageBoxImage.Error);
            }
            dataGrid.ItemsSource = ds.Tables[0].DefaultView;

        }

        public void GetAllInf()
        {
            string cmd = "SELECT L.N AS [Номер записи], L.[Дата и время записи] AS[Дата и время записи], " +
            "L.[Телефон клиента] AS [Телефон клиента], C.[ФИО] AS [ФИО клиента], " +
            "L.[Название процедуры] AS [Название процедуры], T.[Стоимость процедуры] AS [Стоимость процедуры], T.[Длительность] AS [Длительность], T.[Имя мастера] AS [Имя мастера] " +
            "FROM LogOfRecords AS L " +
            "LEFT JOIN Treatment AS T ON L.[Название процедуры] = T.[Название процедуры] " +
            "LEFT JOIN Client AS C ON L.[Телефон клиента] = C.[Номер телефона] ";
            dAdapt.SelectCommand.CommandText = cmd;
            ds.Tables.Clear();
            ds.Clear();
            try
            {
                dAdapt.Fill(ds, "client");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButton.OK,
                MessageBoxImage.Error);
            }
            dataGrid.ItemsSource = ds.Tables[0].DefaultView;

        }

        public void GetTreatmentsToo()
        {
            string cmd = "SELECT L.N AS [Номер записи], L.[Дата и время записи] AS[Дата и время записи], " +
            "L.[Телефон клиента] AS [Телефон клиента], " +
            "L.[Название процедуры] AS [Название процедуры], T.[Стоимость процедуры] AS [Стоимость процедуры], T.[Длительность] AS [Длительность], T.[Имя мастера] AS [Имя мастера] " +
            "FROM LogOfRecords AS L " +
            "LEFT JOIN Treatment AS T ON L.[Название процедуры] = T.[Название процедуры]";
            dAdapt.SelectCommand.CommandText = cmd;
            ds.Tables.Clear();
            ds.Clear();
            try
            {
                dAdapt.Fill(ds, "client");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButton.OK,
                MessageBoxImage.Error);
            }
            dataGrid.ItemsSource = ds.Tables[0].DefaultView;

        }

        public void AddLogOfRecords(LogOfRecords logOfRecord )
        {
            //создаем текст команды с параметрами

            string cmd = "INSERT INTO LogOfRecords VALUES (@N, @Telephone, @Date, @NameOfT)";
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                //создаем команду, используя ее текст и объект подключения
                SqlCommand InsertCmd = new SqlCommand(cmd, connection);
                //вставляем в команду на места параметров фактические значения
                InsertCmd.Parameters.Add("@N", SqlDbType.Int);
                InsertCmd.Parameters["@N"].Value = logOfRecord.N;
                InsertCmd.Parameters.Add("@Telephone", SqlDbType.NVarChar);
                InsertCmd.Parameters["@Telephone"].Value = logOfRecord.Telephone;
                InsertCmd.Parameters.Add("@Date", SqlDbType.DateTime);
                InsertCmd.Parameters["@Date"].Value = logOfRecord.DateAndTime;
                
                InsertCmd.Parameters.Add("@NameOfT", SqlDbType.NVarChar);
                InsertCmd.Parameters["@NameOfT"].Value = logOfRecord.NameOfT;


                try
                {
                    //попытка отправить запрос на севрер
                    connection.Open();
                    InsertCmd.ExecuteScalar();
                    
                }
                catch (Exception ex)
                {
                    // сообщение о неудаче
                    MessageBox.Show(ex.Message);
                }
                GetFullTable();
            }
        }

        public void FillUpCLients()
        {
            string cmd;
        }

        public int NewNumber()
        {
            string cmd = "SELECT MAX(N) as LastNum FROM LogOfRecords";
            //в dAdapt засовываем наш sql запрос
            dAdapt.SelectCommand.CommandText = cmd;
            ds.Clear();
            try
            {
                dAdapt.Fill(ds, "LogOfRecords"); //выполнение запроса
            }
            catch(Exception sex)
            {
                return (0);
                
            }
            
                 // результат запроса
            try
            {
                var tmp = Convert.ToInt32(ds.Tables[0].DefaultView.Table.Rows[0].ItemArray[4]);
                return tmp+1;
            }
            catch
            {
                return 0;
            }
        }
        public void DeleteSelectedRow(int N)
        {

            //создаем текст запроса на удаление
            string cmd = "DELETE FROM LogOfRecords WHERE [N] = " + Convert.ToString(N);
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

    }
}
