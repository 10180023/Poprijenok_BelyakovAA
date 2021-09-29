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
        

        public WindowAgents()
        {
            InitializeComponent();
            

            
            frameAgents.Navigate(new PageAgents());
        }

        

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            new MainWindow().Show();
            Close();
        }
    }
}
