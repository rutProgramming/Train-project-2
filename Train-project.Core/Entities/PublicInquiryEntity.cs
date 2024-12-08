using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train_project.Core.Entities
{
    [Table("PublicInquiry")]
    public class PublicInquiryEntity
    {

        [Key]
        public int InquiryId { get; set; }
        public int DriverId { get; set; }
        public DateTime DateAndTime { get; set; }
        public string DescriptionInquiry { get; set; }
        public bool StatusInquiry { get; set; }
        public int TreatedBy { get; set; }
        public string ComplainantsName { get; set; }
        public string ComplainantsPhone { get; set; }
        public PublicInquiryEntity()
        {
            
        }
        public PublicInquiryEntity(int inquiryId, int driverId, DateTime dateAndTime, string descriptionInquiry, bool statusInquiry, int treatedBy, string complainantsName, string complainantsPhone)
        {
            InquiryId = inquiryId;
            DriverId = driverId;
            DateAndTime = dateAndTime;
            DescriptionInquiry = descriptionInquiry;
            StatusInquiry = statusInquiry;
            TreatedBy = treatedBy;
            ComplainantsName = complainantsName;
            ComplainantsPhone = complainantsPhone;
        }
    }
}
