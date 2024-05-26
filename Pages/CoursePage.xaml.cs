namespace FinalProject.Pages;

public partial class CoursePage : ContentPage
{
	public CoursePage()
	{
		InitializeComponent();
		Course_List_View.ItemsSource= App.DBTrans.GetAllCourses();

	}

    private void Button_CourseAdd_Clicked(object sender, EventArgs e)
    {
        App.DBTrans.Add_course(new Models.Course
        {
            Crs_Code =Course_Code.Text,
            Crs_Name = Course_Name.Text,

        });

    }

    private void Button_CourseDelete_Clicked(object sender, EventArgs e)
    {
        Button button = (Button)sender;
        App.DBTrans.Delete_course((int)button.BindingContext);
        Course_List_View.ItemsSource=App.DBTrans.GetAllCourses();
    }

    private void Button_CourseShow_Clicked(object sender, EventArgs e)
    {
        Course_List_View.ItemsSource = App.DBTrans.GetAllCourses();

    }
}