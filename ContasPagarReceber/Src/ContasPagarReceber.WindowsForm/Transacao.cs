using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    RECEITA,
    DESPESA
}
}
