using System.Threading;
using System.Threading.Tasks;
using TaxaJuros.Domain.Entities;

namespace TaxaJuros.Application.Service
{
    public class TaxaJurosService
    {
        public async Task<double> ObterTaxaJuros(CancellationToken ct)
        {
            ct.ThrowIfCancellationRequested();

            var model = new Juros();
            return model.Valor;
        }

    }
}
