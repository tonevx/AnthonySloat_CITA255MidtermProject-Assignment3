namespace AnthonySloat_CITA255MidtermProject;

public partial class NewPage1 : ContentPage
{
    public NewPage1()
    {
        InitializeComponent();
    }

    private void Button_Clicked(object sender, EventArgs e)
    {

        if (int.TryParse(quantityEntry.Text, out int quantityentry))
        {
            if (quantityentry >= 1 && quantityentry <= 99)
            {
                addedLabel.Text = "Added to cart!";
                addedLabel.TextColor = Colors.LightGreen;
            }
            else
            {
                addedLabel.Text = "Please enter a number between 1 and 99.";
                addedLabel.TextColor = Colors.Red;
            }
        }
        else
        {
            addedLabel.Text = "Not a number. Please enter a number between 1 and 99.";
            addedLabel.TextColor = Colors.Red;
        }
    }
}