//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SISTEMA.INTEGRADO.V1._0.DAO
{
    using System;
    using System.Collections.Generic;
    
    public partial class Endereco
    {
        public int IdEndereco { get; set; }
        public int idOrcamento { get; set; }
        public string Rua { get; set; }
        public string Bairro { get; set; }
        public int Num { get; set; }
        public string Complemento { get; set; }
        public string Estado { get; set; }
        public string Municipio { get; set; }
    
        public virtual Orcamento Orcamento { get; set; }
    }
}