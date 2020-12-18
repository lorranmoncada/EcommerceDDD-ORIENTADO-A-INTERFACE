using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Notification
{
    public class Notifies
    {
        public Notifies()
        {
            LstNotifies = new List<Notifies>();
        }
        //NotMapped usado para não mapear a propriedade com o banco de dados
        [NotMapped]
        public string NomePropriedade { get; set; }

        [NotMapped]
        public string Mensagem { get; set; }

        [NotMapped]
        public List<Notifies> LstNotifies;

        public bool ValidaPropriedadeString(string valor, string nomePropriedade)
        {
            if (string.IsNullOrWhiteSpace(valor) || string.IsNullOrWhiteSpace(nomePropriedade))
            {
                LstNotifies.Add(new Notifies { Mensagem = "Campo Obrigatório", NomePropriedade = nomePropriedade });

                return false;
            }

            return true;

        }

        public bool ValidaPropriedadeInt(int valor, string nomePropriedade)
        {
            if (valor < 1 || string.IsNullOrWhiteSpace(nomePropriedade))
            {
                LstNotifies.Add(new Notifies { Mensagem = "Campo deve ser maior que 0", NomePropriedade = nomePropriedade });

                return false;
            }

            return true;

        }

        public bool ValidaPropriedadeDecimal(decimal valor, string nomePropriedade)
        {
            if (valor < 1 || string.IsNullOrWhiteSpace(nomePropriedade))
            {
                LstNotifies.Add(new Notifies { Mensagem = "Campo deve ser maior que 0", NomePropriedade = nomePropriedade });

                return false;
            }

            return true;

        }
    }
}
