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

namespace Poprijenok_BelyakovAA
{
    /// <summary>
    /// Логика взаимодействия для WindowAgentReductor.xaml
    /// </summary>
    public partial class WindowAgentReductor : Window
    {
        public bool isAdd = false;
        public WindowAgentReductor()
        {
            InitializeComponent();
            cbAgents.ItemsSource = DBPoprij.db.AgentType.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Agent myAgent = new Agent();

            myAgent.Address = tbAddr.Text;
            myAgent.DirectorName = tbDirector.Text;
            myAgent.Email = tbEmail.Text;
            myAgent.INN = tbINN.Text;
            myAgent.KPP = tbKPP.Text;
            myAgent.Logo = tbLogo.Text;
            myAgent.Priority = int.Parse(tbPriority.Text);
            myAgent.Phone = tbTel.Text;
            myAgent.Title = tbTitle.Text;
            myAgent.AgentType = cbAgents.SelectedItem as AgentType;

            if (isAdd == true)
            {
                DBPoprij.db.Agent.Add(myAgent);
                DBPoprij.db.SaveChanges();
                DialogResult = true;
                Close();
            }

            Close();
        }
    }
}
