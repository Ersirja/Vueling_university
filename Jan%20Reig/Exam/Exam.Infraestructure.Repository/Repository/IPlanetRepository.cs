
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1.Library.Models;


namespace Exam.ServiceLibrary.Contracts.Repository
{
    public interface IPlanetRepository
    {
        List<Planet> GetPlanets();
    }
}
