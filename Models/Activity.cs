using System;
namespace projectpractice.Models
{
	public class Activity
	{
        //variabler
        public string activityname = "";
        public string memberone = "";
        public string membertwo = "";
        public string memberthree = "";
        public string memberfour = "";
        public int sum = 0;
        public int participants = 0;
        public int memberoneexpense = 0;
        public int membertwoexpense = 0;
        public int memberthreexpense = 0;
        public int memberfourexpense = 0;

        //Set och get till aktivitetsnamnet
        public string Activityname { set; get; }

        //set och get till antal deltagare
        public int Participants { set; get; }

        //setters och getters till de deltagarnamnen
        public string Memberone { get; set; }
        public string Membertwo { get; set; }
        public string Memberthree { get; set; }
        public string Memberfour { get; set; }

        //setters och getters för utgifter för medlemmarna
        public int Memberoneexpense
        {
            
            set
            {   //sätter totalsumman för aktiviteten
                this.sum = this.sum + value;
                //sätter totalsumman för enskild deltagare
                this.memberoneexpense = this.memberoneexpense + value;
            }
            get { return this.memberoneexpense; }
        }

        public int Membertwoexpense
        {
            
            set { this.sum = this.sum + value;
                this.membertwoexpense = this.membertwoexpense + value;
            }
            get { return this.membertwoexpense; }
        }

        public int Memberthreexpense
        { 
            set{
                this.sum = this.sum + value;
                this.memberthreexpense = this.memberthreexpense + value;
            }
            get { return this.memberthreexpense; }
        }

        public int Memberfourexpense
        {
            set
            {
                this.sum = this.sum + value;
                this.memberfourexpense = this.memberfourexpense + value;
            }
            get { return this.memberfourexpense; }
        }

        //get med return till totalsumman av utgifter
        public int Sum
        {
            get { return this.sum; }
        }

    }
}

