using Kursovaya_ONIT_3.Entities;
using Kursovaya_ONIT_3.Managers;
using System;
using System.Data;
using System.Windows;

namespace Kursovaya_ONIT_3.WPF
{
    /// <summary>
    /// Логика взаимодействия для TreatmentTable.xaml
    /// </summary>
    public partial class TreatmentTable : Window
    {
        TreatmentManager treatmentManager;
        public TreatmentTable()
        {
            InitializeComponent();
            treatmentManager = new TreatmentManager(DataTable2);
            treatmentManager.GetFullTable();
        }

       

        private void Button_Click(object sender, RoutedEventArgs e) // добавить процедуру 
        {
            Treatment treatment = new Treatment(NameOfTreatment.Text, Convert.ToInt32(Cost.Text), Convert.ToDouble(Duration.Text), MasterName.Text);

            treatmentManager.AddTreatment(treatment);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e) // удалить процедуру
        {
            string NameOfProcedure = ((DataRowView)DataTable2.SelectedItem).Row.ItemArray[0].ToString();
            treatmentManager.DeleteSelectedRow(NameOfProcedure);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e) //поиск процедуры 
        {
            try
            {
                int mincost;
                int maxcost;
                double minduration;
                double maxduration;
                if (CostMin.Text == "")
                    mincost = 0;
                else
                    mincost = Convert.ToInt32(CostMin.Text);
                if (DurationMin.Text == "")
                    minduration = 0;
                else
                    minduration = Convert.ToDouble(DurationMin.Text);
                if (CostMax.Text == "")
                    maxcost = Int32.MaxValue;
                else
                    maxcost = Convert.ToInt32(CostMax.Text);
                if (DurationMin.Text == "")
                    maxduration = float.MaxValue;
                else
                    maxduration = Convert.ToDouble(DurationMax.Text);
                treatmentManager.SearchTreatment(mincost, minduration, maxcost, maxduration);
            }
            catch (Exception sex)
            {
                MessageBox.Show(sex.Message, "Неправильный формат данных!", MessageBoxButton.OK,
                MessageBoxImage.Error);
            }

        }
        private void Button_Click_3(object sender, RoutedEventArgs e) //убрать фильтр
        {
            treatmentManager.GetFullTable();
        }

    }
}
