using System;
using System.Collections.Generic;
using Traveltour.Data;

namespace Traveltour.Services
{
    public interface ITripService
    {
        List<Trip> GetAllTrips();

        Trip GetTripById(int tripId);

        void UpdateTrip(int tripId, Trip trip);

        void DeleteTrip(int tripId);

        void AddTrip(Trip trip);

    }
}