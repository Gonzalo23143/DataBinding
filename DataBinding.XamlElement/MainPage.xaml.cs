namespace DataBinding.XamlElement
{
    public partial class MainPage : ContentPage
    {
      

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            EnteredtextLabel.text = Entrytext.Text;
        }
    }
}
