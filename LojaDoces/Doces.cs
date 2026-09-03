

namespace LojaDoces
{
    class Doces
    {
        //PROPRIEDADES(ATRIBUTOS)
        public string? Confeiteiro {  get; set; }
        public double CapacidadeKg { get; set; }
        public double PorcentagemPronta { get; set; }
        public double TaxaProdutoPorHora {  get; set; }

        public double CalcularKgFaltantes()
        {
            double porcentagemFaltate = (100.0 - PorcentagemPronta) / 100.0;
            return CapacidadeKg * porcentagemFaltate;
        }

        public double CalcularTempoRestanteHoras() 
        {
            return CalcularTempoRestanteHoras() / TaxaProdutoPorHora;
        }

        public double CalcularValorFaltante() 
        { 
            const double PRECO_POR_KG = 45.50;
            return CalcularKgFaltantes() * PRECO_POR_KG;
        }
        
    }
}
