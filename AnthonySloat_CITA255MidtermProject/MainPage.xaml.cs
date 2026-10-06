namespace AnthonySloat_CITA255MidtermProject
{
    public partial class MainPage : ContentPage
    {
        List<string> products =
        [
            "ZEZTZ Driver",
            "Chicken Sandwich",
            "The Literal Keyblade",
            "Mysterious Liquid"
        ];

        public MainPage()
        {
            InitializeComponent();
            productList.ItemsSource = products;
        }

        private async void OnProductSelected(object sender, SelectionChangedEventArgs e) //Second argument is how we get the information
        {
            if (e.CurrentSelection.Count > 0) // How we check if the input is null
            {
                string picked = e.CurrentSelection[0].ToString();

                productList.SelectedItem = null;

                if (picked == "ZEZTZ Driver")
                {
                    await Shell.Current.GoToAsync("ZEZTZpage");
                }
                else if (picked == "Chicken Sandwich")
                {
                    await Shell.Current.GoToAsync("chickenpage");
                }
                else if (picked == "The Literal Keyblade")
                {
                    await Shell.Current.GoToAsync("keybladepage");
                }
                else if (picked == "Mysterious Liquid")
                {
                    await Shell.Current.GoToAsync("liquidpage");
                }
            }
        }
    }
}
