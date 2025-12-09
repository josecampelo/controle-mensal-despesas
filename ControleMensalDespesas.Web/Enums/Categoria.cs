namespace ControleMensalDespesas.Web.Enums;

/// <summary>
/// Define as categorias para classificação das despesas no sistema.
/// <para>
/// As categorias são agrupadas por faixas numéricas para facilitar a organização.
/// </para>
/// </summary>
public enum Categoria
{
    // --- Moradia e Contas Fixas (1-19) ---

    /// <summary>
    /// Gastos gerais de habitação, como Aluguel, Condomínio ou Reformas.
    /// </summary>
    Casa = 1,

    /// <summary>
    /// Conta de energia elétrica.
    /// </summary>
    Luz = 2,

    /// <summary>
    /// Conta de água e esgoto (SABESP, etc).
    /// </summary>
    Agua = 3,

    /// <summary>
    /// Gás encanado ou botijão.
    /// </summary>
    Gas = 4,

    /// <summary>
    /// Banda larga fixa ou fibra óptica.
    /// </summary>
    Internet = 5,

    /// <summary>
    /// Imposto Predial e Territorial Urbano.
    /// </summary>
    IPTU = 6,

    // --- Alimentação (20-29) ---

    /// <summary>
    /// Gastos gerais com comida (restaurantes, lanches na rua).
    /// </summary>
    Alimentacao = 20,

    /// <summary>
    /// Compras de mês ou semanais em supermercados/atacados.
    /// </summary>
    Mercado = 21,

    /// <summary>
    /// Pedidos de delivery.
    /// </summary>
    Ifood = 22,

    // --- Transporte (30-39) ---

    /// <summary>
    /// Ônibus, Metrô, Trem ou recargas de bilhete único.
    /// </summary>
    TransportePublico = 30,

    /// <summary>
    /// Transporte por aplicativo (Uber).
    /// </summary>
    Uber = 31,

    /// <summary>
    /// Transporte por aplicativo (99).
    /// </summary>
    NoveNove = 32,

    // --- Educação (40-49) ---

    /// <summary>
    /// Gastos gerais com ensino (Material escolar, livros).
    /// </summary>
    Educacao = 40,

    /// <summary>
    /// Mensalidade da Faculdade.
    /// </summary>
    Faculdade = 41,

    /// <summary>
    /// Cursos livres, idiomas ou especializações.
    /// </summary>
    Curso = 42,

    // --- Lazer e Estilo de Vida (50-59) ---

    /// <summary>
    /// Cinema, passeios, viagens e entretenimento geral.
    /// </summary>
    Lazer = 50,

    /// <summary>
    /// Mensalidade de academia ou esportes.
    /// </summary>
    Academia = 51,

    /// <summary>
    /// Compra de vestuário e acessórios.
    /// </summary>
    Roupa = 52,

    // --- Tecnologia e Assinaturas (60-69) ---

    /// <summary>
    /// Peças de computador, periféricos e eletrônicos físicos.
    /// </summary>
    Hardware = 60,

    /// <summary>
    /// Licenças de programas, jogos ou aplicativos pagos.
    /// </summary>
    Software = 61,

    /// <summary>
    /// Serviços de streaming.
    /// </summary>
    Streaming = 62,

    /// <summary>
    /// Assinatura do YouTube Premium.
    /// </summary>
    YoutubePremium = 63,

    /// <summary>
    /// Assinatura da Netflix.
    /// </summary>
    Netflix = 64,

    /// <summary>
    /// Assinatura da HBO Max.
    /// </summary>
    HboMax = 65,

    /// <summary>
    /// Assinatura do Amazon Prime Video.
    /// </summary>
    PrimeVideo = 66,

    // --- Financeiro (70-79) ---

    /// <summary>
    /// Pagamento da fatura total do cartão de crédito.
    /// </summary>
    CartaoCredito = 70,

    /// <summary>
    /// Taxas anuais de cartões ou serviços bancários.
    /// </summary>
    Anuidade = 71,

    // --- Diversos ---

    /// <summary>
    /// Gastos que não se enquadram em nenhuma outra categoria.
    /// </summary>
    Outros = 99
}