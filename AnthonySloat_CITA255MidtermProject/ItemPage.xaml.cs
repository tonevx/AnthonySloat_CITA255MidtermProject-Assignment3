using System.Xml;

namespace AnthonySloat_CITA255MidtermProject;

[QueryProperty(nameof(Index), "index")]
public partial class ItemPage : ContentPage
{
    int detailindex;

    public ItemPage()
    {
        InitializeComponent();
    }

    public string Index
    {
        set
        {
            detailindex = int.Parse(value);
            nameLabel.Text = Items.Products[detailindex];
            priceLabel.Text = $"${Items.Prices[detailindex]:F2}";
            descriptionLabel.Text = Items.Descriptions[detailindex];
            string[] productImages = { "zeztz.jpg", "chickensandwich.jpg", "kingdomkey.jpg", "mysteriousliquid.png" };
            productImage.Source = productImages[detailindex];

            if (detailindex == 3)
            {
                quantityEntry.IsVisible = false;
                addToCartButton.IsVisible = false;
                outOfStockLabel.IsVisible = true;
            }
            else
            {
                quantityEntry.IsVisible = true;
                addToCartButton.IsVisible = true;
                outOfStockLabel.IsVisible = false;
            }
        }
    }

    private void Button_Clicked(object sender, EventArgs e)
    {

        if (int.TryParse(quantityEntry.Text, out int quantityentry))
        {
            if (quantityentry >= 1 && quantityentry <= 99)
            {
                addedLabel.Text = "Added to cart!";
                addedLabel.TextColor = Colors.LightGreen;
                Cart.Names.Add(Items.Products[detailindex]);
                Cart.Counts.Add(quantityentry);
                Cart.Prices.Add(Items.Prices[detailindex]);
            }
            else
            {
                addedLabel.Text = "Please enter a number between 1 and 99.";
                addedLabel.TextColor = Colors.Red;
                return;
            }
        }
        else
        {
            addedLabel.Text = "Not a number. Please enter a number between 1 and 99.";
            addedLabel.TextColor = Colors.Red;
            return;
        }
    }
}
