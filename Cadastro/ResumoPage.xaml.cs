using Cadastro;

namespace Cadastro
{
    public partial class ResumoPage : ContentPage
    {
        public Evento Evento { get; set; }

        public ResumoPage(Evento evento)
        {
            InitializeComponent();
            Evento = evento;
            BindingContext = this;
        }
    }
}