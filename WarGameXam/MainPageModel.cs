using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Input;
using FreshMvvm;
using Xamarin.Forms;

namespace WarGameXam
{
    public class MainPageModel : FreshBasePageModel
    {
        //WarCardImage
        private string _warCardImage = "back.png";
        public string WarCardImage
        {
            get { return _warCardImage; }
            set
            {
                _warCardImage = value;
                RaisePropertyChanged("WarCardImage");
            }
        }

        //WarCardImage2
        private string _warCardImage2 = "back.png";
        public string WarCardImage2
        {
            get { return _warCardImage2; }
            set
            {
                _warCardImage2 = value;
                RaisePropertyChanged("WarCardImage2");
            }
        }

        //Label1Score
        private int _label1Score = 0;
        public int Label1Score
        {
            get { return _label1Score; }
            set
            {
                _label1Score = value;
                RaisePropertyChanged("Label1Score");
            }
        }


        //Label2Score
        private int _label2Score = 0;
        public int Label2Score
        {
            get { return _label2Score; }
            set
            {
                _label2Score = value;
                RaisePropertyChanged("Label2Score");
            }
        }

        public ICommand DealButtonCommand { get; }


        public MainPageModel()
        {
            DealButtonCommand = new Command(async () => await NextDeal());
        }

        private async Task NextDeal()
        {
            if(Label1Score >= 10 || Label2Score >= 10)
            {
                if(Label1Score >= 10)
                {
                    await CoreMethods.DisplayAlert("WIN!!!", "Player 1 Win", "OK");

                }
                else
                {
                    await CoreMethods.DisplayAlert("WIN!!!", "Player 2 Win", "OK");
                }

                Label1Score = Label2Score = 0;
                WarCardImage = WarCardImage2 = "back.png";
                return;
            }

            var list1 = new List<CardModel>();
            list1.Add(new CardModel { CardImage = "card14.png", CardValue = 1 });
            list1.Add(new CardModel { CardImage = "card2.png", CardValue = 2 });
            list1.Add(new CardModel { CardImage = "card3.png", CardValue = 3 });
            list1.Add(new CardModel { CardImage = "card4.png", CardValue = 4 });
            list1.Add(new CardModel { CardImage = "card5.png", CardValue = 5 });
            list1.Add(new CardModel { CardImage = "card6.png", CardValue = 6 });
            list1.Add(new CardModel { CardImage = "card7.png", CardValue = 7 });
            list1.Add(new CardModel { CardImage = "card8.png", CardValue = 8 });
            list1.Add(new CardModel { CardImage = "card9.png", CardValue = 9 });
            list1.Add(new CardModel { CardImage = "card10.png", CardValue = 10 });
            list1.Add(new CardModel { CardImage = "card11.png", CardValue = 11 });
            list1.Add(new CardModel { CardImage = "card12.png", CardValue = 12 });
            list1.Add(new CardModel { CardImage = "card13.png", CardValue = 13 });

            var list2 = new List<CardModel>();
            list2.Add(new CardModel { CardImage = "card14.png", CardValue = 1 });
            list2.Add(new CardModel { CardImage = "card2.png", CardValue = 2 });
            list2.Add(new CardModel { CardImage = "card3.png", CardValue = 3 });
            list2.Add(new CardModel { CardImage = "card4.png", CardValue = 4 });
            list2.Add(new CardModel { CardImage = "card5.png", CardValue = 5 });
            list2.Add(new CardModel { CardImage = "card6.png", CardValue = 6 });
            list2.Add(new CardModel { CardImage = "card7.png", CardValue = 7 });
            list2.Add(new CardModel { CardImage = "card8.png", CardValue = 8 });
            list2.Add(new CardModel { CardImage = "card9.png", CardValue = 9 });
            list2.Add(new CardModel { CardImage = "card10.png", CardValue = 10 });
            list2.Add(new CardModel { CardImage = "card11.png", CardValue = 11 });
            list2.Add(new CardModel { CardImage = "card12.png", CardValue = 12 });
            list2.Add(new CardModel { CardImage = "card13.png", CardValue = 13 });

            Random rand = new Random();
            var number = rand.Next(list1.Count);
            var number2 = rand.Next(list2.Count);



            WarCardImage = list1.ElementAt(number).CardImage;
            WarCardImage2 = list2.ElementAt(number2).CardImage;

            int cardOneValue = list1.ElementAt(number).CardValue;
            int cardTwoValue = list2.ElementAt(number2).CardValue;

            if (cardOneValue > cardTwoValue)
            {
                Label1Score = Label1Score + 1;
            }
            else if (cardOneValue < cardTwoValue)
            {
                Label2Score = Label2Score + 1;
            }
        }
    }
}
