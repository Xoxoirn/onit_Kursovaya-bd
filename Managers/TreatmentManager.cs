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
    class TreatmentManager
    {
        //ссылка на объект, визуализирующий таблицу на интерфейсе.
        DataGrid dataGrid;
        DataSet ds = new DataSet("Treatment");
        //строка подключения
        string connectString = "Integrated Security = SSPI;" +
        "Initial Catalog=BeautySaloon;" +
        "Data Source=(localdb)\\MSSQLLocalDB";
        //адаптер данных
        SqlDataAdapter dAdapt;
        public TreatmentManager(DataGrid tableGrid)
        {
            dataGrid = tableGrid;
            //создаем новый объект SqlDataAdapter
            dAdapt = new SqlDataAdapter("", connectString);
        }

        public void GetFullTable()
        {
            //задаем команду для выбора всей таблицы.
            dAdapt.SelectCommand.CommandText = "SELECT * FROM Treatment";
            GetTable();
        }
        public void GetTable()
        {
            ds.Clear();
            try
            {
                //наполняем DataSet запрашиваемой таблицей
                dAdapt.Fill(ds, "Treatment");
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

        public void AddTreatment(Treatment treatment)
        {
            //создаем текст команды с параметрами
            string cmd = "INSERT INTO Treatment VALUES (@NameOfProcedure, @Cost, @Duration, @Master)";
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                //создаем команду, используя ее текст и объект подключения
                SqlCommand InsertCmd = new SqlCommand(cmd, connection);
                //вставляем в команду на места параметров фактические значения
                InsertCmd.Parameters.Add("@NameOfProcedure", SqlDbType.NVarChar);
                InsertCmd.Parameters["@NameOfProcedure"].Value = treatment.NameOfProcedure;
                InsertCmd.Parameters.Add("@Cost", SqlDbType.Int);
                InsertCmd.Parameters["@Cost"].Value = treatment.Cost;
                InsertCmd.Parameters.Add("@Duration", SqlDbType.Real);
                InsertCmd.Parameters["@Duration"].Value = treatment.Duration;
                InsertCmd.Parameters.Add("@Master", SqlDbType.NVarChar);
                InsertCmd.Parameters["@Master"].Value = treatment.Master;


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

        public void DeleteSelectedRow(string NameOfProcedure)
        {

            //создаем текст запроса на удаление
            string cmd = "DELETE FROM Treatment WHERE [Название процедуры] = " + "N'" + NameOfProcedure + "'";
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
        public string Convert1 (double Num)
        {
            string _Num = Convert.ToString(Num);
            _Num = _Num.Replace(",", ".");
            return (_Num);
        }
        public void SearchTreatment(int CostMin = 0, double DurationMin = 0, int CostMax = Int32.MaxValue, double DurationMax = Double.MaxValue)
        {
            string cmd = "SELECT * FROM Treatment WHERE [Длительность]  >= " + Convert1(DurationMin) + "AND [Длительность]  <= " + Convert1(DurationMax) +
                "AND [Стоимость процедуры]  >= " + Convert.ToString(CostMin) + "AND [Стоимость процедуры]  <= " + Convert.ToString(CostMax);
            dAdapt.SelectCommand.CommandText = cmd;
            ds.Clear();
            try
            {
                dAdapt.Fill(ds, "treatment");
                if (ds.Tables[0].DefaultView.Count == 0)
                    MessageBox.Show("Процедура не найдена!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Процедура не найдена!", MessageBoxButton.OK,
                MessageBoxImage.Error);
            }
            dataGrid.ItemsSource = ds.Tables[0].DefaultView;
        }
        public List<string> ComboBox2()
        {
            string cmd = "SELECT Treatment.[Название процедуры] FROM Treatment";
            dAdapt.SelectCommand.CommandText = cmd;
            ds.Clear();
            try
            {
                dAdapt.Fill(ds, "treatment");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Процедура не найдена!", MessageBoxButton.OK,
                MessageBoxImage.Error);
            }
            var result = new List<string>();
            for (int i = 0; i < ds.Tables[0].DefaultView.Count; i++)
            {
                result.Add(ds.Tables[0].DefaultView.Table.Rows[i].ItemArray[0].ToString());
            }

            return (result);
        }
    }
}
