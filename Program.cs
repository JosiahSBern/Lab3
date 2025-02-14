class Appointment
{
    // Constructor
    private bool[,] MinuteGrid;

    // Constructor - Chaniel
    // PRECONDITION: 0 < periods
    public Appointment(int periods)
    {
        MinuteGrid = new bool[periods, 60];
        for (int i = 0; i < periods; i++)
        {
            for (int j = 0; j < 60; j++) MinuteGrid[i, j] = true;
        }
    }

    // isMinuteFree - Chaniel
    // PRECONDITION: 1 <= period <= periods
    // PRECONDITION: 0 <= minute <= 59
    public bool isMinuteFree(int period, int minute)
    {
        return MinuteGrid[period - 1, minute];
    }

    // reserveBlock - Josiah 
    public void reserveBlock(int period, int startMinute, int duration)
    {
        for (int i = startMinute; i < startMinute + duration; i++) {
            if (i < 60)
                MinuteGrid[period - 1, i] = false;
        }
    }



    // findFreeBlock - Josiah
    public int findFreeBlock(int period, int duration) {
        for (int startMinute = 0; startMinute <= 60 - duration; startMinute++) {
            bool blockAvailable = true;

            for (int i = 0; i < duration; i++) {
                if (!isMinuteFree(period, startMinute + i)) {
                    blockAvailable = false;
                    break;
                }
            }

            if (blockAvailable) 
                return startMinute;
        }
        return -1;
    }

    // makeAppointment - Daniel Furmanov
    public bool makeAppointment(int startPeriod, int endPeriod, int duration)
    {
        for (int period = startPeriod; period <= endPeriod; period++) //period in the range
        {
            int startMinute = findFreeBlock(period, duration); //available slot
            
            if (startMinute != -1)
            {
                reserveBlock(period, startMinute, duration);
                return true;
            }
        }
        return false;
    }
}
        // Test cases -Daniel Furmanov
class Program {
    public static void Main(String[] args) {
        Appointment appoint = new Appointment(8);
        
        // Part A test cases
        Console.WriteLine("\nPart A: findFreeBlock");
        Console.WriteLine("Earliest 15-minute block: " + appoint.findFreeBlock(2, 15));
        Console.WriteLine("Smallest starting minute of a valid block: " + appoint.findFreeBlock(2, 9));
        Console.WriteLine("No such block exists: " + appoint.findFreeBlock(2, 20));
        
        // Part B test cases
        Console.WriteLine("\nPart B: makeAppointment");
        
        appoint.reserveBlock(2, 0, 25);
        appoint.reserveBlock(2, 30, 30);
        appoint.reserveBlock(3, 15, 26);
        appoint.reserveBlock(4, 0, 5);
        appoint.reserveBlock(4, 30, 14);
        
        Console.WriteLine("Reserving minutes 5-26 in period 4: " + appoint.makeAppointment(2, 4, 22));
        Console.WriteLine("Reserving minutes 0-2 in period 3: " + appoint.makeAppointment(3, 4, 3));
        Console.WriteLine("Reserving 30-minute block (no 30-minute block exists): " + appoint.makeAppointment(2, 4, 30));
    }
}