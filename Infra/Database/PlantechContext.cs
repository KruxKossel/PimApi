using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Infra.Entities.Estoque;
using Infra.Entities.Financeiro;
using Infra.Entities.Producao;
using Infra.Entities.RecursosHumanos;
using Infra.Entities.Vendas;
using Microsoft.EntityFrameworkCore;

namespace Infra.Database
{
    public class PlantechContext(DbContextOptions<PlantechContext> options) : DbContext(options)
    {
        public DbSet<ApiEntity> Apis { get; set; }
        public DbSet<ItensReceitaEntity> ItensReceitas { get; set; }
        public DbSet<ProducaoEntity> Producoes { get; set; }
        public DbSet<NotaFiscalVendaEntity> NotaFiscalVendas { get; set; }
        public DbSet<FuncionarioEntity> Funcionarios { get; set; }
        public DbSet<FornecedorEntity> Fornecedores { get; set; }
        public DbSet<PagamentosContasEntity> PagamentosContas { get; set; }
        public DbSet<ProdutoEntity> Produtos { get; set; }
        public DbSet<NotaFiscalCompraEntity> NotaFiscalCompras { get; set; }
        public DbSet<OrdemCompraEntity> OrdemCompras { get; set; }
        public DbSet<MatrizFilialEntity> MatrizFiliais { get; set; }
        public DbSet<FormasPagamentosEntity> FormasPagamentos { get; set; }
        public DbSet<RelatorioProducaoEntity> RelatoriosProducao { get; set; }
        public DbSet<ItemConsumoEntity> ItensConsumo { get; set; }
        public DbSet<ItemProduzidoEntity> ItensProduzidos { get; set; }
        public DbSet<ItensVendaEntity> ItensVendas { get; set; }
        public DbSet<RelatorioVendaEntity> RelatoriosVenda { get; set; }
        public DbSet<ClienteEntity> Clientes { get; set; }
        public DbSet<RecebeContasEntity> RecebeContas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {   
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ApiEntity>()
                .HasOne(a => a.Producao)
                .WithOne(p => p.Api)
                .HasForeignKey<ProducaoEntity>(p => p.ApiId);

            // Outras configurações, se necessário
        }

    }
}