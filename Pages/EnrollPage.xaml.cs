using FinalProject.Models;
namespace FinalProject.Pages;

public partial class EnrollPage : ContentPage
{
	public EnrollPage()
	{
		InitializeComponent();
	}
    protected override void OnAppearing()
    {
        base.OnAppearing();
        lstStudents.ItemsSource = App.DBTrans.GetAllStudents();
        lstCourses.ItemsSource = App.DBTrans.GetAllCourses();

    }

    private void Enrollmen_Add(object sender, EventArgs e)
    {
        var student = lstStudents.SelectedItem as Student;
        var course = lstCourses.SelectedItem as Course;

        if (student != null && course != null)
        {
            var enroll = new Enroll
            {
                Stu_ID = student.ID,
                Crs_Cod = course.Crs_Code
            };

            App.DBTrans.Add_enroll(enroll);
           
        }
        else
        {
            DisplayAlert("Error", "Please select both a student and a course.", "OK");
        }

        lstStudents.SelectedItem = null;
        lstCourses.SelectedItem = null;
    }

    private void Enrollmen_Show(object sender, EventArgs e)
    {
        var enrollments = App.DBTrans.GetAllEnrolls();
        lstEnrollments.ItemsSource = enrollments;
    }

    private void Enroll_Delete_Button(object sender, EventArgs e)
    {
        var selectedEnrollment = lstEnrollments.SelectedItem as Enroll;
        if (selectedEnrollment != null)
        {
            App.DBTrans.Delete_enroll(selectedEnrollment.En_ýd);
            Enrollmen_Show(sender, e);
        }
        else
        {
            DisplayAlert("Error", "Please select an enrollment to delete.", "OK");
        }
    }

}