using Kursovaya_ONIT_3.WPF;
using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Kursovaya_ONIT_3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ClientsTable clientsTable;
        TreatmentTable treatmentTable;
        LogOfRecordsTable logOfRecordsTable;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (logOfRecordsTable != null) // если окно не существует
            {
                logOfRecordsTable.Close();
                logOfRecordsTable = null;
            }
            logOfRecordsTable = new LogOfRecordsTable();
            logOfRecordsTable.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (clientsTable != null) // если окно не существует
            {
                clientsTable.Close();
                clientsTable = null;
            }
            clientsTable = new ClientsTable();
            clientsTable.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (treatmentTable != null) // если окно не существует
            {
                treatmentTable.Close();
                treatmentTable = null;
            }
            treatmentTable = new TreatmentTable();
            treatmentTable.Show();
        }
    }
}
