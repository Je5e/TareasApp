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
	public partial class TareasListView : ContentPage
	{
        List<Tarea> Tareas = new List<Tarea>();

        public TareasListView ()
		{
			InitializeComponent ();
		}

        protected override void OnAppearing()
        {
            base.OnAppearing();

            Repositorio R = new Repositorio();
            List<Tarea> Resultado = R.ObtenerTodasLasTareas();
            ListViewTareas.ItemsSource = Resultado;
        }

        private void OnItemAdded(Object sender, EventArgs e)
        {
            Navigation.PushAsync(new Views.TareaItemView
            {
                BindingContext  = new Model.Tarea()
            });
        }

        private void ListViewItems_ItemSelected
            (object sender, SelectedItemChangedEventArgs e)
        {
            Tarea Tarea = e.SelectedItem as Tarea;
            if (Tarea !=null)
            {
                Navigation.PushAsync
                    (new TareaItemView { BindingContext = Tarea });
            }
        }
    }
}