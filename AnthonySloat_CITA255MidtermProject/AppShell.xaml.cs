namespace AnthonySloat_CITA255MidtermProject
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute("ZEZTZpage", typeof(NewPage1));
            Routing.RegisterRoute("chickenpage", typeof(NewPage2));
            Routing.RegisterRoute("keybladepage", typeof(NewPage3));
            Routing.RegisterRoute("liquidpage", typeof(NewPage4));
        }
    }
}
