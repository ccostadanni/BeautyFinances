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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Inicial
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //chama forms cadastro
        private void btnCad_Click(object sender, RoutedEventArgs e)
        {
            OpcoesCadastro Oc = new OpcoesCadastro();
            Oc.Show();
        }

        
        private void btnServi_Click(object sender, RoutedEventArgs e)
        {
            Servicos se = new Servicos();
            se.Show();
        }
    }
}
