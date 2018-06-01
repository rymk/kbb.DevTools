using Kbb.DevTools.Domain.Models;
using System.Collections.Generic;

namespace Kbb.DevTools.Domain.Contracts
{
    public interface IReturnService
    {
        IEnumerable<Return> GetAll();
    }
}
