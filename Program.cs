internal class Program
{
    private static void Main(string[] args)
    {
        #region 1fel

        //Console.WriteLine("Adj egy számot");

        //int a = int.Parse(Console.ReadLine());

        int counter = 0;

        //while (counter <= a)
        //{
        //    if(counter % 2 == 0)
        //    {
        //    Console.WriteLine(counter);

        //    }
        //    counter++;
        //}

        #endregion

        #region 2fel

        //string pass = "asd";
        //    string userp = "";
        //do
        //{
        //    Console.WriteLine("Kérem a jelszót" + "(" + counter + ")");

        //    userp = Console.ReadLine();

        //    if (pass == userp)
        //    {
        //        Console.WriteLine("sikeres");
        //    }
        //    else if(counter == 2)
        //    {
        //        Console.WriteLine("RIP NO MORE GUESSES :C");
        //    }
        //    else
        //    {
        //        Console.WriteLine("sikertelen");         
        //        userp = Console.ReadLine();
        //    }
        //    counter++;

        //} while (pass != userp && counter < 3);

        #endregion

        #region 3fel

        //Random randomNum = new Random();
        //int randomN = (randomNum.Next(0,1001));

        //Console.WriteLine(randomN);

        //int userGuessNum = 0;

        //do
        //{
        //    userGuessNum = int.Parse(Console.ReadLine());

        //    if (userGuessNum < randomN)
        //    {
        //        Console.WriteLine("nagyobb");
        //    }
        //    else if (userGuessNum > randomN)
        //    {
        //        Console.WriteLine("kisebb");
        //    }
        //} while (userGuessNum != randomN);

        #endregion

        Random randomNum = new Random();

        int userSetNum;
        userSetNum = int.Parse(Console.ReadLine());

        Console.WriteLine("KITALANI EZT KELL: " + userSetNum);

        int PCGuess = 0;

        int maxGuess = 1001;
        int minGuess = 1;

        do
        {
            PCGuess = randomNum.Next(minGuess, maxGuess);

            Console.WriteLine(PCGuess);

            if (PCGuess > userSetNum)
            {
                Console.WriteLine("kisebb");

                maxGuess = PCGuess - 1;

                Console.WriteLine("uj max: " + maxGuess);
                Console.WriteLine("uj min: " + minGuess);

                PCGuess = randomNum.Next(minGuess, maxGuess);

            }
            else if (PCGuess < userSetNum)
            {
                Console.WriteLine("nagyobb");

                minGuess = PCGuess + 1 ;

                Console.WriteLine("uj max: " + maxGuess);
                Console.WriteLine("uj min: " + minGuess);

                PCGuess = randomNum.Next(minGuess, maxGuess);
            }

            else if (PCGuess == userSetNum || minGuess == maxGuess)
            {
                Console.WriteLine("kitalaltam");
            }


        } while (PCGuess != userSetNum);


    }

}