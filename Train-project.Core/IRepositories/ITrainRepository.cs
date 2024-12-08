using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Train_project.Core.Entities;

namespace Train_project.Core.IRepositories
{
    public interface ITrainRepository
    {
        List<TrainEntity> GetAllTrains();
        int TrainById(int id);
        TrainEntity GetTrainById(int indexTrain);
        bool AddTrain(TrainEntity train);
        bool UpdateTrain(int indexTrain, TrainEntity train);
        bool DeleteTrain(int indexTrain);
    }
}
