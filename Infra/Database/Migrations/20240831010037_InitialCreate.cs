using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Api.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "api",
                columns: table => new
                {
                    pk_api = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    temperatura = table.Column<float>(type: "REAL", nullable: true),
                    desenvolvimento = table.Column<string>(type: "TEXT", maxLength: 45, nullable: false),
                    data_informacao = table.Column<DateTime>(type: "TEXT", nullable: true),
                    nivel_agua = table.Column<float>(type: "REAL", nullable: true),
                    fk_producao = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_api", x => x.pk_api);
                });

            migrationBuilder.CreateTable(
                name: "cargos",
                columns: table => new
                {
                    pk_cargos = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    status = table.Column<int>(type: "INTEGER", nullable: false),
                    descricao = table.Column<string>(type: "TEXT", maxLength: 45, nullable: false),
                    salario = table.Column<double>(type: "REAL", nullable: false),
                    funcao = table.Column<string>(type: "TEXT", maxLength: 45, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cargos", x => x.pk_cargos);
                });

            migrationBuilder.CreateTable(
                name: "fornecedor",
                columns: table => new
                {
                    pk_fornecedor = table.Column<string>(type: "TEXT", maxLength: 45, nullable: false),
                    razao_social = table.Column<string>(type: "TEXT", maxLength: 45, nullable: false),
                    cidade = table.Column<string>(type: "TEXT", maxLength: 45, nullable: false),
                    endereco = table.Column<string>(type: "TEXT", maxLength: 45, nullable: false),
                    email = table.Column<string>(type: "TEXT", maxLength: 45, nullable: false),
                    status = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_fornecedor", x => x.pk_fornecedor);
                });

            migrationBuilder.CreateTable(
                name: "itens_receita",
                columns: table => new
                {
                    pk_itens = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    quantidade = table.Column<int>(type: "INTEGER", nullable: false),
                    valor = table.Column<float>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_itens_receita", x => x.pk_itens);
                });

            migrationBuilder.CreateTable(
                name: "matriz_filial",
                columns: table => new
                {
                    pk_empresa = table.Column<string>(type: "TEXT", maxLength: 45, nullable: false),
                    razao_social = table.Column<string>(type: "TEXT", maxLength: 45, nullable: false),
                    cidade = table.Column<string>(type: "TEXT", maxLength: 45, nullable: false),
                    estado = table.Column<string>(type: "TEXT", maxLength: 45, nullable: false),
                    endereco = table.Column<string>(type: "TEXT", maxLength: 45, nullable: false),
                    numero = table.Column<int>(type: "INTEGER", nullable: true),
                    data_ini = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_matriz_filial", x => x.pk_empresa);
                });

            migrationBuilder.CreateTable(
                name: "nota_fiscal_venda",
                columns: table => new
                {
                    pk_pedido = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    data_pedido = table.Column<DateTime>(type: "TEXT", nullable: false),
                    valor_total = table.Column<double>(type: "REAL", nullable: false),
                    status = table.Column<string>(type: "TEXT", maxLength: 45, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_nota_fiscal_venda", x => x.pk_pedido);
                });

            migrationBuilder.CreateTable(
                name: "produtos",
                columns: table => new
                {
                    pk_produtos = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    nome = table.Column<string>(type: "TEXT", maxLength: 45, nullable: false),
                    descricao = table.Column<string>(type: "TEXT", maxLength: 45, nullable: false),
                    preco_venda = table.Column<float>(type: "REAL", nullable: false),
                    quantidade_estoque = table.Column<int>(type: "INTEGER", nullable: false),
                    insumo_consumo = table.Column<int>(type: "INTEGER", nullable: false),
                    preco_compra = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_produtos", x => x.pk_produtos);
                });

            migrationBuilder.CreateTable(
                name: "producao",
                columns: table => new
                {
                    pk_producao = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    lote = table.Column<string>(type: "TEXT", maxLength: 45, nullable: false),
                    data_inicio = table.Column<DateTime>(type: "TEXT", nullable: false),
                    data_termino = table.Column<DateTime>(type: "TEXT", nullable: true),
                    data_previsao_colheita = table.Column<DateTime>(type: "TEXT", nullable: true),
                    fk_agricultor = table.Column<string>(type: "TEXT", maxLength: 45, nullable: false),
                    api_pk_api = table.Column<int>(type: "INTEGER", nullable: false),
                    itens_receita_pk_itens = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_producao", x => x.pk_producao);
                    table.ForeignKey(
                        name: "FK_producao_api_api_pk_api",
                        column: x => x.api_pk_api,
                        principalTable: "api",
                        principalColumn: "pk_api",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_producao_itens_receita_itens_receita_pk_itens",
                        column: x => x.itens_receita_pk_itens,
                        principalTable: "itens_receita",
                        principalColumn: "pk_itens",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "item_consumo",
                columns: table => new
                {
                    pk_item = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    quantidade = table.Column<int>(type: "INTEGER", nullable: false),
                    valor = table.Column<double>(type: "REAL", nullable: false),
                    itens_receita_pk_itens = table.Column<int>(type: "INTEGER", nullable: false),
                    produtos_pk_produtos = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_item_consumo", x => x.pk_item);
                    table.ForeignKey(
                        name: "FK_item_consumo_itens_receita_itens_receita_pk_itens",
                        column: x => x.itens_receita_pk_itens,
                        principalTable: "itens_receita",
                        principalColumn: "pk_itens",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_item_consumo_produtos_produtos_pk_produtos",
                        column: x => x.produtos_pk_produtos,
                        principalTable: "produtos",
                        principalColumn: "pk_produtos",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "itens_venda",
                columns: table => new
                {
                    pk_item = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    quantidade = table.Column<int>(type: "INTEGER", nullable: false),
                    valor_unitario = table.Column<double>(type: "REAL", nullable: false),
                    produtos_pk_produtos = table.Column<int>(type: "INTEGER", nullable: false),
                    nota_fiscal_venda_pk_pedido = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_itens_venda", x => x.pk_item);
                    table.ForeignKey(
                        name: "FK_itens_venda_nota_fiscal_venda_nota_fiscal_venda_pk_pedido",
                        column: x => x.nota_fiscal_venda_pk_pedido,
                        principalTable: "nota_fiscal_venda",
                        principalColumn: "pk_pedido",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_itens_venda_produtos_produtos_pk_produtos",
                        column: x => x.produtos_pk_produtos,
                        principalTable: "produtos",
                        principalColumn: "pk_produtos",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "nota_fiscal_compra",
                columns: table => new
                {
                    pk_compra = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    quantidade = table.Column<int>(type: "INTEGER", nullable: false),
                    valor_unitario = table.Column<double>(type: "REAL", nullable: false),
                    valor_tot = table.Column<double>(type: "REAL", nullable: false),
                    produtos_pk_produtos = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_nota_fiscal_compra", x => x.pk_compra);
                    table.ForeignKey(
                        name: "FK_nota_fiscal_compra_produtos_produtos_pk_produtos",
                        column: x => x.produtos_pk_produtos,
                        principalTable: "produtos",
                        principalColumn: "pk_produtos",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "funcionarios",
                columns: table => new
                {
                    pk_funcionario = table.Column<string>(type: "TEXT", maxLength: 45, nullable: false),
                    nome = table.Column<string>(type: "TEXT", maxLength: 45, nullable: false),
                    fk_cargo = table.Column<int>(type: "INTEGER", nullable: false),
                    data_adm = table.Column<DateTime>(type: "TEXT", nullable: false),
                    data_dem = table.Column<DateTime>(type: "TEXT", nullable: false),
                    producao_pk_producao = table.Column<int>(type: "INTEGER", nullable: false),
                    nota_fiscal_venda_pk_pedido = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_funcionarios", x => x.pk_funcionario);
                    table.ForeignKey(
                        name: "FK_funcionarios_cargos_fk_cargo",
                        column: x => x.fk_cargo,
                        principalTable: "cargos",
                        principalColumn: "pk_cargos",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_funcionarios_nota_fiscal_venda_nota_fiscal_venda_pk_pedido",
                        column: x => x.nota_fiscal_venda_pk_pedido,
                        principalTable: "nota_fiscal_venda",
                        principalColumn: "pk_pedido",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_funcionarios_producao_producao_pk_producao",
                        column: x => x.producao_pk_producao,
                        principalTable: "producao",
                        principalColumn: "pk_producao",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "item_produzido",
                columns: table => new
                {
                    pk_item = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    quantidade = table.Column<int>(type: "INTEGER", nullable: false),
                    valor = table.Column<double>(type: "REAL", nullable: false),
                    data_validade = table.Column<DateTime>(type: "TEXT", nullable: true),
                    producao_pk_producao = table.Column<int>(type: "INTEGER", nullable: false),
                    producao_api_pk_api = table.Column<int>(type: "INTEGER", nullable: false),
                    producao_itens_receita_pk_itens = table.Column<int>(type: "INTEGER", nullable: false),
                    produtos_pk_produtos = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_item_produzido", x => x.pk_item);
                    table.ForeignKey(
                        name: "FK_item_produzido_api_producao_api_pk_api",
                        column: x => x.producao_api_pk_api,
                        principalTable: "api",
                        principalColumn: "pk_api",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_item_produzido_itens_receita_producao_itens_receita_pk_itens",
                        column: x => x.producao_itens_receita_pk_itens,
                        principalTable: "itens_receita",
                        principalColumn: "pk_itens",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_item_produzido_producao_producao_pk_producao",
                        column: x => x.producao_pk_producao,
                        principalTable: "producao",
                        principalColumn: "pk_producao",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_item_produzido_produtos_produtos_pk_produtos",
                        column: x => x.produtos_pk_produtos,
                        principalTable: "produtos",
                        principalColumn: "pk_produtos",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "relatorio_producao",
                columns: table => new
                {
                    pk_relatorio = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    data_relatorio = table.Column<DateTime>(type: "TEXT", nullable: false),
                    conteudo = table.Column<string>(type: "TEXT", maxLength: 245, nullable: false),
                    producao_pk_producao = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_relatorio_producao", x => x.pk_relatorio);
                    table.ForeignKey(
                        name: "FK_relatorio_producao_producao_producao_pk_producao",
                        column: x => x.producao_pk_producao,
                        principalTable: "producao",
                        principalColumn: "pk_producao",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "cliente",
                columns: table => new
                {
                    pk_cliente = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    razao_social = table.Column<string>(type: "TEXT", maxLength: 45, nullable: false),
                    endereco = table.Column<string>(type: "TEXT", maxLength: 45, nullable: false),
                    contato = table.Column<string>(type: "TEXT", maxLength: 15, nullable: false),
                    email = table.Column<string>(type: "TEXT", maxLength: 45, nullable: false),
                    nota_fiscal_venda_pk_pedido = table.Column<int>(type: "INTEGER", nullable: false),
                    status = table.Column<int>(type: "INTEGER", nullable: false),
                    funcionarios_pk_funcionario = table.Column<string>(type: "TEXT", maxLength: 45, nullable: false),
                    funcionarios_cargos_pk_cargos = table.Column<int>(type: "INTEGER", nullable: false),
                    funcionarios_producao_pk_producao = table.Column<int>(type: "INTEGER", nullable: false),
                    funcionarios_nota_fiscal_venda_pk_pedido = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cliente", x => x.pk_cliente);
                    table.ForeignKey(
                        name: "FK_cliente_cargos_funcionarios_cargos_pk_cargos",
                        column: x => x.funcionarios_cargos_pk_cargos,
                        principalTable: "cargos",
                        principalColumn: "pk_cargos",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_cliente_funcionarios_funcionarios_pk_funcionario",
                        column: x => x.funcionarios_pk_funcionario,
                        principalTable: "funcionarios",
                        principalColumn: "pk_funcionario",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_cliente_nota_fiscal_venda_funcionarios_nota_fiscal_venda_pk_pedido",
                        column: x => x.funcionarios_nota_fiscal_venda_pk_pedido,
                        principalTable: "nota_fiscal_venda",
                        principalColumn: "pk_pedido",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_cliente_nota_fiscal_venda_nota_fiscal_venda_pk_pedido",
                        column: x => x.nota_fiscal_venda_pk_pedido,
                        principalTable: "nota_fiscal_venda",
                        principalColumn: "pk_pedido",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_cliente_producao_funcionarios_producao_pk_producao",
                        column: x => x.funcionarios_producao_pk_producao,
                        principalTable: "producao",
                        principalColumn: "pk_producao",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "pagametos_contas",
                columns: table => new
                {
                    pk_pagamento = table.Column<string>(type: "TEXT", maxLength: 45, nullable: false),
                    valor = table.Column<double>(type: "REAL", nullable: false),
                    data_vencimento = table.Column<DateTime>(type: "TEXT", nullable: false),
                    funcionarios_pk_funcionario = table.Column<string>(type: "TEXT", maxLength: 45, nullable: false),
                    funcionarios_cargos_pk_cargos = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pagametos_contas", x => x.pk_pagamento);
                    table.ForeignKey(
                        name: "FK_pagametos_contas_cargos_funcionarios_cargos_pk_cargos",
                        column: x => x.funcionarios_cargos_pk_cargos,
                        principalTable: "cargos",
                        principalColumn: "pk_cargos",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_pagametos_contas_funcionarios_funcionarios_pk_funcionario",
                        column: x => x.funcionarios_pk_funcionario,
                        principalTable: "funcionarios",
                        principalColumn: "pk_funcionario",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "relatorio_venda",
                columns: table => new
                {
                    pk_relatorio = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    data = table.Column<DateTime>(type: "TEXT", nullable: false),
                    total_vendas = table.Column<int>(type: "INTEGER", nullable: false),
                    produtos_lista = table.Column<string>(type: "TEXT", maxLength: 45, nullable: false),
                    quantidade_produtos = table.Column<string>(type: "TEXT", maxLength: 45, nullable: false),
                    nota_fiscal_venda_pk_pedido = table.Column<int>(type: "INTEGER", nullable: false),
                    funcionarios_pk_funcionario = table.Column<string>(type: "TEXT", maxLength: 45, nullable: false),
                    funcionarios_cargos_pk_cargos = table.Column<int>(type: "INTEGER", nullable: false),
                    funcionarios_producao_pk_producao = table.Column<int>(type: "INTEGER", nullable: false),
                    funcionarios_nota_fiscal_venda_pk_pedido = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_relatorio_venda", x => x.pk_relatorio);
                    table.ForeignKey(
                        name: "FK_relatorio_venda_cargos_funcionarios_cargos_pk_cargos",
                        column: x => x.funcionarios_cargos_pk_cargos,
                        principalTable: "cargos",
                        principalColumn: "pk_cargos",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_relatorio_venda_funcionarios_funcionarios_pk_funcionario",
                        column: x => x.funcionarios_pk_funcionario,
                        principalTable: "funcionarios",
                        principalColumn: "pk_funcionario",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_relatorio_venda_nota_fiscal_venda_funcionarios_nota_fiscal_venda_pk_pedido",
                        column: x => x.funcionarios_nota_fiscal_venda_pk_pedido,
                        principalTable: "nota_fiscal_venda",
                        principalColumn: "pk_pedido",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_relatorio_venda_nota_fiscal_venda_nota_fiscal_venda_pk_pedido",
                        column: x => x.nota_fiscal_venda_pk_pedido,
                        principalTable: "nota_fiscal_venda",
                        principalColumn: "pk_pedido",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_relatorio_venda_producao_funcionarios_producao_pk_producao",
                        column: x => x.funcionarios_producao_pk_producao,
                        principalTable: "producao",
                        principalColumn: "pk_producao",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "recebe_contas",
                columns: table => new
                {
                    pk_conta = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    valor = table.Column<double>(type: "REAL", nullable: false),
                    data_vencimento = table.Column<DateTime>(type: "TEXT", nullable: false),
                    nota_fiscal_venda_pk_pedido = table.Column<int>(type: "INTEGER", nullable: false),
                    cliente_pk_cliente = table.Column<int>(type: "INTEGER", nullable: false),
                    funcionarios_pk_funcionario = table.Column<string>(type: "TEXT", maxLength: 45, nullable: false),
                    funcionarios_cargos_pk_cargos = table.Column<int>(type: "INTEGER", nullable: false),
                    funcionarios_producao_pk_producao = table.Column<int>(type: "INTEGER", nullable: false),
                    funcionarios_nota_fiscal_venda_pk_pedido = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_recebe_contas", x => x.pk_conta);
                    table.ForeignKey(
                        name: "FK_recebe_contas_cargos_funcionarios_cargos_pk_cargos",
                        column: x => x.funcionarios_cargos_pk_cargos,
                        principalTable: "cargos",
                        principalColumn: "pk_cargos",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_recebe_contas_cliente_cliente_pk_cliente",
                        column: x => x.cliente_pk_cliente,
                        principalTable: "cliente",
                        principalColumn: "pk_cliente",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_recebe_contas_funcionarios_funcionarios_pk_funcionario",
                        column: x => x.funcionarios_pk_funcionario,
                        principalTable: "funcionarios",
                        principalColumn: "pk_funcionario",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_recebe_contas_nota_fiscal_venda_funcionarios_nota_fiscal_venda_pk_pedido",
                        column: x => x.funcionarios_nota_fiscal_venda_pk_pedido,
                        principalTable: "nota_fiscal_venda",
                        principalColumn: "pk_pedido",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_recebe_contas_nota_fiscal_venda_nota_fiscal_venda_pk_pedido",
                        column: x => x.nota_fiscal_venda_pk_pedido,
                        principalTable: "nota_fiscal_venda",
                        principalColumn: "pk_pedido",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_recebe_contas_producao_funcionarios_producao_pk_producao",
                        column: x => x.funcionarios_producao_pk_producao,
                        principalTable: "producao",
                        principalColumn: "pk_producao",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ordem_compra",
                columns: table => new
                {
                    pk_compra = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    status = table.Column<string>(type: "TEXT", maxLength: 45, nullable: false),
                    funcionarios_pk_funcionario = table.Column<string>(type: "TEXT", maxLength: 45, nullable: false),
                    funcionarios_cargos_pk_cargos = table.Column<int>(type: "INTEGER", nullable: false),
                    fornecedor_pk_fornecedor = table.Column<string>(type: "TEXT", maxLength: 45, nullable: false),
                    pagemetos_contas_pk_pagamento = table.Column<string>(type: "TEXT", maxLength: 45, nullable: false),
                    nota_fiscal_compra_pk_compra = table.Column<int>(type: "INTEGER", nullable: false),
                    nota_fiscal_compra_produtos_pk_produtos = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ordem_compra", x => x.pk_compra);
                    table.ForeignKey(
                        name: "FK_ordem_compra_cargos_funcionarios_cargos_pk_cargos",
                        column: x => x.funcionarios_cargos_pk_cargos,
                        principalTable: "cargos",
                        principalColumn: "pk_cargos",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ordem_compra_fornecedor_fornecedor_pk_fornecedor",
                        column: x => x.fornecedor_pk_fornecedor,
                        principalTable: "fornecedor",
                        principalColumn: "pk_fornecedor",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ordem_compra_funcionarios_funcionarios_pk_funcionario",
                        column: x => x.funcionarios_pk_funcionario,
                        principalTable: "funcionarios",
                        principalColumn: "pk_funcionario",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ordem_compra_nota_fiscal_compra_nota_fiscal_compra_pk_compra",
                        column: x => x.nota_fiscal_compra_pk_compra,
                        principalTable: "nota_fiscal_compra",
                        principalColumn: "pk_compra",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ordem_compra_pagametos_contas_pagemetos_contas_pk_pagamento",
                        column: x => x.pagemetos_contas_pk_pagamento,
                        principalTable: "pagametos_contas",
                        principalColumn: "pk_pagamento",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ordem_compra_produtos_nota_fiscal_compra_produtos_pk_produtos",
                        column: x => x.nota_fiscal_compra_produtos_pk_produtos,
                        principalTable: "produtos",
                        principalColumn: "pk_produtos",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "formas_pagamentos",
                columns: table => new
                {
                    pk_formaPamento = table.Column<string>(type: "TEXT", maxLength: 45, nullable: false),
                    status = table.Column<string>(type: "TEXT", maxLength: 45, nullable: false),
                    valor = table.Column<double>(type: "REAL", nullable: false),
                    ordem_compra_pk_compra = table.Column<int>(type: "INTEGER", nullable: false),
                    ordem_compra_funcionarios_pk_funcionario = table.Column<string>(type: "TEXT", maxLength: 45, nullable: false),
                    ordem_compra_funcionarios_cargos_pk_cargos1 = table.Column<int>(type: "INTEGER", nullable: false),
                    nota_fiscal_venda_pk_pedido = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_formas_pagamentos", x => x.pk_formaPamento);
                    table.ForeignKey(
                        name: "FK_formas_pagamentos_cargos_ordem_compra_funcionarios_cargos_pk_cargos1",
                        column: x => x.ordem_compra_funcionarios_cargos_pk_cargos1,
                        principalTable: "cargos",
                        principalColumn: "pk_cargos",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_formas_pagamentos_funcionarios_ordem_compra_funcionarios_pk_funcionario",
                        column: x => x.ordem_compra_funcionarios_pk_funcionario,
                        principalTable: "funcionarios",
                        principalColumn: "pk_funcionario",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_formas_pagamentos_nota_fiscal_venda_nota_fiscal_venda_pk_pedido",
                        column: x => x.nota_fiscal_venda_pk_pedido,
                        principalTable: "nota_fiscal_venda",
                        principalColumn: "pk_pedido",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_formas_pagamentos_ordem_compra_ordem_compra_pk_compra",
                        column: x => x.ordem_compra_pk_compra,
                        principalTable: "ordem_compra",
                        principalColumn: "pk_compra",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_cliente_funcionarios_cargos_pk_cargos",
                table: "cliente",
                column: "funcionarios_cargos_pk_cargos");

            migrationBuilder.CreateIndex(
                name: "IX_cliente_funcionarios_nota_fiscal_venda_pk_pedido",
                table: "cliente",
                column: "funcionarios_nota_fiscal_venda_pk_pedido");

            migrationBuilder.CreateIndex(
                name: "IX_cliente_funcionarios_pk_funcionario",
                table: "cliente",
                column: "funcionarios_pk_funcionario");

            migrationBuilder.CreateIndex(
                name: "IX_cliente_funcionarios_producao_pk_producao",
                table: "cliente",
                column: "funcionarios_producao_pk_producao");

            migrationBuilder.CreateIndex(
                name: "IX_cliente_nota_fiscal_venda_pk_pedido",
                table: "cliente",
                column: "nota_fiscal_venda_pk_pedido");

            migrationBuilder.CreateIndex(
                name: "IX_formas_pagamentos_nota_fiscal_venda_pk_pedido",
                table: "formas_pagamentos",
                column: "nota_fiscal_venda_pk_pedido");

            migrationBuilder.CreateIndex(
                name: "IX_formas_pagamentos_ordem_compra_funcionarios_cargos_pk_cargos1",
                table: "formas_pagamentos",
                column: "ordem_compra_funcionarios_cargos_pk_cargos1");

            migrationBuilder.CreateIndex(
                name: "IX_formas_pagamentos_ordem_compra_funcionarios_pk_funcionario",
                table: "formas_pagamentos",
                column: "ordem_compra_funcionarios_pk_funcionario");

            migrationBuilder.CreateIndex(
                name: "IX_formas_pagamentos_ordem_compra_pk_compra",
                table: "formas_pagamentos",
                column: "ordem_compra_pk_compra");

            migrationBuilder.CreateIndex(
                name: "IX_funcionarios_fk_cargo",
                table: "funcionarios",
                column: "fk_cargo");

            migrationBuilder.CreateIndex(
                name: "IX_funcionarios_nota_fiscal_venda_pk_pedido",
                table: "funcionarios",
                column: "nota_fiscal_venda_pk_pedido");

            migrationBuilder.CreateIndex(
                name: "IX_funcionarios_producao_pk_producao",
                table: "funcionarios",
                column: "producao_pk_producao");

            migrationBuilder.CreateIndex(
                name: "IX_item_consumo_itens_receita_pk_itens",
                table: "item_consumo",
                column: "itens_receita_pk_itens");

            migrationBuilder.CreateIndex(
                name: "IX_item_consumo_produtos_pk_produtos",
                table: "item_consumo",
                column: "produtos_pk_produtos");

            migrationBuilder.CreateIndex(
                name: "IX_item_produzido_producao_api_pk_api",
                table: "item_produzido",
                column: "producao_api_pk_api");

            migrationBuilder.CreateIndex(
                name: "IX_item_produzido_producao_itens_receita_pk_itens",
                table: "item_produzido",
                column: "producao_itens_receita_pk_itens");

            migrationBuilder.CreateIndex(
                name: "IX_item_produzido_producao_pk_producao",
                table: "item_produzido",
                column: "producao_pk_producao");

            migrationBuilder.CreateIndex(
                name: "IX_item_produzido_produtos_pk_produtos",
                table: "item_produzido",
                column: "produtos_pk_produtos");

            migrationBuilder.CreateIndex(
                name: "IX_itens_venda_nota_fiscal_venda_pk_pedido",
                table: "itens_venda",
                column: "nota_fiscal_venda_pk_pedido");

            migrationBuilder.CreateIndex(
                name: "IX_itens_venda_produtos_pk_produtos",
                table: "itens_venda",
                column: "produtos_pk_produtos");

            migrationBuilder.CreateIndex(
                name: "IX_nota_fiscal_compra_produtos_pk_produtos",
                table: "nota_fiscal_compra",
                column: "produtos_pk_produtos");

            migrationBuilder.CreateIndex(
                name: "IX_ordem_compra_fornecedor_pk_fornecedor",
                table: "ordem_compra",
                column: "fornecedor_pk_fornecedor");

            migrationBuilder.CreateIndex(
                name: "IX_ordem_compra_funcionarios_cargos_pk_cargos",
                table: "ordem_compra",
                column: "funcionarios_cargos_pk_cargos");

            migrationBuilder.CreateIndex(
                name: "IX_ordem_compra_funcionarios_pk_funcionario",
                table: "ordem_compra",
                column: "funcionarios_pk_funcionario");

            migrationBuilder.CreateIndex(
                name: "IX_ordem_compra_nota_fiscal_compra_pk_compra",
                table: "ordem_compra",
                column: "nota_fiscal_compra_pk_compra");

            migrationBuilder.CreateIndex(
                name: "IX_ordem_compra_nota_fiscal_compra_produtos_pk_produtos",
                table: "ordem_compra",
                column: "nota_fiscal_compra_produtos_pk_produtos");

            migrationBuilder.CreateIndex(
                name: "IX_ordem_compra_pagemetos_contas_pk_pagamento",
                table: "ordem_compra",
                column: "pagemetos_contas_pk_pagamento");

            migrationBuilder.CreateIndex(
                name: "IX_pagametos_contas_funcionarios_cargos_pk_cargos",
                table: "pagametos_contas",
                column: "funcionarios_cargos_pk_cargos");

            migrationBuilder.CreateIndex(
                name: "IX_pagametos_contas_funcionarios_pk_funcionario",
                table: "pagametos_contas",
                column: "funcionarios_pk_funcionario");

            migrationBuilder.CreateIndex(
                name: "IX_producao_api_pk_api",
                table: "producao",
                column: "api_pk_api",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_producao_itens_receita_pk_itens",
                table: "producao",
                column: "itens_receita_pk_itens");

            migrationBuilder.CreateIndex(
                name: "IX_recebe_contas_cliente_pk_cliente",
                table: "recebe_contas",
                column: "cliente_pk_cliente");

            migrationBuilder.CreateIndex(
                name: "IX_recebe_contas_funcionarios_cargos_pk_cargos",
                table: "recebe_contas",
                column: "funcionarios_cargos_pk_cargos");

            migrationBuilder.CreateIndex(
                name: "IX_recebe_contas_funcionarios_nota_fiscal_venda_pk_pedido",
                table: "recebe_contas",
                column: "funcionarios_nota_fiscal_venda_pk_pedido");

            migrationBuilder.CreateIndex(
                name: "IX_recebe_contas_funcionarios_pk_funcionario",
                table: "recebe_contas",
                column: "funcionarios_pk_funcionario");

            migrationBuilder.CreateIndex(
                name: "IX_recebe_contas_funcionarios_producao_pk_producao",
                table: "recebe_contas",
                column: "funcionarios_producao_pk_producao");

            migrationBuilder.CreateIndex(
                name: "IX_recebe_contas_nota_fiscal_venda_pk_pedido",
                table: "recebe_contas",
                column: "nota_fiscal_venda_pk_pedido");

            migrationBuilder.CreateIndex(
                name: "IX_relatorio_producao_producao_pk_producao",
                table: "relatorio_producao",
                column: "producao_pk_producao");

            migrationBuilder.CreateIndex(
                name: "IX_relatorio_venda_funcionarios_cargos_pk_cargos",
                table: "relatorio_venda",
                column: "funcionarios_cargos_pk_cargos");

            migrationBuilder.CreateIndex(
                name: "IX_relatorio_venda_funcionarios_nota_fiscal_venda_pk_pedido",
                table: "relatorio_venda",
                column: "funcionarios_nota_fiscal_venda_pk_pedido");

            migrationBuilder.CreateIndex(
                name: "IX_relatorio_venda_funcionarios_pk_funcionario",
                table: "relatorio_venda",
                column: "funcionarios_pk_funcionario");

            migrationBuilder.CreateIndex(
                name: "IX_relatorio_venda_funcionarios_producao_pk_producao",
                table: "relatorio_venda",
                column: "funcionarios_producao_pk_producao");

            migrationBuilder.CreateIndex(
                name: "IX_relatorio_venda_nota_fiscal_venda_pk_pedido",
                table: "relatorio_venda",
                column: "nota_fiscal_venda_pk_pedido");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "formas_pagamentos");

            migrationBuilder.DropTable(
                name: "item_consumo");

            migrationBuilder.DropTable(
                name: "item_produzido");

            migrationBuilder.DropTable(
                name: "itens_venda");

            migrationBuilder.DropTable(
                name: "matriz_filial");

            migrationBuilder.DropTable(
                name: "recebe_contas");

            migrationBuilder.DropTable(
                name: "relatorio_producao");

            migrationBuilder.DropTable(
                name: "relatorio_venda");

            migrationBuilder.DropTable(
                name: "ordem_compra");

            migrationBuilder.DropTable(
                name: "cliente");

            migrationBuilder.DropTable(
                name: "fornecedor");

            migrationBuilder.DropTable(
                name: "nota_fiscal_compra");

            migrationBuilder.DropTable(
                name: "pagametos_contas");

            migrationBuilder.DropTable(
                name: "produtos");

            migrationBuilder.DropTable(
                name: "funcionarios");

            migrationBuilder.DropTable(
                name: "cargos");

            migrationBuilder.DropTable(
                name: "nota_fiscal_venda");

            migrationBuilder.DropTable(
                name: "producao");

            migrationBuilder.DropTable(
                name: "api");

            migrationBuilder.DropTable(
                name: "itens_receita");
        }
    }
}
