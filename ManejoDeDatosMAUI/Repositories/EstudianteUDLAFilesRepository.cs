using ManejoDeDatosMAUI.Interfaces;
using ManejoDeDatosMAUI.Modelos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ManejoDeDatosMAUI.Repositories
{
    internal class EstudianteUDLAFilesRepository : IEstudianteUDLARepository
    {
        public string _fileName = Path.Combine(FileSystem.AppDataDirectory, "estudiantes.txt");
        public bool ActualiarEstudianteUDLA(EstudianteUDLA estudiantes)
        {
            throw new NotImplementedException();
        }

        public bool CrearEstudianteUDLA(EstudianteUDLA estudiantes)
        {
            try
            {
                string estudiante_json = JsonConvert.SerializeObject(estudiantes);
                File.WriteAllText(_fileName, estudiante_json);
                return true;
            }
             catch(Exception e)
            {
                throw;
            }
        }

        public EstudianteUDLA DevuelveInfoEstudianteUDLA(int Id)
        {
            EstudianteUDLA estudiante = new EstudianteUDLA(); 
            if (File.Exists(_fileName))
            {
                string data = File.ReadAllText(_fileName);
                estudiante = JsonConvert.DeserializeObject<EstudianteUDLA>(data);
            }
            return estudiante;
        }

        public List<EstudianteUDLA> DevuelveListadoEstudianteUDLA()
        {
            List<EstudianteUDLA> estudianteUDLA = new List<EstudianteUDLA>();
            estudianteUDLA.Add(DevuelveInfoEstudianteUDLA(1));
            estudianteUDLA.Add(DevuelveInfoEstudianteUDLA(2));
            estudianteUDLA.Add(DevuelveInfoEstudianteUDLA(3));
            return estudianteUDLA;
        }

        public bool EliminarEstudianteUdla(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
