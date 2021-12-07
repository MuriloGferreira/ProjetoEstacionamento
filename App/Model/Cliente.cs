using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Cliente : Entity
    {
        public string Nome { get; set; }

        public Int64 Cpf { get; set; }
    }
}
