﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ConnectionString : DbContext
    {
        public ConnectionString()
            : base("name=ConnectionString")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<Entrega> Entrega { get; set; }
        public virtual DbSet<EstoqueMateriaPrima> EstoqueMateriaPrima { get; set; }
        public virtual DbSet<EstoqueProdutoAcabado> EstoqueProdutoAcabado { get; set; }
        public virtual DbSet<MateriaPrima> MateriaPrima { get; set; }
        public virtual DbSet<MateriasUsadasNoProduto> MateriasUsadasNoProduto { get; set; }
        public virtual DbSet<Orcamento> Orcamento { get; set; }
        public virtual DbSet<OrdemProducao> OrdemProducao { get; set; }
        public virtual DbSet<PedidoCompraSuprimento> PedidoCompraSuprimento { get; set; }
        public virtual DbSet<Produto> Produto { get; set; }
        public virtual DbSet<Transacao> Transacao { get; set; }
    }
}
