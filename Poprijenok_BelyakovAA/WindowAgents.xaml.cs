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
        static Agent agent { get; set; }
        WindowAgentReductor windowAgentReductor = new WindowAgentReductor();

        /// <summary>
        /// Подгрузка необходимых баз из БД, заполнение данных в таблицу и выпадающий список
        /// </summary>
        public WindowAgents()
        {
            InitializeComponent();
            DBPoprij.db.Agent.Load();
            DBPoprij.db.AgentType.Load();

            dgAgents.ItemsSource = DBPoprij.db.Agent.ToList();
            cbTypes.ItemsSource = DBPoprij.db.AgentType.ToList();
        }
        /// <summary>
        /// Открытие и передача данных для окна редактирования агента
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            agent = dgAgents.SelectedItem as Agent;

            windowAgentReductor.tbAddr.Text = agent.Address;
            windowAgentReductor.tbDirector.Text = agent.DirectorName;
            windowAgentReductor.tbEmail.Text = agent.Email;
            windowAgentReductor.tbINN.Text = agent.INN.ToString();
            windowAgentReductor.tbKPP.Text = agent.KPP.ToString();
            windowAgentReductor.tbLogo.Text = agent.Logo.ToString();
            windowAgentReductor.tbPriority.Text = agent.Priority.ToString();
            windowAgentReductor.tbTel.Text = agent.Phone.ToString();
            windowAgentReductor.tbTitle.Text = agent.Title;

            windowAgentReductor.isAdd = false;

            if (windowAgentReductor.ShowDialog() == true)
            {
                DBPoprij.db.SaveChanges();
                dgAgents.ItemsSource = DBPoprij.db.Agent.ToList();
                dgAgents.Items.Refresh();
            }
            //windowAgentReductor.cbAgents.SelectedIndex = (int)agent.AgentTypeID - 1;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            windowAgentReductor.isAdd = true;
            if (windowAgentReductor.ShowDialog() == true)
            {
                DBPoprij.db.SaveChanges();
                dgAgents.ItemsSource = DBPoprij.db.Agent.ToList();
                dgAgents.Items.Refresh();
            }
        }

        private void GetAgent(string search, string filter, string sort)
        {
            List < Agent > listAgents = DBPoprij.db.Agent.ToList();

            //if (sort == "По возрастанию")
            //{
            //    listAgents.OrderBy(c => c.Priority).ToList();
            //}
            //else
            //{
            //    listAgents.OrderByDescending(c => c.Priority).ToList();
            //}

            //dgAgents.ItemsSource = listAgents;


            listAgents = listAgents.Where(c => c.AgentType = filter as AgentType);
        }
    }
}
