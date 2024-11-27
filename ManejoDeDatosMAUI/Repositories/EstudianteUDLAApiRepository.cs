using ManejoDeDatosMAUI.Interfaces;
using ManejoDeDatosMAUI.Modelos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoDeDatosMAUI.Repositories
{
    public class EstudianteUDLAApiRepository : IEstudianteUDLARepository
    {
        public HttpClient _httpClient;
        public string endpoint = "https://freetestapi.com/api/v1/students";
        public EstudianteUDLAApiRepository()
        {
            _httpClient = new HttpClient();
        }
        public bool ActualiarEstudianteUDLA(EstudianteUDLA estudiantes)
        {
            throw new NotImplementedException();
        }

        public bool CrearEstudianteUDLA(EstudianteUDLA estudiantes)
        {
            throw new NotImplementedException();
        }

        public EstudianteUDLA DevuelveInfoEstudianteUDLA(int Id)
        {
            throw new NotImplementedException();
        }

        public List<EstudianteUDLA> DevuelveListadoEstudianteUDLA()
        {
            List < EstudianteUDLA > estudiantesUDLA = new List<EstudianteUDLA> ();
            using (_httpClient) 
            {
                var response = _httpClient.GetAsync(endpoint).Result;
                string json_data = response.Content.ReadAsStringAsync().Result;

                List<EstudianteAPI> estudianteAPI = new List<EstudianteAPI> ();
                 estudianteAPI = JsonConvert.DeserializeObject<List<EstudianteAPI>> (json_data);

                estudiantesUDLA = estudianteAPI.Select(item => new EstudianteUDLA
                {
                    Id = item.id,
                    Nombre = item.name,
                    Carrera = "Carrera de test"
                }).ToList();
            }

            return estudiantesUDLA;
        }

        public bool EliminarEstudianteUdla(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
