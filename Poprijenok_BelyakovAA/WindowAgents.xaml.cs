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

        public WindowAgents()
        {
            InitializeComponent();
            DBPoprij.db.Agent.Load();
            DBPoprij.db.AgentType.Load();

            dgAgents.ItemsSource = DBPoprij.db.Agent.ToList();
            cbTypes.ItemsSource = DBPoprij.db.AgentType.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            agent = dgAgents.SelectedItem as Agent;
            WindowAgentReductor windowAgentReductor = new WindowAgentReductor();
            windowAgentReductor.Show();

            windowAgentReductor.tbAddr.Text = agent.Address;
            windowAgentReductor.tbDirector.Text = agent.DirectorName;
            windowAgentReductor.tbEmail.Text = agent.Email;
            windowAgentReductor.tbINN.Text = agent.INN.ToString();
            windowAgentReductor.tbKPP.Text = agent.KPP.ToString();
            windowAgentReductor.tbLogo.Text = agent.Logo.ToString();
            windowAgentReductor.tbPriority.Text = agent.Priority.ToString();
            windowAgentReductor.tbTel.Text = agent.Phone.ToString();
            windowAgentReductor.tbTitle.Text = agent.Title;

            //windowAgentReductor.cbAgents.SelectedIndex = (int)agent.AgentTypeID - 1;
        }
    }
}
