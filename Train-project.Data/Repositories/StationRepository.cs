using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Train_project.Core.Entities;
using Train_project.Core.IRepositories;
using static System.Collections.Specialized.BitVector32;

namespace Train_project.Data.Repositories
{
    public class StationRepository:IStationRepository
    {
        readonly DataContext _dataContext;
        public StationRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public List<StationEntity> GetAllStations()
        {
            return _dataContext.Stations.ToList();
        }
        public int StationById(int id)
        {
            int indexStation = _dataContext.Stations.ToList().FindIndex(Station => Station.StationID == id);
            return indexStation;

        }
        public StationEntity? GetStationById(int indexStation)
        {
                return _dataContext.Stations.ToList()[indexStation];
        }
        public bool AddStation(StationEntity station)
        {
            try {
                _dataContext.Stations.Add(station);
                _dataContext.SaveChanges();
                return true;
            }
            catch { 
                return false; 
            }
        }

        public bool UpdateStation(int indexStation, StationEntity updatedStation)
        {
            StationEntity existingStation = _dataContext.Stations.ToList()[indexStation];

            if (!string.IsNullOrEmpty(updatedStation.StationName))
                existingStation.StationName = updatedStation.StationName;

            if (!string.IsNullOrEmpty(updatedStation.StationAddress))
                existingStation.StationAddress = updatedStation.StationAddress;

            if (!string.IsNullOrEmpty(updatedStation.StationCity))
                existingStation.StationCity = updatedStation.StationCity;

            if (!string.IsNullOrEmpty(updatedStation.LocationGPSCoordinates))
                existingStation.LocationGPSCoordinates = updatedStation.LocationGPSCoordinates;

            if (!string.IsNullOrEmpty(updatedStation.StationType))
                existingStation.StationType = updatedStation.StationType;

            if (updatedStation.NumberOfPlatforms > 0)
                existingStation.NumberOfPlatforms = updatedStation.NumberOfPlatforms;
            _dataContext.SaveChanges();
            return true;

        }
        public bool DeleteStation(int indexStation)
        {
                _dataContext.Stations.Remove(_dataContext.Stations.ToList()[indexStation]);
            _dataContext.SaveChanges();
            return true;

        }
    }
}
