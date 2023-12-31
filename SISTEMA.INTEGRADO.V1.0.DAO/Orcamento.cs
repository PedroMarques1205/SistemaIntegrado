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
    
    public partial class Orcamento
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Orcamento()
        {
            this.Endereco = new HashSet<Endereco>();
            this.Entrega = new HashSet<Entrega>();
            this.Transacao = new HashSet<Transacao>();
        }
    
        public string CpfCliente { get; set; }
        public int idProduto { get; set; }
        public Nullable<int> QuantProduto { get; set; }
        public Nullable<double> ValorTotal { get; set; }
        public System.DateTime DataOrcamento { get; set; }
        public Nullable<System.DateTime> DataAceito { get; set; }
        public Nullable<System.DateTime> DataRejeitado { get; set; }
        public int idOrcamento { get; set; }
        public string statusCliente { get; set; }
        public string statusEntrega { get; set; }
        public string formaPagamento { get; set; }
        public Nullable<bool> PodeSerEntregue { get; set; }
    
        public virtual Cliente Cliente { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Endereco> Endereco { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Entrega> Entrega { get; set; }
        public virtual Produto Produto { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Transacao> Transacao { get; set; }
    }
}
