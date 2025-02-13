class Appointment {
    // Constructor

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

class Program {
    public static void Main(String[] args) {
        // Test cases
    }
}