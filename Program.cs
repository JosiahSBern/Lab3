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
     //     public class AppointmentTests
// {
//     [Fact]
//     public void TestBasicReservationInSinglePeriod()
//     {
//         // Arrange
//         var appointmentSystem = new Appointment(5);
        
//         // Act
//         bool result = appointmentSystem.MakeAppointment(2, 4, 22);
        
//         // Assert
//         Assert.True(result);
//     }

//     [Fact]

//         // Arrange
//         var appointmentSystem = new Appointment(5);
        
//         // Act
//         bool result = appointmentSystem.MakeAppointment(3, 4, 3);
        
  // Expected to succeed for a 3-min block
}

class Program {
    public static void Main(String[] args) {
        // Test cases
    }
}
