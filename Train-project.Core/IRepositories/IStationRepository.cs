using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Train_project.Core.Entities;

namespace Train_project.Core.IRepositories
{
    public interface IStationRepository
    {
        List<StationEntity> GetAllStations();
        int StationById(int id);
        StationEntity GetStationById(int id);
        bool AddStation(StationEntity station);
        bool UpdateStation(int id, StationEntity station);
        bool DeleteStation(int id);
    }
}
