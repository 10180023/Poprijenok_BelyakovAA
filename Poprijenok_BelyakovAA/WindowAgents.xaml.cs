using System;
using System.Collections.Generic;
using System.Data.Entity;
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

namespace Poprijenok_BelyakovAA
{
    /// <summary>
    /// Логика взаимодействия для WindowAgents.xaml
    /// </summary>
    public partial class WindowAgents : Window
    {
        List<String> Sort = new List<string>() { "Наименование", "Скидка", "Приоритет" };

        public WindowAgents()
        {
            InitializeComponent();
            DBPoprij.db.AgentType.Load();

            cbTypesFilter.ItemsSource = DBPoprij.db.AgentType.ToList();
            cbSort.ItemsSource = Sort;
            frameAgents.Navigate(new PageAgents());
        }

        

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            new MainWindow().Show();
            Close();
        }
    }
}
