using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Patio : Entity
    {
        public String Name { get; set; }

        public string Descricao { get; set; }

        public string TaxaHora { get; set; }

        public string Vaga { get; set; }

        public string Entrada { get; set; }

        public string Saida { get; set; }

        public string Valor { get; set; }
    }
}
