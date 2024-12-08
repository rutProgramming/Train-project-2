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
    public class TrainRouteService : ITrainRouteService
    {
        readonly ITrainRouteRepository _trainRouteRepository;
        public TrainRouteService(ITrainRouteRepository trainRouteRepository)
        {
            _trainRouteRepository = trainRouteRepository;
        }
        public List<TrainRouteEntity> GetAllTrainRoutes()
        {
            return _trainRouteRepository.GetAllTrainRoutes();
        }
        
        public TrainRouteEntity? GetTrainRouteById(int id)
        {
            int indexTrainRoute =_trainRouteRepository.TrainRouteById(id);
            if (indexTrainRoute != -1)
            {
                return _trainRouteRepository.GetTrainRouteById(indexTrainRoute);
            }
            return null;
        }
        public bool AddTrainRoute(TrainRouteEntity trainRoute)
        {
            int indexTrainRoute =_trainRouteRepository.TrainRouteById(trainRoute.TrainRouteId);
            if (indexTrainRoute == -1 && ValidData(trainRoute))
            {
                return _trainRouteRepository.AddTrainRoute(trainRoute);
            }
            return false;
        }

        public bool UpdateTrainRoute(int id, TrainRouteEntity trainRoute)
        {
            int indexTrainRoute = _trainRouteRepository.TrainRouteById(id);

            if (indexTrainRoute != -1 && ValidData(trainRoute))
            {
                return _trainRouteRepository.UpdateTrainRoute(indexTrainRoute, trainRoute);
            }
            return false;
        }
        public bool DeleteTrainRoute(int id)
        {
            int indexTrainRoute = _trainRouteRepository.TrainRouteById(id);
            if (indexTrainRoute != -1)
            {
                return _trainRouteRepository.DeleteTrainRoute(indexTrainRoute);
            }
            return false;
        }

        public bool ValidData(TrainRouteEntity trainRoute)
        {
            return (trainRoute.FirstTrain==default|| trainRoute.LastTrain==default)?true: Valid.LastTimeAfterFirstTime(trainRoute.FirstTrain, trainRoute.LastTrain);
        }
    }
}

