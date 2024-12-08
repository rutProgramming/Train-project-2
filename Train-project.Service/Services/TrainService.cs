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
    public class TrainService:ITrainService
    {
        readonly ITrainRepository _trainRepository;
        public TrainService(ITrainRepository trainRepository)
        {
            _trainRepository = trainRepository;
        }
        public List<TrainEntity> GetAllTrains()
        {
            return _trainRepository.GetAllTrains(); 
        }
        
        public TrainEntity? GetTrainById(int id)
        {
            int indexTrain =_trainRepository.TrainById(id);
            if (indexTrain != -1)
            {
                return _trainRepository.GetTrainById(indexTrain);
            }
            return null;
        }
        public bool AddTrain(TrainEntity train)
        {
            int indexTrain =_trainRepository.TrainById(train.TrainID);
            if (indexTrain == -1)
            {
                return _trainRepository.AddTrain(train);
            }
            return false;
        }
        public bool UpdateTrain(int id, TrainEntity train)
        {
            int indexTrain = _trainRepository.TrainById(id);
            if (indexTrain != -1)
            {
                return _trainRepository.UpdateTrain(indexTrain, train);
            }
            return false;
        }
        public bool DeleteTrain(int id)
        {
            int indexTrain = _trainRepository.TrainById(id);
            if (indexTrain != -1)
            {
                return _trainRepository.DeleteTrain(indexTrain);
            }
            return false;
        }

    }
}
