using ControleMensalDespesas.Web.Enums;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ControleMensalDespesas.Web.Models;

/// <summary>
/// Representa uma despesa financeira (conta a pagar) dentro do sistema.
/// </summary>
public class Despesa
{
    /// <summary>
    /// Identificador único da despesa no banco de dados.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// O título ou descrição curta da despesa (ex: "Conta de Luz", "Academia").
    /// </summary>
    [DisplayName("Nome")]
    [Required(ErrorMessage = "O campo {0} é obrigatório.")]
    [StringLength(100, ErrorMessage = "O {0} deve ter no máximo {1} caracteres.")]
    public string Nome { get; set; }

    /// <summary>
    /// A classificação da despesa para fins de agrupamento e relatórios.
    /// </summary>
    [Required(ErrorMessage = "O campo {0} é obrigatório.")]
    public Categoria Categoria { get; set; }

    /// <summary>
    /// O valor monetário da despesa.
    /// </summary>
    [DisplayName("Valor")]
    [Required(ErrorMessage = "O campo {0} é obrigatório.")]
    [Range(0.01, 99999999, ErrorMessage = "O {0} deve ser maior que zero.")]
    [Column(TypeName = "decimal(18,2)")]
    [DataType(DataType.Currency)]
    public decimal Valor { get; set; }

    /// <summary>
    /// Indica se a despesa já foi quitada.
    /// </summary>
    [DisplayName("Pago?")]
    public bool EstaPago { get; set; }

    /// <summary>
    /// A data limite para o pagamento ou a data de referência da despesa.
    /// </summary>
    [DisplayName("Data de Vencimento")]
    [Required(ErrorMessage = "O campo {0} é obrigatório.")]
    [DataType(DataType.Date)]
    public DateTime DataVencimento { get; set; }

    /// <summary>
    /// (Opcional) O número da parcela atual, caso seja uma compra parcelada.
    /// </summary>
    [DisplayName("Parcela Atual")]
    [Range(1, 100, ErrorMessage = "A {0} deve ser maior que 0.")]
    public int? ParcelaAtual { get; set; }

    /// <summary>
    /// (Opcional) A quantidade total de parcelas.
    /// </summary>
    [DisplayName("Total de Parcelas")]
    [Range(1, 100, ErrorMessage = "O {0} deve ser maior que 0.")]
    public int? TotalParcelas { get; set; }
}