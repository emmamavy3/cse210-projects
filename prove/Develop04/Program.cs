using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        Menu viewMenu = new Menu();
        Activity myActivity = new Activity("","", 4);

        switch(viewMenu.DisplayMenu())
        {
            case 1:
                myActivity.DisplayActivity();
            break;
        }

        

    }


    // switch(response)
    //     {
    //         case 1:
    //             // BreathingActivity myBreathingActivity = new BreathingActivity();
    //             Activity myActivity = new Activity("test", "test", 12);
    //             myActivity.DisplayActivity();

    //         break;
    //         // case 2:
    //         //     ReflectionActivity myReflectionActivity = new ReflectionActivity();
                
    //         // break;
    //         // case 3:
    //         //     ListingActivity mylistingActivity = new ListingActivity();
                
    //         // break;
    //         case 4:
    //             return;
    //         default:                
    //         break;
    //     }
    
}