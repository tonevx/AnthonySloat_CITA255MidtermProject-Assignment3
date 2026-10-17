namespace AnthonySloat_CITA255MidtermProject
{
    public partial class MainPage : ContentPage
    {

        List<string> rows = new List<string>();


        public MainPage()
        {
            InitializeComponent();
            for (int i = 0; i < Items.Products.Length; i++)
            {
                rows.Add($"{Items.Products[i]}   —   {Items.Prices[i]:C}");
            }
            productList.ItemsSource = rows;
        }

        private async void OnProductSelected(object sender, SelectionChangedEventArgs e)
        {
            if (e.CurrentSelection.Count == 0)
                return;
         string picked = e.CurrentSelection[0].ToString();

         productList.SelectedItem = null;
         int index = rows.IndexOf(picked);
         await Shell.Current.GoToAsync($"Item?index={index}");

        }
    }
}
