using CalculaJuros.Application.Model;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace CalculaJuros.Application.Service
{
    public class CalculoService
    {
        private readonly TaxaJurosIntegrationService _taxaJurosIntegration;

        public CalculoService(TaxaJurosIntegrationService taxaJurosIntegration)
        {
            _taxaJurosIntegration = taxaJurosIntegration;
        }
        public async Task<decimal> Calcular(CalculoModel model, CancellationToken ct = default)
        {
            ct.ThrowIfCancellationRequested();
            var juros = await _taxaJurosIntegration.GetTaxaJuros(ct);
            var jurosComposto = model.ValorInicial * (decimal)Math.Pow(1 + juros, model.Tempo);
            return FormataDecimal(jurosComposto);
        }

        private decimal FormataDecimal(decimal valor)
        {
            return Math.Truncate(100 * valor) / 100;
        }

    }
}
