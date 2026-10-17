namespace AnthonySloat_CITA255MidtermProject
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute("Item", typeof(ItemPage));
        }
    }
}
