using PropertyChanged;
using Proyecto1_Adrian.Models;
using Proyecto1_Adrian.MVVM.View;


namespace Proyecto1_Adrian.MVVM;
[AddINotifyPropertyChangedInterface]
public partial class ListaTareasView : ContentPage
{

    private ListaTareasViewModel listaViewModel;
    public ListaTareasView()
    {
        InitializeComponent();
        listaViewModel = new ListaTareasViewModel();
        BindingContext = listaViewModel;

    }

    private async void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        if (e.CurrentSelection.FirstOrDefault() is Tareas tareaSeleccionada)
        {
            await Navigation.PushAsync(new TareasDetalladasView(tareaSeleccionada));
        }


        ((CollectionView)sender).SelectedItem = null;
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        //Exclamacion porque no puedes pasarle un null al constructor
        Navigation.PushAsync(new AgregarTarea(listaViewModel!));
    }
}





