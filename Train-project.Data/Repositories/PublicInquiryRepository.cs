using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Train_project.Core.Entities;
using Train_project.Core.IRepositories;

namespace Train_project.Data.Repositories
{
    public class PublicInquiryRepository : IPublicInquiryRepository
    {
        readonly DataContext _dataContext;
        public PublicInquiryRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public List<PublicInquiryEntity> GetAllPublicInquiries()
        {
            return _dataContext.PublicInquiries.ToList();
        }
        public int PublicInquiryById(int id)
        {
            int indexPublicInquiry = _dataContext.PublicInquiries.ToList().FindIndex(PublicInquiry => PublicInquiry.InquiryId == id);
            return indexPublicInquiry;

        }
        public PublicInquiryEntity GetPublicInquiryById(int indexPublicInquiry)
        {
            return _dataContext.PublicInquiries.ToList()[indexPublicInquiry];
        }
        public bool AddPublicInquiry(PublicInquiryEntity publicInquiry)
        {
            try
            {
                _dataContext.PublicInquiries.Add(publicInquiry);
                _dataContext.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool UpdatePublicInquiry(int indexPublicInquiry, PublicInquiryEntity updatedInquiry)
        {
           
            PublicInquiryEntity existingInquiry = _dataContext.PublicInquiries.ToList()[indexPublicInquiry];

            if (updatedInquiry.DriverId > 0)
                existingInquiry.DriverId = updatedInquiry.DriverId;

            if (updatedInquiry.DateAndTime != default)
                existingInquiry.DateAndTime = updatedInquiry.DateAndTime;

            if (!string.IsNullOrEmpty(updatedInquiry.DescriptionInquiry))
                existingInquiry.DescriptionInquiry = updatedInquiry.DescriptionInquiry;

            existingInquiry.StatusInquiry = updatedInquiry.StatusInquiry; 

            if (updatedInquiry.TreatedBy > 0)
                existingInquiry.TreatedBy = updatedInquiry.TreatedBy;

            if (!string.IsNullOrEmpty(updatedInquiry.ComplainantsName))
                existingInquiry.ComplainantsName = updatedInquiry.ComplainantsName;

            if (!string.IsNullOrEmpty(updatedInquiry.ComplainantsPhone))
                existingInquiry.ComplainantsPhone = updatedInquiry.ComplainantsPhone;

            _dataContext.SaveChanges();
            return true;

        }
        public bool DeletePublicInquiry(int indexPublicInquiry)
        {
             _dataContext.PublicInquiries.Remove(_dataContext.PublicInquiries.ToList()[indexPublicInquiry]);
            _dataContext.SaveChanges();    
            return true;

        }
    }
}

