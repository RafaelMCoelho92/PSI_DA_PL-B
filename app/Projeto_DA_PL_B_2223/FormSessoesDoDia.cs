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
    public partial class FormSessoesDoDia : Form
    {
        private FormPrincipal formPrincipal;

        public FormSessoesDoDia()
        {

            InitializeComponent();
            this.CenterToScreen();
        }
        public FormSessoesDoDia(FormPrincipal formPrincipal) : this() //CHAMAR CONSTRUCTOR DE CIMA    
        {
            this.formPrincipal = formPrincipal;
        }

        public TabPage getPage()
        {
            return tabControl1.TabPages[0];
        }

        private void buttonCriarBilheteSessDia_Click(object sender, EventArgs e)
        {
            //A CADA CLICK NO 'CRIAR BILHETE' DO FORM INSTANCIA UM OBJ E INCREMENTA O ID
            Bilhete bilhete = new Bilhete();
            
            //ESTE CONSOLE FOI SOO PARA VEIRIFCAR SE ESTAVA A INCREMENTAR O ID DO BILHETE
            Console.WriteLine($"Bilhete: {bilhete.NumeroBilhete}");
        }
    }
}
