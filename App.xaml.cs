using FinalProject.DataTransactions;


namespace FinalProject
{
    public partial class App : Application
    {
        public static DBTrans DBTrans { get; private set; }
        public App(DBTrans dbtrans)
        {
            InitializeComponent();

            MainPage = new AppShell();
            DBTrans = dbtrans;
        }
    }
}
