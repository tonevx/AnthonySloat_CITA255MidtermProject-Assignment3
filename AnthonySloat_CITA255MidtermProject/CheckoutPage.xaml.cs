namespace AnthonySloat_CITA255MidtermProject;

public partial class CheckoutPage : ContentPage
{
	public CheckoutPage()
	{
		InitializeComponent();
	}
    protected override void OnAppearing()
    {
        base.OnAppearing();
        Refresh();
    }

    async void OnEmptyCart()
    {
        Cart.Names.Clear();
        Cart.Counts.Clear();
        Cart.Prices.Clear();
        endLabel.Text = "Thank you for shopping! Cart cleared.";
        Refresh();

        await Task.Delay(3000);
        endLabel.Text = string.Empty;
    }

    void Refresh() 
    { 
        List<string> lines = new List<string>();
        double total = 0.00;
        for (int i = 0; i < Cart.Names.Count; i++) 
        {
            double linePrice = Cart.Counts[i] * Cart.Prices[i];
            lines.Add($"{Cart.Names[i]} x {Cart.Counts[i]}");
            total += linePrice;
        }
        CartList.ItemsSource = lines;
        totalLabel.Text = $"Total: ${total:F2}";
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        OnEmptyCart();
    }
}