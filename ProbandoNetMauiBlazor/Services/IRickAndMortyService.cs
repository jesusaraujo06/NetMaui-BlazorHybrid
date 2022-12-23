using ProbandoNetMauiBlazor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProbandoNetMauiBlazor.Services
{
    internal interface IRickAndMortyService
    {
        public Task<RickAndMorty> Get();
    }
}
