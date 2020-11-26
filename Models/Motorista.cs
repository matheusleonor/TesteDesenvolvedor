using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroMotorista.Models
{
    public class Motorista
    {
        public int MotoristaId { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Placa { get; set; }
        public string Eixos { get; set; }
        public string Endereco { get; set; }

    }
}
