using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using System.Threading.Tasks;

namespace Exam.ServiceLibrary.Contracts.Interfaces
{
    public interface IRebelInfluenceService
    {
        Dictionary<string, decimal> GetRebelInfluence();
    }
}
