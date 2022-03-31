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

namespace Kursovaya_ONIT_3.WPF
{
    /// <summary>
    /// Логика взаимодействия для ClientsTable.xaml
    /// </summary>
    public partial class ClientsTable : Window
    {
        ClientManager clientManager;
        public ClientsTable()
        {
            InitializeComponent();
            clientManager = new ClientManager(DataTable);
            clientManager.GetFullTable();
        }

        private void Button_Click(object sender, RoutedEventArgs e) //добавить клиента
        {
            Client client = new Client(_FIO.Text, _TelNum_Copy.Text);
            clientManager.AddClient(client);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e) // удалить клиента
        {
            string TelNum = ((DataRowView)DataTable.SelectedItem).Row.ItemArray[1].ToString();
            clientManager.DeleteSelectedRow(TelNum);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e) //поиск по ФИО
        {
            string FIO = Search.Text;
            clientManager.SearchClient(FIO);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e) //убрать фильтр
        {
            clientManager.GetFullTable();
        }
    }
}
