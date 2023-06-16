using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_DA_PL_B_2223
{
    public class Bilhete
    {
        [Key]
        public int idBilhete { get; set; }
        public string lugarBilhete { get; set; }
        public string estadoBilhete { get; set; }
        //public Filme filmeBilhete { get; } -------> FILME e SALA vao estar na SESSAO
        public int idCliente { get; set; }
        //public Sala salaBilhete { get; }
        public int idFuncionario { get; set;}
        public int idSessao { get; set;}
        public DateTime dataHoraCompra { get; set; }

        //CRIADA ESTA VARIAVEL ESTATICA PARA SER INCREMENTADA SEMPRE QUE UM OBJ BILHETE SEJA CRIADO
        private static int contadorBilhete = 0;

        public Bilhete( string lugarBilhete, string estadoBilhete, int idCliente, int idSessao, int idFuncionario)
        {
            this.lugarBilhete = lugarBilhete;
            this.estadoBilhete = estadoBilhete;
            this.idCliente = idCliente;
            this.idSessao = idSessao;
            this.idFuncionario = idFuncionario;
            this.dataHoraCompra = DateTime.Now;
        }

        public Bilhete()
        {
            //O NUMERO DO BILHETE VAI SER ATRIBUIDO AO 'idBilhete' PELO '++contadorBilhete'
            idBilhete = ++contadorBilhete;
        }

        //METODO PARA CONTAGEM DE BILHETES CRIADOS
        public double NumeroBilhete
        {
            //DEVOLVE O NUMERO DO BILHETE PARA O OBJ
            get { return idBilhete; }
        }

    }
}
