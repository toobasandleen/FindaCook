namespace FindaCook;


public partial class professional_info : ContentPage
{
	public professional_info()
	{
        InitializeComponent();
    }
    private void OnNextClicked(object sender, EventArgs e)
    {
        //string experience = ExperienceEntry.Text;
        //string experienceWhere = ExperienceWhereEntry.Text;
        //string specialties = SpecialtiesEntry.Text;
        //string signatureDishes = SignatureDishesEntry.Text;

        // Collect selected services
        /* List<string> selectedServices = new List<string>();
         if (CateringCheckBox.IsChecked) selectedServices.Add("Catering Services");
         if (InHouseChefCheckBox.IsChecked) selectedServices.Add("In-House Chef Services");
         if (CookingClassesCheckBox.IsChecked) selectedServices.Add("Individual Cooking Classes");
         if (CookingWorkshopsCheckBox.IsChecked) selectedServices.Add("Cooking Workshops");

         string otherSkills = OtherSkillsEntry.Text;  */

        // Save professional background information
        // You can process and store this information as needed

        // Navigate to the next page
        //await Navigation.PushAsync(new NextPage());
    }
}