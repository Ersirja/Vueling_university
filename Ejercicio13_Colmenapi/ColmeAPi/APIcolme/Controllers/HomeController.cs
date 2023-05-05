using ColmeApi.Infraestructure.Interface;
using Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using ColmeApi.Infraestructure;
using HttpGetAttribute = System.Web.Mvc.HttpGetAttribute;

namespace APIcolme.Controllers
{
    public class AbejaController : ApiController
    {
        private readonly IAbejaRepository _abejaRepository;

        public AbejaController(IAbejaRepository abejaRepository)
        {
            _abejaRepository = abejaRepository;
        }

        // GET api/abeja
        public IEnumerable<Abeja> Get()
        {
            return _abejaRepository.ObtenerAbejas();
        }

        // GET api/abeja/estado/true
        [HttpGet]
        [System.Web.Http.Route("api/abeja/estado/{estado}")]
        public IEnumerable<Abeja> ObtenerPorEstado(bool estado)
        {
            return _abejaRepository.ObtenerAbejasPorEstado(estado);
        }

        // GET api/abeja/incidentes/3
        [HttpGet]
        [System.Web.Http.Route("api/abeja/incidentes/{incidentes}")]
        public IEnumerable<Abeja> ObtenerPorIncidentes(int incidentes)
        {
            return _abejaRepository.ObtenerAbejasPorIncidentes(incidentes);
        }
    }
}