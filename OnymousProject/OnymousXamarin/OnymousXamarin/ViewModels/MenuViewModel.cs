using GalaSoft.MvvmLight.Command;
using System.Windows.Input;

namespace OnymousXamarin.ViewModels
{
    public class MenuViewModel : BaseViewModel
    {
        #region Atributos
        private string _image { get; set; }
        public string Image
        {
            get
            {
                return this._image;
            }
            set
            {
                if (value != _image)
                {
                    _image = value;
                    OnPropertyChanged();
                }
            }
        }

        private string _nombreEmpleado { get; set; }
        public string NombreEmpleado
        {
            get
            {
                return this._nombreEmpleado;
            }
            set
            {
                if (value != _nombreEmpleado)
                {
                    _nombreEmpleado = value;
                    OnPropertyChanged();
                }
            }
        }
        #endregion

        #region Propiedades
        public string Icon { get; set; }

        public string Title { get; set; }

        public string Navigation { get; set; }

        public ICommand CommandNavigation { get { return new RelayCommand<string>(NavigationC); } }
        #endregion

        #region Constructor
        public MenuViewModel()
        {
            EmployeeLoad();
        }

        #endregion

        #region Metodos
        private void EmployeeLoad()
        {
        }
        #endregion

        #region Comandos
        private void NavigationC(string tipo)
        {
            switch (tipo)
            {
                case "Configuracion":
                    break;
                case "Menu":
                    break;
                default:
                    break;
            }
        }
        #endregion
    }
}
