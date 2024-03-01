namespace Facade.Example2
{
    using System;

    public class TravelFacade
    {
        private readonly FlightBooking flightBooking;
        private readonly HotelBooking hotelBooking;
        private readonly CarRental carRental;

        public TravelFacade(FlightBooking flightBooking, HotelBooking hotelBooking, CarRental carRental)
        {
            this.flightBooking = flightBooking;
            this.hotelBooking = hotelBooking;
            this.carRental = carRental;
        }

        public void ArrangeTrip(string destination)
        {
            Console.WriteLine($"Arranging trip to {destination}");

            this.flightBooking.BookFlight(destination);
            this.hotelBooking.BookHotel(destination);
            this.carRental.RentCar(destination);
        }
    }
}
