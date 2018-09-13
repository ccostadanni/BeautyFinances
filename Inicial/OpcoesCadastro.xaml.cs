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

namespace Inicial
{
    /// <summary>
    /// Lógica interna para OpcoesCadastro.xaml
    /// </summary>
    public partial class OpcoesCadastro : Window
    {
        public OpcoesCadastro()
        {
            InitializeComponent();
        }

        private void btn_CadCli_Click(object sender, RoutedEventArgs e)
        {
            Cadastro cd = new Cadastro();
            cd.Show();
        }

        private void btn_CadServ_Click(object sender, RoutedEventArgs e)
        {
            CadServico cs = new CadServico();
            cs.Show();
        }

        private void btn_CadProf_Click(object sender, RoutedEventArgs e)
        {
            CadProf cp = new CadProf();
            cp.Show();
        }
    }
}
