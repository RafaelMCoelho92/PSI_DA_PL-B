using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_DA_PL_B_2223
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        public TabPage getPage()
        {
            return tabControl1.TabPages[0];
        }

        // BLOQUEAR/ INVISIVEL OS OUTROS BOTOES ENQUANTO N FIZER LOG IN

        //DEPOIS DE LOGIN FEITO METER O NOME DO USER NO toolStripStatusLabelNomeFuncionarioLogado
        // DESBLOQUEAR BOTOES

        //CASO N TENHA NOME DE CINEMA MANDAR PARA A PAGINA DO CINEMA
    }
}
