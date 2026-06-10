using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace AlanaPOS.ViewModels;

// Estructura auxiliar para que no te marque error en la línea 41
public class TopProductoItem
{
    public string Nombre { get; set; } = string.Empty;
    public string Categoria { get; set; } = string.Empty;
    public int Stock { get; set; }
    public string Precio { get; set; } = string.Empty;
    public string Estado { get; set; } = string.Empty;

    public decimal TotalVentas { get; set; }
}

public partial class DashboardViewModel : ObservableObject
{
    // Propiedades con [ObservableProperty]
    // genera automáticamente el INotifyPropertyChanged

    [ObservableProperty]
    private string _ventasTotales = "$0";

    [ObservableProperty]
    private string _ventasTendencia = "↑ 0%";

    [ObservableProperty]
    private string _totalTransacciones = "0";

    [ObservableProperty]
    private string _transTendencia = "↑ 0%";

    [ObservableProperty]
    private string _clientesActivos = "0";

    [ObservableProperty]
    private string _clientesSub = "0 nuevos hoy";

    [ObservableProperty]
    private int _productosStockBajo = 0;

    [ObservableProperty]
    private string _fechaHoy = DateTime.Now.ToString("dddd, d 'de' MMMM yyyy");

    [ObservableProperty]
    private string _periodoSeleccionado = "Hoy";

    // CORREGIDO: Sintaxis correcta de inicialización de listas
    public List<string> Periodos { get; set; } = new() { "Hoy", "Semana", "Mes", "Año" };

    // CORREGIDO: Ya reconoce el modelo gracias a la clase definida arriba
    public ObservableCollection<TopProductoItem> TopProductos { get; set; } = new();

    public DashboardViewModel()
    {
        // Aquí puedes meter datos de prueba si quieres más adelante
    }
}