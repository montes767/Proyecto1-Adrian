using Proyecto1_Adrian.Models;
using PropertyChanged;
using Microsoft.Maui.Controls;
using Proyecto1_Adrian.MVVM.View;
using System.Windows.Input;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Proyecto1_Adrian.MVVM
{
    [AddINotifyPropertyChangedInterface]
    public class ListaTareasViewModel
    {
      

        public ObservableCollection<Tareas> listaTareas { get; set; } = new ObservableCollection<Tareas>
        {
            new Tareas()
            {
                nombre = ".net maui",
                descripcion ="proyecto en .net maui de tareas",
                completada = true
            },
            new Tareas()
            {
                nombre = "sacar la basura",
                descripcion = "sacar la basura antes de que lleguen los invitados",
                completada = false
            },
            new Tareas()
            {
                nombre = "historia",
                descripcion = "",
                completada = true
            },
            new Tareas()
            {
                nombre = "ingles",
                descripcion ="b2",
                completada = false
            }

    };
        

        public ICommand deleteComand => new Command((tarea) =>
        {
            if (tarea is Tareas t)
            {
                listaTareas.Remove(t);   
            }
        });


        
        
    }
}