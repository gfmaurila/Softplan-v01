using Softplan.Service.Dtos;
using Softplan.Service.Interfaces;
using System;

namespace Softplan.Service.Services
{
    public class SoftplanService : ISoftplanService
    {
        public TaxaJurosDto TaxaJuros(TaxaJurosDto dto)
        {
            return dto;
        }
    }
}
