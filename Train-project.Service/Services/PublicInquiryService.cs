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
    public class PublicInquiryService : IPublicInquiryService
    {
        readonly IPublicInquiryRepository _publicInquiryRepository;
        public PublicInquiryService(IPublicInquiryRepository publicInquiryRepository)
        {
            _publicInquiryRepository = publicInquiryRepository;
        }
        public List<PublicInquiryEntity> GetAllPublicInquiries()
        {
            return _publicInquiryRepository.GetAllPublicInquiries();
        }
        
        public PublicInquiryEntity? GetPublicInquiryById(int id)
        {
            int indexPublicInquiry=_publicInquiryRepository.PublicInquiryById(id);
            if (indexPublicInquiry !=-1)
            {
                return _publicInquiryRepository.GetPublicInquiryById(indexPublicInquiry);
            }
            return null;
        }
        public bool AddPublicInquiry(PublicInquiryEntity publicInquity)
        {
            int indexPublicInquiry =_publicInquiryRepository.PublicInquiryById(publicInquity.InquiryId);
            if (indexPublicInquiry == -1&&ValidData(publicInquity))
            {
                return _publicInquiryRepository.AddPublicInquiry(publicInquity);
            }
            return false;
        }
        public bool UpdatePublicInquiry(int id, PublicInquiryEntity publicInquity)
        {
            int indexPublicInquiry = _publicInquiryRepository.PublicInquiryById(id);
            if (indexPublicInquiry != -1&&ValidData(publicInquity))
            {
                return _publicInquiryRepository.UpdatePublicInquiry(indexPublicInquiry,publicInquity);
            }
            return false;
        }
        public bool DeletePublicInquiry(int id)
        {
            int indexPublicInquiry = _publicInquiryRepository.PublicInquiryById(id);
            if (indexPublicInquiry != -1)
            {
                return _publicInquiryRepository.DeletePublicInquiry(indexPublicInquiry);
            }
            return false;
        }
        public bool ValidData(PublicInquiryEntity publicInquiry)
        {
            return string.IsNullOrEmpty(publicInquiry.ComplainantsPhone)?true:Valid.IsIsraeliPhoneNumberValid(publicInquiry.ComplainantsPhone);
        }
    }
}
