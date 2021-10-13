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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Poprijenok_BelyakovAA.Model;

namespace Poprijenok_BelyakovAA
{
    /// <summary>
    /// Логика взаимодействия для PageAgents.xaml
    /// </summary>
    public partial class PageAgents : Page
    {
        public static Agent agent { get; set; }
        List<String> Sort = new List<string>() { "Наименование", "Скидка", "Приоритет" };
        /// <summary>
        /// Инициализация компонентов, при открытии окна показываются данные таблицы
        /// </summary>
        public PageAgents()
        {
            InitializeComponent();
            DBPoprij.db.Agent.Load();
            DBPoprij.db.AgentType.Load();

            dgAgents.ItemsSource = DBPoprij.db.Agent.ToList();
            cbTypesFilter.ItemsSource = DBPoprij.db.AgentType.ToList();
            cbSort.ItemsSource = Sort;
        }
        /// <summary>
        /// Передача данных в форму для редактирования данных таблицы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            agent = dgAgents.SelectedItem as Agent;
            WindowAgentReductor windowAgentReductor = new WindowAgentReductor();
            windowAgentReductor.Show();

            //windowAgentReductor.tbAddr.Text = agent.Address;
            //windowAgentReductor.tbDirector.Text = agent.DirectorName;
            //windowAgentReductor.tbEmail.Text = agent.Email;
            //windowAgentReductor.tbINN.Text = agent.INN.ToString();
            //windowAgentReductor.tbKPP.Text = agent.KPP.ToString();
            //windowAgentReductor.tbLogo.Text = agent.Logo.ToString();
            //windowAgentReductor.tbPriority.Text = agent.Priority.ToString();
            //windowAgentReductor.tbTel.Text = agent.Phone.ToString();
            //windowAgentReductor.tbTitle.Text = agent.Title;
            //windowAgentReductor.cbAgents.SelectedIndex = (int)agent.AgentTypeID - 1;
        }
    }
}
