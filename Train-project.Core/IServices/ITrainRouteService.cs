using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Train_project.Core.Entities;

namespace Train_project.Core.IServices
{
    public interface ITrainRouteService
    {
        List<TrainRouteEntity> GetAllTrainRoutes();
        TrainRouteEntity? GetTrainRouteById(int id);
        bool AddTrainRoute(TrainRouteEntity trainRoute);
        bool UpdateTrainRoute(int id, TrainRouteEntity trainRoute);
        bool DeleteTrainRoute(int id);
        bool ValidData(TrainRouteEntity trainRoute);
    }
}
