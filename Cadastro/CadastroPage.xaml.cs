using Cadastro;

namespace Cadastro
{
    public partial class CadastroPage : ContentPage
    {
        public Evento Evento { get; set; }

        public CadastroPage()
        {
            InitializeComponent();
            Evento = new Evento();
            BindingContext = Evento;
        }

        private async void OnCadastrarClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ResumoPage(Evento));
        }
    }
}