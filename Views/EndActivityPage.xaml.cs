using projectpractice.Models;

namespace projectpractice;

public partial class EndActivityPage : ContentPage
{

    //skapar ny instans av activitystore
    readonly ActivityStore activitystore = new ActivityStore();

    public EndActivityPage()
    {

        InitializeComponent();

        //loopar igenom objekten
        foreach (Activity activity in activitystore.GetActivities())
        {
            //variabel för som innehåller delsumman för alla deltagare
            int averageexpense = activity.Sum / activity.Participants;

            //kontroll om deltagaren finns
            if (!String.IsNullOrEmpty(activity.Memberone))
            {
                //uträkning för hur mycket varje deltagare är skydlig resp ska erhålla
                int memberoneaverage = activity.Memberoneexpense - averageexpense;

                //kontroll om värdet är negativt eller positivt
                if (memberoneaverage > 0)
                {
                    MemberOneLabel.Text = $"{activity.Memberone} ska erhålla {Convert.ToString(memberoneaverage)} :-";
                    MemberOneLabel.IsVisible = true;                   
                }
                else
                {
                    string memberoneaveragestr = Convert.ToString(memberoneaverage);
                    //tar bort minustecken vid negativt utfall
                    MemberOneLabel.Text = $"{activity.Memberone} är skyldig {memberoneaveragestr.Remove(0, 1)} :-";
                    MemberOneLabel.IsVisible = true;
                }
            }

            if (!String.IsNullOrEmpty(activity.Membertwo))
            {
                int membertwoaverage = activity.Membertwoexpense - averageexpense;

                if (membertwoaverage > 0)
                {
                    MemberTwoLabel.Text = $"{activity.Membertwo} ska erhålla {Convert.ToString(membertwoaverage)} :-";
                    MemberTwoLabel.IsVisible = true;
                }
                else
                {
                    string membertwoaveragestr = Convert.ToString(membertwoaverage);
                    MemberTwoLabel.Text = $"{activity.Membertwo} är skyldig {membertwoaveragestr.Remove(0, 1)} :-";
                    MemberTwoLabel.IsVisible = true;
                }
            }

            if (!String.IsNullOrEmpty(activity.Memberthree))
            {
                int memberthreeaverage = activity.Memberthreexpense - averageexpense;

                if (memberthreeaverage > 0)
                {
                    MemberThreeLabel.Text = $"{activity.Memberthree} ska erhålla {Convert.ToString(memberthreeaverage)} :-";
                    MemberThreeLabel.IsVisible = true;
                }
                else
                {
                    string memberthreeaveragestr = Convert.ToString(memberthreeaverage);
                    MemberThreeLabel.Text = $"{activity.Memberthree} är skyldig {memberthreeaveragestr.Remove(0, 1)} :-";
                    MemberThreeLabel.IsVisible = true;
                }
            }

            if (!String.IsNullOrEmpty(activity.Memberfour))
            {
                int memberfouraverage = activity.Memberfourexpense - averageexpense;

                if (memberfouraverage > 0)
                {
                    MemberFourLabel.Text = $"{activity.Memberfour} ska erhålla {Convert.ToString(memberfouraverage)} :-";
                    MemberFourLabel.IsVisible = true;
                }
                else
                {
                    string memberfouraveragestr = Convert.ToString(memberfouraverage);
                    MemberFourLabel.Text = $"{activity.Memberfour} är skyldig {memberfouraveragestr.Remove(0, 1)} :-";
                    MemberFourLabel.IsVisible = true;
                }
            }

            //skriver ut summa och aktivitetsnamn
            ActivityNameLabel.Text = $"{activity.Activityname}";
            SumLabel.Text = $"{activity.Sum} :-";

        }
    }

}
