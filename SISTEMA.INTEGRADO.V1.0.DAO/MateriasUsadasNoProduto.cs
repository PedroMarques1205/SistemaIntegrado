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
    
    public partial class MateriasUsadasNoProduto
    {
        public int idMateriaPrima { get; set; }
        public string NomeMp { get; set; }
        public int idProduto { get; set; }
        public string NomeProduto { get; set; }
        public Nullable<int> Quantidade { get; set; }
    
        public virtual MateriaPrima MateriaPrima { get; set; }
    }
}
