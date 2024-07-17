﻿using BusinessObjects.Models;

namespace Repositories.Tutors
{
    public interface ITutorServiceRepository
    {
        List<TutorService> GetTutorServices();
        void AddTutorService(TutorService tutorService);
        void DeleteTutorService(int id);
        void UpdateTutorService(TutorService tutorService);
        TutorService GetTutorServiceByServiceId(int id);
        decimal GetTutorServicePrice(int tutorId, int serviceId);
    }
}
