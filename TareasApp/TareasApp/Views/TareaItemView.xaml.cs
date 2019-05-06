using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TareasApp.Model;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TareasApp.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TareaItemView : ContentPage
	{
		public TareaItemView ()
		{
			InitializeComponent ();
		}

        private void OnTodoItemAdded_Clicked(object sender, EventArgs e)
        {
            Tarea NuevaTarea = (Tarea)BindingContext;

            // Repositorio
            Repositorio R = new Repositorio();
            int Resultado = R.CrearTarea(NuevaTarea);

            if (Resultado == 1)
            {
                DisplayAlert(
                    "Registro", $"Tarea guardada, ID:{NuevaTarea.ID}", "Ok");

                Navigation.PopAsync();
            }
        }

        private void BtnActualizar_Clicked(object sender, EventArgs e)
        {

        }
    }
}