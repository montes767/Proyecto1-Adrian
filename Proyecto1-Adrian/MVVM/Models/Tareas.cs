using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1_Adrian.Models
{
    public class Tareas : INotifyPropertyChanged
    {
        private string nombreP {  get; set; }= string.Empty;
        private  string descripcionP {  get; set; }= string.Empty;
        private bool completadaP {  get; set; }= false;


        public string nombre
        {
            get => nombreP;
            set
            {
                if (nombreP != value)
                {
                    nombreP = value;
                    OnPropertyChanged(nameof(nombreP));
                }
            }
        }

        public bool completada
        {
            get => completadaP;
            set
            {
                if (completadaP != value)
                {
                    completadaP = value;
                    OnPropertyChanged(nameof(completadaP));
                }
            }
        }

        public string descripcion
        {
            get => descripcionP;
            set
            {
                if (descripcionP != value)
                {
                    descripcionP = value;
                    OnPropertyChanged(nameof(descripcionP));
                }
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
