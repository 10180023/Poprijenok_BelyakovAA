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
        private Agent agent = new Agent();
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
            agent.Address = tbAddr.Text;
            agent.DirectorName = tbDirector.Text;
            agent.Email = tbEmail.Text;
            agent.INN = tbINN.Text;
            agent.KPP = tbKPP.Text;
            agent.Logo = tbLogo.Text;
            agent.Priority = int.Parse(tbPriority.Text);
            agent.Phone = tbTel.Text;
            agent.Title = tbTitle.Text;
            agent.AgentType = cbAgents.SelectedItem as AgentType;

            if (isAdd == true)
            {
                MessageBox.Show("Уведомление", "Запись добавлена");

                DBPoprij.db.Agent.Add(agent);
                DBPoprij.db.SaveChanges();
            }
            else
            {
                //MessageBox.Show("Уведомление", "Запись обновлена");
                //DBPoprij.db.SaveChanges();
            }
        }
    }
}
