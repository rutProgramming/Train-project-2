using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Train_project.Core.Entities;
using Train_project.Core.IRepositories;
using Train_project.Core.IServices;

namespace Train_project.Service.Services
{
    public class StationService : IStationService
    {
        readonly IStationRepository _stationRepository;
        public StationService(IStationRepository stationRepository)
        {
            _stationRepository = stationRepository;
        }
        
        public List<StationEntity> GetAllStations()
        {
            return _stationRepository.GetAllStations();
        }
        public StationEntity? GetStationById(int id)
        {
            int indexStation = _stationRepository.StationById(id);
            if (indexStation != -1)
            {
                return _stationRepository.GetStationById(indexStation);
            }
            return null;
        }
        public bool AddStation(StationEntity station)
        {
            int indexStation =_stationRepository.StationById(station.StationID);
            if (indexStation == -1 && ValidData(station))
            {
                return _stationRepository.AddStation(station);
            }
            return false;
        }
        public bool UpdateStation(int id, StationEntity station)
        {
            int indexStation = _stationRepository.StationById(id);

            if (indexStation != -1 && ValidData(station))
            {
                return _stationRepository.UpdateStation(indexStation, station);
            }
            return false;
        }
        public bool DeleteStation(int id)
        {
            int indexStation = _stationRepository.StationById(id);
            if (indexStation != -1)
            {
                return _stationRepository.DeleteStation(indexStation);
            }
            return false;
        }
        public bool ValidData(StationEntity station)
        {
            return string.IsNullOrEmpty(station.LocationGPSCoordinates) ? true : Valid.IsValidGPSCoordinates(station.LocationGPSCoordinates);
        }


    }
}
