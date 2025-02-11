class Appointment {

    private bool[,] MinuteGrid;

    // Constructor - Chaniel
    // PRECONDITION: 0 < periods
    public Appointment(int periods) {
        MinuteGrid = new bool[periods, 60];
        for (int i = 0; i < periods; i++) {
            for (int j = 0; j < 60; j++) MinuteGrid[i, j] = true;
        }
    }

    // isMinuteFree - Chaniel
    // PRECONDITION: 1 <= period <= periods
    // PRECONDITION: 0 <= minute <= 59
    public bool isMinuteFree(int period, int minute) {
        return MinuteGrid[period - 1, minute]
    }

    // reserveBlock

    // findFreeBlock

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
