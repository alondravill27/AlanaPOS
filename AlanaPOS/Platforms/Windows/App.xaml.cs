using Microsoft.Maui;
using Microsoft.Maui.Hosting;

namespace AlanaPOS.WinUI; // Volvemos al namespace correcto de la plataforma

/// <summary>
/// Proporciona un comportamiento específico de la aplicación para complementar la clase Application predeterminada.
/// </summary>
public partial class App : MauiWinUIApplication
{
    /// <summary>
    /// Inicializa el objeto de aplicación de destino.
    /// </summary>
    public App()
    {
        // ELIMINAMOS this.InitializeComponent() de aquí para evitar el error CS0111
    }

    protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
}