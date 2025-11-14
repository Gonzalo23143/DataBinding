
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;


namespace Databinding.Coleccion.Models
{
     public class OrigenDePaquete :INotifyPropertyChanged
    {
        //public string Nombre { get; set; } = string.Empty;
        //public string Origen { get; set; } = string.Empty;
        //public bool EstadoHabilitado { get; set; } = false;

        private string? _nomnbre = string.Empty;
        private string? _origen = string.Empty;
        private bool _estaHabilitado = false;


        public string? Nombre
        {

            get => _nomnbre;
            set
            {

                if (value != _nomnbre)
                {
                    _nomnbre = value;
                    OnPropertyChanged(nameof(Nombre));
                }

            }
        }



        public string? Origen
        {
            get => _origen;
            set
            {
                if (value != _origen)
                {
                    _origen = value;
                    OnPropertyChanged(nameof(Origen));
                }
            }
        }



        public bool EstaHabilitado
        {


            get => _estaHabilitado;
            set
            {
                if (value != _estaHabilitado)
                {
                    _estaHabilitado = value;
                    OnPropertyChanged(nameof(EstaHabilitado));

                }
            }
        }
        public event PropertyChangedEventHandler? PropertyChanged;

        public override string ToString()
        {
            return $"{Nombre}, {Origen}";
        }


        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(
                this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
