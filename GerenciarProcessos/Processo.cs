using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciarProcessos
{
    public class Processo
    {
        public int Id { get; set; }
        public string Numero { get; set; }
        public string Tipo { get; set; }
        public string Assunto { get; set; }
        public string Interessado { get; set; }
        public string Status { get; set; }
        public string Observacoes { get; set; }
        public string Data_da_Divisao { get; set; }
    }
}
