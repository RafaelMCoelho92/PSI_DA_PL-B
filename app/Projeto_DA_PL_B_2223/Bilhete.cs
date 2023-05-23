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
        public double idBilhete { get; set; }
        public double lugarBilhete { get; set; }
        public bool estadoBilhete { get; set; }
        //public Filme filmeBilhete { get; } -------> FILME e SALA vao estar na SESSAO
        public Cliente clienteBilhete { get; set; }
        //public Sala salaBilhete { get; }
        public Funcionario funcionarioBilhete { get; }
        //public Sessao sessaoBilhete { get; }

        //CRIADA ESTA VARIAVEL ESTATICA PARA SER INCREMENTADA SEMPRE QUE UM OBJ BILHETE SEJA CRIADO
        private static int contadorBilhete = 0;

        public Bilhete(double idBilhete, double lugarBilhete, bool estadoBilhete, /*Filme filmeBilhete,*/ Cliente clienteBilhete, /*Sala salaBilhete,*/ Funcionario funcionarioBilhete)
        {
            this.idBilhete = idBilhete;
            this.lugarBilhete = lugarBilhete;
            this.estadoBilhete = estadoBilhete;
            //this.filmeBilhete = filmeBilhete;
            this.clienteBilhete = clienteBilhete;
            //this.salaBilhete = salaBilhete;
            this.funcionarioBilhete = funcionarioBilhete;
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
