using JPillajoChanchayT5.Utils;
using JPillajoChanchayT5.Views;



namespace JPillajoChanchayT5
{
    public partial class App : Application
    {
        public static PersonRepository personRepo { get; set; }
        public App(PersonRepository person)
        {
            InitializeComponent();

            MainPage = new NavigationPage(new vHome());

            personRepo = person;

        }
    }
}
