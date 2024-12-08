using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Train_project.Core.Entities;
using Train_project.Core.IRepositories;

namespace Train_project.Data.Repositories
{
    public class TrainRouteRepository : ITrainRouteRepository
    {
        readonly DataContext _dataContext;
        public TrainRouteRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public List<TrainRouteEntity> GetAllTrainRoutes()
        {
            return _dataContext.TrainRoutes.ToList();
        }
        public int TrainRouteById(int id)
        {
            int indexTrainRoute = _dataContext.TrainRoutes.ToList().FindIndex(TrainRoute => TrainRoute.TrainRouteId == id);
            return indexTrainRoute;

        }
        public TrainRouteEntity GetTrainRouteById(int indexTrainRoute)
        {
            return _dataContext.TrainRoutes.ToList()[indexTrainRoute];
        }
        public bool AddTrainRoute(TrainRouteEntity trainRoute)
        {
            try
            {
                _dataContext.TrainRoutes.Add(trainRoute);
                _dataContext.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool UpdateTrainRoute(int indexTrainRoute, TrainRouteEntity updatedTrainRoute)
        {
            TrainRouteEntity existingTrainRoute = _dataContext.TrainRoutes.ToList()[indexTrainRoute];
            if (updatedTrainRoute.Driver != 0)
                existingTrainRoute.Driver = updatedTrainRoute.Driver;

            if (updatedTrainRoute.Train != 0)
                existingTrainRoute.Train = updatedTrainRoute.Train;

            if (updatedTrainRoute.Station != 0)
                existingTrainRoute.Station = updatedTrainRoute.Station;

            if (updatedTrainRoute.FirstTrain != default)
                existingTrainRoute.FirstTrain = updatedTrainRoute.FirstTrain;

            if (updatedTrainRoute.LastTrain != default)
                existingTrainRoute.LastTrain = updatedTrainRoute.LastTrain;

            if (updatedTrainRoute.SubstituteDriver != 0)
                existingTrainRoute.SubstituteDriver = updatedTrainRoute.SubstituteDriver;

            _dataContext.SaveChanges();
            return true;
        }
        public bool DeleteTrainRoute(int indexTrainRoute)
        {
            _dataContext.TrainRoutes.Remove(_dataContext.TrainRoutes.ToList()[indexTrainRoute]);
            _dataContext.SaveChanges();
            return true;

        }
    }
}
