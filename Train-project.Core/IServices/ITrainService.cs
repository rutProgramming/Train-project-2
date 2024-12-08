using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Train_project.Core.Entities;

namespace Train_project.Core.IServices
{
    public interface ITrainService
    {
        List<TrainEntity> GetAllTrains();
        TrainEntity? GetTrainById(int id);
        bool AddTrain(TrainEntity train);
        bool UpdateTrain(int id, TrainEntity train);
        bool DeleteTrain(int id);
    }
}
