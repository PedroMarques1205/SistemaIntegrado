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
    
    public partial class MateriaPrima
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MateriaPrima()
        {
            this.MateriasUsadasNoProduto = new HashSet<MateriasUsadasNoProduto>();
            this.PedidoCompraSuprimento = new HashSet<PedidoCompraSuprimento>();
        }
    
        public int idMateriaPrima { get; set; }
        public string CodigoMp { get; set; }
        public string Nome { get; set; }
        public Nullable<bool> isAtivo { get; set; }
        public string CodigoTipo { get; set; }
    
        public virtual EstoqueMateriaPrima EstoqueMateriaPrima { get; set; }
        public virtual TipoMateria TipoMateria { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MateriasUsadasNoProduto> MateriasUsadasNoProduto { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PedidoCompraSuprimento> PedidoCompraSuprimento { get; set; }
    }
}
