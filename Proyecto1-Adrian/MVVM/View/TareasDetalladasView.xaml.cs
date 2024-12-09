using Proyecto1_Adrian.Models;

namespace Proyecto1_Adrian.MVVM.View;

public partial class TareasDetalladasView : ContentPage
{
	private Tareas tarea;
	

	
	public TareasDetalladasView(Tareas t)
	{
        InitializeComponent();
		BindingContext = tarea;
        tarea = t;
        entryNombre.Text = tarea?.nombre;
        switchCompletada.IsToggled = tarea.completada;
        entryDescripcion.Text = tarea?.descripcion;
    }
    

    private async void Button_Clicked(object sender, EventArgs e)
    {

        tarea.nombre = entryNombre.Text;
        tarea.completada = switchCompletada.IsToggled;
        tarea.descripcion = entryDescripcion.Text;
        await Navigation.PopAsync();
    }
}