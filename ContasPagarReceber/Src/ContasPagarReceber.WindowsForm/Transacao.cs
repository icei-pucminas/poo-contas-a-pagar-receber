using System;

namespace ContasPagarReceber.WindowsForm
{
    public class Transacao
{
    public Guid Identificador { get; set; }
    public decimal Valor { get; set; }

    public string Descricao { get; set; }
    public DateTime DataVencimento { get; set; }
    public DateTime DataPagamento { get; set; }
    public TipoTransacao Tipo { get; set; }
}

public enum TipoTransacao
{
    RECEITA = 0,
    DESPESA = 1
}
}
