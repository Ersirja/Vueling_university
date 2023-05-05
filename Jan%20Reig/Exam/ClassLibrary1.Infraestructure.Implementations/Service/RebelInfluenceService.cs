using ClassLibrary1.Library.Models;
using Exam.ServiceLibrary.Contracts.Interfaces;
using Exam.ServiceLibrary.Contracts.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ClassLibrary1.Infraestructure.Implementations.Service
{
    public class RebelInfluenceService : IRebelInfluenceService
    {
        private readonly ISpyReportRepository _spyReportRepository;

        public RebelInfluenceService(ISpyReportRepository spyReportRepository)
        {
            _spyReportRepository = spyReportRepository;
        }

        public Dictionary<string, decimal> GetRebelInfluence()
        {
            var spyReports = _spyReportRepository.GetAllSpyReports();
            var rebelInfluence = new Dictionary<string, decimal>();

            foreach (var spyReport in spyReports)
            {
                var planetName = spyReport.PlanetName;
                var influence = spyReport.RebelInfluence;

                if (rebelInfluence.ContainsKey(planetName))
                {
                    rebelInfluence[planetName] += influence;
                }
                else
                {
                    rebelInfluence.Add(planetName, influence);
                }
            }

            return rebelInfluence;
        }
    }
}
