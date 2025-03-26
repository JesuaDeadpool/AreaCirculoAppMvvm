using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCirculoAppMvvm.ViewModel
{
    public partial class AreaCirculoViewModel : ObservableObject
    {
        [ObservableProperty]
        private double radio;

        [ObservableProperty]
        private double area;


        [RelayCommand]
        private void Calcular()
        {
            try
            {
                if(Radio < 1)
                {
                    Alerta("ADVERTENCIA", "El Radio no puede ser igual a cero o negativo"); 
                }
                else
                {

                    Area = Math.PI * Math.Pow(Radio, 2); 


                }


            }catch (Exception e)
            {
                Alerta("ERROR", e.Message); 
            }
        }


        [RelayCommand]
        private void Limpiar()
        {

            Radio = 0;
            Area = 0; 
        }



        private void Alerta(string Titulo, string Mensaje)
        {
            MainThread.BeginInvokeOnMainThread(async () => await App.Current!.MainPage!.DisplayAlert(Titulo, Mensaje, "Aceptar"));
        }


    }
}
