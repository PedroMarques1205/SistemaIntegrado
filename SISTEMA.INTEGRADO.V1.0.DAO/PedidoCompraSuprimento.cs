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
    
    public partial class PedidoCompraSuprimento
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PedidoCompraSuprimento()
        {
            this.Transacao = new HashSet<Transacao>();
        }
    
        public int IdPedidoCompra { get; set; }
        public int IdMateriaPrima { get; set; }
        public string Fornecedor { get; set; }
        public Nullable<System.DateTime> DataPedido { get; set; }
        public Nullable<System.DateTime> DataCompra { get; set; }
        public Nullable<int> Quantidade { get; set; }
        public Nullable<double> PrecoUnit { get; set; }
        public Nullable<double> PrecoTotal { get; set; }
        public Nullable<System.DateTime> PrazoEntrega { get; set; }
        public string CondicaoPagamento { get; set; }
        public Nullable<bool> IsPedidoAceito { get; set; }
        public Nullable<bool> IsEntregue { get; set; }
    
        public virtual MateriaPrima MateriaPrima { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Transacao> Transacao { get; set; }
    }
}
