using System;
namespace basic_core_programs

{
    public class Program
    {
        public static void Main(string[] args)
            
        {
            switch (all)
            {
                case 1:
                    Test t = new Test();
                    t.leapYear();
                    break;
               
                case 2:
                    PrimeEven primeEven = new PrimeEven();
                    primeEven.Primeno();
                    break;

                case 3:
                    FlipCoin flipCoin = new FlipCoin();
                    flipCoin.flips();
                    break;

                case 4:
                    EvenOdd evenOdd = new EvenOdd();
                    evenOdd.evod();
                    break;

                case 5:
                    HarmonicNum harmonicNum = new HarmonicNum();
                    harmonicNum.harmonic();
                    break;

                case 6:
                    Swap swap = new Swap();
                    swap.swp();
                    break;

                case 7:
                    LargestNumber largestNumber = new LargestNumber();
                    largestNumber.largenumber();
                    break;

                case 8:
                    Vowels vowels = new Vowels();
                    vowels.vowls();
                    break;

                case 9:
                    QuotientandReminder quotientandReminder = new QuotientandReminder();
                    quotientandReminder.quotremd();
                    break;

                case 10:
                    PowerByTwo powerByTwo = new PowerByTwo();
                    powerByTwo.powtwo();
                    break;

                case 11:
                    Factor factor = new Factor();
                    factor.fac();
                default;
            }

        }
           
          

        
         
    }
}