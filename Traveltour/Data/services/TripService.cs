using System.Collections.Generic;
using Traveltour.Data;
using System.Linq;
using Traveltour.Services;



namespace Traveltour.Data
{
    public class TripService : ITripService
    { 
        public List<Trip> GetAllTrips() => Data.TraveltourDBContext();
       
        public void AddTrip(Trip trip)
        {
            
        }
        public void DeleteTrip(int tripId)
        {

        }

        public void UpdateTrip(int tripId, Trip trip)
        {

        }
        public Trip GetTripById(int tripId)
        {

        }

        public List<Trip> GetAllTrips()
        {
            
        }

    }
} 