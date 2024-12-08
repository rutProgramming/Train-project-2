using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train_project.Core.Entities
{
    [Table("TrainRoute")]
    public class TrainRouteEntity
    {
        [Key]
        public int TrainRouteId { get; set; }
        public int Driver { get; set; }
        public int Train { get; set; }
        public int Station { get; set; }
        public DateTime FirstTrain { get; set; }
        public DateTime LastTrain { get; set; }
        public int SubstituteDriver{ get; set; }
        public TrainRouteEntity()
        {
                
        }

        public TrainRouteEntity(int idRoute, int driver, int train, int station, DateTime firstTrain, DateTime lastTrain, int substituteDriver)
        {
            TrainRouteId = idRoute;
            Driver = driver;
            Train = train;
            Station = station;
            FirstTrain = firstTrain;
            LastTrain = lastTrain;
            SubstituteDriver = substituteDriver;
        }
    }
}
