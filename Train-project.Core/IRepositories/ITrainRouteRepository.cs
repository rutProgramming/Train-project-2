using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Train_project.Core.Entities;

namespace Train_project.Core.IRepositories
{
    public interface ITrainRouteRepository
    {
        List<TrainRouteEntity> GetAllTrainRoutes();
        TrainRouteEntity GetTrainRouteById(int indexTrainRoute);
        int TrainRouteById(int id);
        bool AddTrainRoute(TrainRouteEntity trainRoute);
        bool UpdateTrainRoute(int indexTrainRoute, TrainRouteEntity trainRoute);
        bool DeleteTrainRoute(int indexTrainRoute);
    }
}
