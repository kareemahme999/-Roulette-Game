

using System;
/*──────▄▌▐▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▌
 * ───▄▄██▌█ beep beep--------------
 * ▄▄▄▌▐██▌█ -KAREEM_AHMED------------
 * ███████▌█▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▌
 * ▀(@)▀▀▀▀(@)(@)▀▀▀▀▀▀▀▀▀▀▀(@)▀
 */
 
public class HelloWorld {
    public static void Main(string[] args) {
        Random random = new Random();

    int score = 0;
    int spins = 0;

    while (score < 10 && spins < 20)
    {
        int number = random.Next(1, 5);
        spins++;
    
        Console.WriteLine("You Number is : " + number);
    
        if (number == 1)
        {
            score += 1;
        }
        else if (number == 2)
        {
            score += 2;
        }
        else if (number == 3)
        {
            score -= 1;
        }
   
    
        Console.WriteLine("Score: " + score);
        Console.WriteLine("Spins: " + spins+ "\n");
    }
    
    if (score >= 10)
    {
        Console.WriteLine("<<You Win>>");
    }
    else
    {
        Console.WriteLine("<<You Lose>>");
    }
        }
}
