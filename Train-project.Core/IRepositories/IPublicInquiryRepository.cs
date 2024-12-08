using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Train_project.Core.Entities;

namespace Train_project.Core.IRepositories
{
    public interface IPublicInquiryRepository
    {
        List<PublicInquiryEntity> GetAllPublicInquiries();
        int PublicInquiryById(int id);

        PublicInquiryEntity GetPublicInquiryById(int indexPublicInquiry);
        bool AddPublicInquiry(PublicInquiryEntity publicInquity);
        bool UpdatePublicInquiry(int indexPublicInquiry, PublicInquiryEntity publicInquity);
        bool DeletePublicInquiry(int indexPublicInquiry);
    }
}
