using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace evoProjDepartApi.Data
{
    public class Funcionario
    {
        public int FuncionarioId { get; set; }

        public String Nome { get; set; }

        public String Foto { get; set; }

        public String Rg { get; set; }

        public Departamento Departamento { get; set; }

        public int DepartamentoId { get; set; }

    }
}
