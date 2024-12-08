﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Train_project.Core.Entities;

namespace Train_project.Core.IServices
{
    public interface IPublicInquiryService
    {
        List<PublicInquiryEntity> GetAllPublicInquiries();
        PublicInquiryEntity? GetPublicInquiryById(int id);
        bool AddPublicInquiry(PublicInquiryEntity publicInquity);
        bool UpdatePublicInquiry(int id, PublicInquiryEntity publicInquity);
        bool DeletePublicInquiry(int id);
        bool ValidData(PublicInquiryEntity publicInquiry);
    }
}
