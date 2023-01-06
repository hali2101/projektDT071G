using projectpractice.Models;

namespace projectpractice;

public partial class ActivityPage : ContentPage
{
    //skapar ny instans av activitystore
    ActivityStore activitystore = new ActivityStore();

    public ActivityPage()
	{
		InitializeComponent();

        //loopar igenom objekten
        foreach (Activity activity in activitystore.GetActivities())
        {

            //kontroll om deltagaren-elementet är tomt
            if (!String.IsNullOrEmpty(activity.Memberone))
            {
                //skriver ut namn på deltagare och gör labeln synlig på sidan
                MemberOneLabel.Text = $"{activity.Memberone}";
                MemberOneLabel.IsVisible = true;
                //konverterar deltagares utgift och skriver ut på sidan
                Oneexpense.Text = Convert.ToString($"{activity.Memberoneexpense} :-");
                Oneexpense.IsVisible = true;
                //visar knappen
                Btnone.IsVisible = true;
            }

            if (!String.IsNullOrEmpty(activity.Membertwo))
            {
                MemberTwoLabel.Text = $"{activity.Membertwo}";
                MemberTwoLabel.IsVisible = true;
                Twoexpense.Text = Convert.ToString($"{activity.Membertwoexpense} :-");
                Twoexpense.IsVisible = true;
                Btntwo.IsVisible = true;
            }

            if (!String.IsNullOrEmpty(activity.Memberthree))
            {
                MemberThreeLabel.Text = $"{activity.Memberthree}";
                MemberThreeLabel.IsVisible = true;
                Threexpense.Text = Convert.ToString($"{activity.Memberthreexpense} :-");
                Threexpense.IsVisible = true;
                Btnthree.IsVisible = true;
            }

            if (!String.IsNullOrEmpty(activity.Memberfour))
            {
                MemberFourLabel.Text = $"{activity.Memberfour}";
                MemberFourLabel.IsVisible = true;
                Fourexpense.Text = Convert.ToString($"{activity.Memberfourexpense} :-");
                Fourexpense.IsVisible = true;
                Btnfour.IsVisible = true;
            }

            //skriver ut aktivitetesnamn och totalsumman
            ActivityNameLabel.Text = $"{activity.Activityname}";
            SumLabel.Text = $"{activity.Sum} :-";
        }
    }

    //metoder vid klick på knappar
    void Button_Clicked_1(System.Object sender, System.EventArgs e)
    {
        //visar entryfält och knapp för respektive deltagare
        Memberoneexpense.IsVisible = true;
        AddBtn.IsVisible = true;
    }
    void Button_Clicked_2(System.Object sender, System.EventArgs e)
    {
        Membertwoexpense.IsVisible = true;
        AddBtn.IsVisible = true;
    }
    void Button_Clicked_3(System.Object sender, System.EventArgs e)
    {
        Memberthreexpense.IsVisible = true;
        AddBtn.IsVisible = true;
    }
    void Button_Clicked_4(System.Object sender, System.EventArgs e)
    {
        Memberfourexpense.IsVisible = true;
        AddBtn.IsVisible = true;
    }

    //metod för att lägga till utgifter för varje deltagare
    void AddExpenses(System.Object sender, System.EventArgs e)
    {

        //lopar igenom listan
        foreach (Activity activity in activitystore.GetActivities())
        {

            //kontroll för att inte fylla i tomma entryfält
            if (!String.IsNullOrEmpty(Memberoneexpense.Text))
            {
                //tömmer felmeddelande
                Errormsg.Text = "";
                //konverterar sträng till integer
                int expense = Convert.ToInt32(Memberoneexpense.Text);
                //Spara aktivitetesnamnet, deltagare och deltagares utgift
                activity.activityname = activity.Activityname;
                activity.memberone = activity.Memberone;
                activity.membertwo = activity.Membertwo;
                activity.memberthree = activity.Memberthree;
                activity.memberfour = activity.Memberfour;
                activity.Memberoneexpense = expense;

                //skickar objekt för att spara i json
                activitystore.Storedata(activity);

                //konverterar summan och utgift till sträng för utskrift
                SumLabel.Text = Convert.ToString($"{activity.Sum} :-");
                Oneexpense.Text = Convert.ToString($"{activity.Memberoneexpense} :-");

                //tömmer entryfield och döljer knappen
                Memberoneexpense.Text = "";
                Memberoneexpense.IsVisible = false;
                AddBtn.IsVisible = false;
            }
            else
            {
                //felmeddelande vid försök till att skicka tomt fält
                Errormsg.Text = $"Inget ifyllt, försök igen!";
            }

            if (!String.IsNullOrEmpty(Membertwoexpense.Text))
            {
                Errormsg.Text = "";
                //konverterar int till string
                int expense = Convert.ToInt32(Membertwoexpense.Text);
                //Spara aktivitetesnamnet och medlemmarna
                activity.activityname = activity.Activityname;
                activity.memberone = activity.Memberone;
                activity.membertwo = activity.Membertwo;
                activity.memberthree = activity.Memberthree;
                activity.memberfour = activity.Memberfour;
                activity.Membertwoexpense = expense;

                activitystore.Storedata(activity);

                SumLabel.Text = Convert.ToString($"{activity.Sum} :-");

                Twoexpense.Text = Convert.ToString($" {activity.Membertwoexpense} :-");

                Membertwoexpense.Text = "";
                Membertwoexpense.IsVisible = false;
                AddBtn.IsVisible = false;

            }


            if (!String.IsNullOrEmpty(Memberthreexpense.Text))
            {
                Errormsg.Text = "";
                //konverterar int till string
                int expense = Convert.ToInt32(Memberthreexpense.Text);
                //Spara aktivitetesnamnet och medlemmarna
                activity.activityname = activity.Activityname;
                activity.memberone = activity.Memberone;
                activity.membertwo = activity.Membertwo;
                activity.memberthree = activity.Memberthree;
                activity.memberfour = activity.Memberfour;
                activity.Memberthreexpense = expense;

                activitystore.Storedata(activity);

                SumLabel.Text = Convert.ToString($"{activity.Sum} :-");

                Threexpense.Text = Convert.ToString($" {activity.Memberthreexpense} :-");

                Memberthreexpense.Text = "";
                Memberthreexpense.IsVisible = false;
                AddBtn.IsVisible = false;

            }


            if (!String.IsNullOrEmpty(Memberfourexpense.Text))
            {
                Errormsg.Text = "";
                //Spara aktivitetesnamnet och medlemmarna
                int expense = Convert.ToInt32(Memberfourexpense.Text);

                activity.activityname = activity.Activityname;
                activity.memberone = activity.Memberone;
                activity.membertwo = activity.Membertwo;
                activity.memberthree = activity.Memberthree;
                activity.memberfour = activity.Memberfour;
                activity.Memberfourexpense = expense;

                activitystore.Storedata(activity);

                SumLabel.Text = Convert.ToString($"{activity.Sum} :-");

                Fourexpense.Text = Convert.ToString($" {activity.Memberfourexpense} :-");

                Memberfourexpense.Text = "";
                Memberfourexpense.IsVisible = false;
                AddBtn.IsVisible = false;

            }
        }            
    }

    //vid klick på knapp dirigerar till ny sida för att räkna ut slutsumma
    void End_Activity(System.Object sender, System.EventArgs e)
    {
        Navigation.PushAsync(new EndActivityPage());
    }
}
