
using Facade.Example2;

FlightBooking flightBooking = new FlightBooking();
HotelBooking hotelBooking = new HotelBooking();
CarRental carRental = new CarRental();

TravelFacade travelFacade = new TravelFacade(flightBooking, hotelBooking, carRental);

travelFacade.ArrangeTrip("Paris");