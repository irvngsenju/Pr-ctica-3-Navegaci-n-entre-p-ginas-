using NavegacionMaui_IAGM.Views;
namespace NavegacionMaui_IAGM
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            // Asociamos un nombre de ruta con una clase de página.
            Routing.RegisterRoute("informacion", typeof(InformacionPage));
        }
    }
}
