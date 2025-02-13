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
}

    // makeAppointment - Daniel Furmanov
    
    // Test -Daniel Furmanov
// Testcase Part A
Console.WriteLine("Earliest 15-minute block: " + appoint.findFreeBlock(2,15));
Console.WriteLine("Smallest starting minute of a valid block" + appoint.findFreeBlock(2,9));
Console.WriteLine("No such block exists: " + appoint.findFreeBlock(2,20));
// TestCase Part B
Console.WriteLine("Reserving minutes 5-26 in period 4: " + appoint.makeAppointment(2, 4, 22));
Console.WriteLine("Reserving minutes 0-2 in period 3: " + appoint.makeAppointment(3, 4, 3));
Console.WriteLine("Reserving 30-minute block (no 30-minute block exists): " + appoint.makeAppointment(2, 4, 30));
}

class Program {
    public static void Main(String[] args) {
        // Test cases
    }
}