
namespace FinalProject.Pages;




public partial class MainPage : ContentPage
{
  

    public MainPage()
    {
        InitializeComponent();
        Stu_List_View.ItemsSource= App.DBTrans.GetAllStudents();
    }

    private void Button_Add_Clicked(object sender, EventArgs e)
    {
        App.DBTrans.Add(new Models.Student
        {
            Name=Stu_Name.Text,
            Department=Stu_Dept.Text

        });

    }

    private void Button_Delete_Clicked(object sender, EventArgs e)
    {
        Button button = (Button)sender;
        App.DBTrans.Delete((int)button.BindingContext);
        Stu_List_View.ItemsSource = App.DBTrans.GetAllStudents();
    }

    private void Button_Show_Clicked(object sender, EventArgs e)
    {
        Stu_List_View.ItemsSource=App.DBTrans.GetAllStudents();
    }
}
