using Kursovaya_ONIT_3.Entities;
using Kursovaya_ONIT_3.Managers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Kursovaya_ONIT_3
{
    /// <summary>
    /// Логика взаимодействия для LogOfRecordsTable.xaml
    /// </summary>
    public partial class LogOfRecordsTable : Window
    {
        LogOfRecordsManager logOfRecordsManager;
        ClientManager clientManager;
        TreatmentManager treatmentManager;
        static List<string> Tels;

        public List<string> GetF(List<Client> Source )
        {
            List<string> Result = new List<string>();
            Tels= new List<string>();
            for (int i = 0; i < Source.Count; i++)
            {
                Result.Add(Source[i].FIO);
                Tels.Add(Source[i].TelNum);
            }
            return Result;
        }

      
   



        public LogOfRecordsTable()
        {
            InitializeComponent();
                   
            logOfRecordsManager = new LogOfRecordsManager(DataTable3);
            logOfRecordsManager.GetFullTable();
            clientManager = new ClientManager(DataTable3);
            treatmentManager = new TreatmentManager(DataTable3);
            fio.ItemsSource = GetF(clientManager.ComboBox1());
            treatment.ItemsSource = treatmentManager.ComboBox2(); 
        }

        public void ClientOpen(object sender, EventArgs e)
        {
            fio.ItemsSource = GetF(clientManager.ComboBox1());
        }


        private void TreatmentOpen(object sender, EventArgs e)
        {
            treatment.ItemsSource = treatmentManager.ComboBox2();
        }

        private string LMAOParse(string SHittyDate)
        {
            char[] tmp = SHittyDate.ToCharArray();
            char[] tmp2 = new char[tmp.Length];
            tmp.CopyTo(tmp2, 0);

            for (int i = 0; i < 4; i++)//суем год на первое место
                tmp[i] = tmp2[tmp.Length - 4 + i];
            tmp[4] = '-';
            for (int i = 0; i < 2; i++)
                tmp[5 + i] = tmp2[3 + i];
            tmp[7] = '-';
            for (int i = 8; i < tmp.Length; i++)
                tmp[i] = tmp2[i - 8];
            return new string(tmp);
        }

        private void Button_Click(object sender, RoutedEventArgs e) // добавить запись
        {
            //LogOfRecords logOfRecords = new LogOfRecords(logOfRecordsManager.NewNumber(), fio.SelectedItem.ToString(), DateTime.Parse(date.Text), DateTime.Parse(time.Text), treatment.SelectedItem.ToString());
            //try
            //{
                LogOfRecords logOfRecords = new LogOfRecords(logOfRecordsManager.NewNumber(), Tels[fio.SelectedIndex], DateTime.Parse(LMAOParse(date.Text) + "T" + date_Copy.Text), treatment.SelectedItem.ToString());
                logOfRecordsManager.AddLogOfRecords(logOfRecords);
            //}
            //catch
            //{
                //MessageBox.Show("Введите нормальную дату и время!");
            //}
               
        }

        private void Button_Click_1(object sender, RoutedEventArgs e) //удалить запись
        {
            int n = Convert.ToInt32(((DataRowView)DataTable3.SelectedItems[0]).Row.ItemArray[0]);
            logOfRecordsManager.DeleteSelectedRow(n);
        }

        

        private void ClientCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            if ((ClientCheckBox.IsChecked == true)&&(TreatmentCheckBox.IsChecked==true))
                logOfRecordsManager.GetAllInf();
            else
                if ((ClientCheckBox.IsChecked == true) && (TreatmentCheckBox.IsChecked == false))
                    logOfRecordsManager.GetClientsToo();
                

        }

        private void TreatmentCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            if ((ClientCheckBox.IsChecked == true) && (TreatmentCheckBox.IsChecked == true))
                logOfRecordsManager.GetAllInf();
            else
                if ((ClientCheckBox.IsChecked == false) && (TreatmentCheckBox.IsChecked == true))
                logOfRecordsManager.GetTreatmentsToo();
            
                    
        }

        private void ClientCheckBox_UnChecked(object sender, RoutedEventArgs e)
        {
            
                    if ((ClientCheckBox.IsChecked == false) && (TreatmentCheckBox.IsChecked == true))
                logOfRecordsManager.GetTreatmentsToo();
            else
                        if ((ClientCheckBox.IsChecked == false) && (TreatmentCheckBox.IsChecked == false))
                logOfRecordsManager.GetFullTable();
        }

        private void TreatmentCheckBox_UnChecked(object sender, RoutedEventArgs e)
        {
            if ((ClientCheckBox.IsChecked == true) && (TreatmentCheckBox.IsChecked == false))
                logOfRecordsManager.GetClientsToo();
            else
                        if ((ClientCheckBox.IsChecked == false) && (TreatmentCheckBox.IsChecked == false))
                logOfRecordsManager.GetFullTable();
        }
    }
}
