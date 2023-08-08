using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Notas_app.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Principal : MasterDetailPage
    {
        public Principal()
        {
            InitializeComponent();
            botao_home_Clicked(new Object(), new EventArgs());
        }

        private void botao_home_Clicked(object sender, EventArgs e)
        {
            Detail=new NavigationPage( new Home());
            IsPresented = false;
        }

        private void botao_cadastrar_Clicked(object sender, EventArgs e)
        {

        }

        private void botao_localizar_Clicked(object sender, EventArgs e)
        {

        }

        private void botao_sobre_Clicked(object sender, EventArgs e)
        {

        }
    }
}