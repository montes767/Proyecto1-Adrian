
using Proyecto1_Adrian.Models;

namespace Proyecto1_Adrian.MVVM.View;

public partial class AgregarTarea : ContentPage
{
    private ListaTareasViewModel tareasViewModel;
    public AgregarTarea(ListaTareasViewModel viewModel)
	{
		InitializeComponent();
        tareasViewModel = viewModel;
	}

    private void Button_Clicked(object sender, EventArgs e)
    {


        Tareas nuevaTarea = new Tareas
        {
            nombre = entryNombre.Text,
            descripcion = entryDescripcion.Text,
            completada = switchCompletada.IsToggled
        };

        
        tareasViewModel.listaTareas.Add(nuevaTarea);



        Navigation.PopAsync();

    }
}