using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
   public class ParametroEntity : DBEntity
    {

        public int? IdParametro { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public int? Valor { get; set; }
        public int? Estado { get; set; }


    }
}
