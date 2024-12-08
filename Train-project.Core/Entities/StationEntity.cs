using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train_project.Core.Entities
{
    public enum  StationType { UrbanStation, IntercityStation }
    [Table("Station")]
    public class StationEntity
    {
        [Key]
        public int StationID { get; set; }
        public string StationName { get; set; }
        public string StationAddress { get; set; }
        public string StationCity { get; set; }
        public string LocationGPSCoordinates{ get; set; }
        public string StationType { get; set; }
        public int NumberOfPlatforms { get; set; }
        public StationEntity()
        {
            
        }

        public StationEntity(int stationID, string stationName, string stationAddress, string stationCity, string locationGPSCoordinates, string stationType, int numberOfPlatforms)
        {
            StationID = stationID;
            StationName = stationName;
            StationAddress = stationAddress;
            StationCity = stationCity;
            LocationGPSCoordinates = locationGPSCoordinates;
            StationType = stationType;
            NumberOfPlatforms = numberOfPlatforms;
        }
    }
}
