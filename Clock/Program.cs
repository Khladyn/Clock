class Clock
{
// Create function to compute the angle
static double findAngle(int hours, int minutes)
    {
        // Convert midnight to zero hour
        if (hours >= 12) hours = 0; 

        // Convert 60 minutes to zero minute
        if (minutes >= 60) minutes = 0;

        // Find the angle of each hand in reference to 12:00
        // 360 degrees in a circle / 12 hours in a clock = 30 degrees in an hour
        // 30 degrees in an hour / 60 minutes = 0.5 (to account for the long hand's movement)
        double hours_angle = hours * 30 + (minutes * 0.5);

        // 360 degrees in a circle / 60 minutes in a clock = 6 degrees in a minute
        double minutes_angle = minutes * 6;

        // Find the difference between the two angles
        double smaller_angle = Math.Abs(hours_angle - minutes_angle);

        // Find the smaller angle of two
        smaller_angle = Math.Min(smaller_angle, 360 - smaller_angle);

        return smaller_angle;
    }

    public static void Main()
    {
        // Display console app title
        Console.WriteLine("Clock Angle Calculator\r");
        Console.WriteLine("----------------------\n");

        // Ask the user to type in the hours
        Console.Write("Type in the hours: ");
        int hours = Convert.ToInt32(Console.ReadLine());

        // Ask the user to type in the minutes
        Console.Write("Type in the minutes: ");
        int minutes = Convert.ToInt32(Console.ReadLine());

        // Validate the input
        if (hours < 0 || minutes < 0 || hours > 12 || minutes > 60)
            Console.WriteLine("Invalid input");

        else
        {
            // Print the result
            double angle = findAngle(hours, minutes);
            Console.WriteLine($"\nThe smaller angle between {hours}H and {minutes}m is {angle} degrees.");
        }

        // Ask user to exit program
        Console.Write("Press any key to exit...");
        Console.ReadKey();
    }
}

