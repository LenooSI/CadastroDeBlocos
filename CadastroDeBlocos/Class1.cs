using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDeBlocos
{
    internal class Class1
    {
    }
}
// Criando uma classe para guardar informações sobre os blocos
class Bloco
{
    public int Codigo { get; set; }
    public string? NumeroBloco { get; set; }
    public double Medidas { get; set; }
    public string? Descricao { get; set; }
    public string? TipoMaterial { get; set; }
    public double ValorCompra { get; set; }
    public double ValorVenda { get; set; }
    public string? Pedreira { get; set; }
}

