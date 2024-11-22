using ManejoDeDatosMAUI.Modelos;
using ManejoDeDatosMAUI.Repositories;

namespace ManejoDeDatosMAUI
{
    public partial class MainPage : ContentPage
    {
        public EstudianteUDLA estudiante;
        EstudianteUDLAFilesRepository _repository;

        public MainPage()
        {
            InitializeComponent();
            _repository = new EstudianteUDLAFilesRepository();
            estudiante = _repository.DevuelveInfoEstudianteUDLA(1);

            BindingContext = estudiante;
        }

        private void BotonGuardarEstudiante_Clicked(object sender, EventArgs e)
        {
            EstudianteUDLA estudiante = new EstudianteUDLA
            {
                Id = 10,
                Nombre = "Dilan Herrera",
                Carrera = "Ingenieria en Software"
            };
            _repository.CrearEstudianteUDLA(estudiante);

            bool crear_estuidante = _repository.CrearEstudianteUDLA(estudiante);

        }
    }

}
