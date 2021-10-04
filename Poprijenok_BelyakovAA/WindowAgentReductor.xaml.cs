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
using System.Windows.Shapes;
using Poprijenok_BelyakovAA.Model;

namespace Poprijenok_BelyakovAA
{
    /// <summary>
    /// Логика взаимодействия для WindowAgentReductor.xaml
    /// </summary>
    public partial class WindowAgentReductor : Window
    {
        public bool isAdd = false;
        /// <summary>
        /// Инициализация компонентов
        /// </summary>
        public WindowAgentReductor()
        {
            InitializeComponent();
            cbAgents.ItemsSource = DBPoprij.db.AgentType.ToList();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
