namespace loginM;
public partial class Protegida : ContentPage
{
    private object lbl_boasvindas;

    public Protegida()
    {
        InitializeComponent();

        string? usuario_logado = null;

        Task.Run(async () =>
        {
            usuario_logado = await SecureStorage.Default.GetAsync("usuario_logado");
            lbl_boasvindas = $"Bem-vindo (a) {usuario_logado}";
        });
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        bool confirmacao = await DisplayAlert("Tem Certeza?", "Sair da conta?", "Sim", "Não");

        if (confirmacao)
        {
            SecureStorage.Default.Remove("usuario_logado");
            App.Current.MainPage = new Login();
        }
    }
}