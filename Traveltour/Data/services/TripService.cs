using System.Collections.Generic;

namespace Traveltour.Data.services
{
    public class TripService : ITripService
    { 
       
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
            Trip first  = new Trip();
            first.Description = "all";
            return first;
        }

        public List<Trip> GetAllTrips()
        {
            throw new System.NotImplementedException();
        }
    }
} 