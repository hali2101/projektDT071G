using System.Linq.Expressions;
//importerar klasserna
using projectpractice.Models;

namespace projectpractice;

public partial class NewActivityPage : ContentPage
{

    //variable för deltagare
    int participants = 0;

    //starta aktivitet tas till ny sida
    void Button_Clicked_3(System.Object sender, System.EventArgs e)
    {
            //skapar ny instans av activitystore
            ActivityStore activitystore = new ActivityStore();
            //sparar infört data i variabler
            string activityname = EntryActivity.Text;
            string memberone = memberOne.Text;
            string membertwo = memberTwo.Text;
            string memberthree = memberThree.Text;
            string memberfour = memberFour.Text;

            //skapar ny instans av activityklassen
            Activity obj = new Activity();

            //sparar aktivitetesnamn och deltagare i objektet för klassen
            obj.Participants = this.participants;
            obj.Activityname = activityname;
            obj.Memberone = memberone;
            obj.Membertwo = membertwo;
            obj.Memberthree = memberthree;
            obj.Memberfour = memberfour;

            //skickar objektet för att spara till json-fil
            activitystore.Storedata(obj);
            //dirigerar till ny sida
            Navigation.PushAsync(new ActivityPage());
        }

    public NewActivityPage()
	{
		InitializeComponent();

        //skapar ny deltagarelista
        var memberList = new List<string>();

        //populerar listan
        memberList.Add("1");
        memberList.Add("2");
        memberList.Add("3");
        memberList.Add("4");

        Picker picker = new Picker { Title = "Välj antal" };

        //visar en lsiat med deltagare
        picker.ItemsSource = memberList;

        //lägger till en koppling till valt element från listan
        Label memberNameLabel = new Label();
        memberNameLabel.SetBinding(Label.TextProperty, new Binding("SelectedItem", source: picker));

    }

    //metod för att visa/dölja element
    void OnPickerSelectedIndexChanged(object sender, EventArgs e)
    {
        //sparas det valet från listan till variabel
        int selectedIndex = picker.SelectedIndex;
        //lägger till 1 för antal deltagare ska gå att räkna med
        this.participants = selectedIndex + 1;

        //kontroll för att värdet inte ska kunna vara negativt
        if (selectedIndex != -1)
        {
            //visar antal entry-fields beroende på vilket val som gjorts i pickern
            switch (selectedIndex)
            {
                case 0:
                    labelOne.IsVisible = true;
                    memberOne.IsVisible = true;
                    labelTwo.IsVisible = false;
                    memberTwo.IsVisible = false;
                    labelThree.IsVisible = false;
                    memberThree.IsVisible = false;
                    labelFour.IsVisible = false;
                    memberFour.IsVisible = false;
                    break;

                case 1:
                    labelOne.IsVisible = true;
                    memberOne.IsVisible = true;
                    labelTwo.IsVisible = true;
                    memberTwo.IsVisible = true;
                    labelThree.IsVisible = false;
                    memberThree.IsVisible = false;
                    labelFour.IsVisible = false;
                    memberFour.IsVisible = false;
                    break;

                case 2:
                    labelOne.IsVisible = true;
                    memberOne.IsVisible = true;
                    labelTwo.IsVisible = true;
                    memberTwo.IsVisible = true;
                    labelThree.IsVisible = true;
                    memberThree.IsVisible = true;
                    labelFour.IsVisible = false;
                    memberFour.IsVisible = false;
                    break;

                case 3:
                    labelOne.IsVisible = true;
                    memberOne.IsVisible = true;
                    labelTwo.IsVisible = true;
                    memberTwo.IsVisible = true;
                    labelThree.IsVisible = true;
                    memberThree.IsVisible = true;
                    labelFour.IsVisible = true;
                    memberFour.IsVisible = true;
                    break;

                default:
                    // code block
                    break;
            }
        }
    }

}
