using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Train_project.Core.Entities;
using Train_project.Core.IRepositories;

namespace Train_project.Data.Repositories
{
    public class TrainRepository : ITrainRepository
    {
        readonly DataContext _dataContext;
        public TrainRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public List<TrainEntity> GetAllTrains()
        {
            return _dataContext.Trains.ToList();
        }
        public int TrainById(int id)
        {
            int indexTrain = _dataContext.Trains.ToList().FindIndex(Train => Train.TrainID == id);
            return indexTrain;

        }
        public TrainEntity GetTrainById(int indexTrain)
        {
            return _dataContext.Trains.ToList()[indexTrain];
        }
        public bool AddTrain(TrainEntity train)
        {
            try
            {
                _dataContext.Trains.ToList().Add(train);
                _dataContext.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool UpdateTrain(int indexTrain, TrainEntity updatedTrain)
        {
           TrainEntity existingTrain=_dataContext.Trains.ToList()[indexTrain] ;
            if (updatedTrain.TrainLine != 0) 
                existingTrain.TrainLine = updatedTrain.TrainLine;

            if (updatedTrain.NumberOfCars > 0) 
                existingTrain.NumberOfCars = updatedTrain.NumberOfCars;

            existingTrain.TrainStatus = updatedTrain.TrainStatus; 

            if (!string.IsNullOrWhiteSpace(updatedTrain.RegularRoute))
                existingTrain.RegularRoute = updatedTrain.RegularRoute;

            if (!string.IsNullOrWhiteSpace(updatedTrain.Model)) 
                existingTrain.Model = updatedTrain.Model;

            if (updatedTrain.ServiceDate != default) 
                existingTrain.ServiceDate = updatedTrain.ServiceDate;
            _dataContext.SaveChanges();
            return true;
        }
        public bool DeleteTrain(int indexTrain)
        {
            _dataContext.Trains.Remove(_dataContext.Trains.ToList()[indexTrain]);
            _dataContext.SaveChanges();
            return true;

        }

    }
}
