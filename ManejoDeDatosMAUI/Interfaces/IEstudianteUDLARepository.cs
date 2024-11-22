using ManejoDeDatosMAUI.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoDeDatosMAUI.Interfaces
{
    public interface IEstudianteUDLARepository
    {
        List<EstudianteUDLA> DevuelveListadoEstudianteUDLA();
        EstudianteUDLA DevuelveInfoEstudianteUDLA(int Id);
        Boolean CrearEstudianteUDLA(EstudianteUDLA estudiantes);
        Boolean ActualiarEstudianteUDLA(EstudianteUDLA estudiantes);
        Boolean EliminarEstudianteUdla(int Id);
    }
}
