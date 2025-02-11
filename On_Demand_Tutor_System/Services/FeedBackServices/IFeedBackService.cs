﻿using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.FeedBackServices
{
    public interface IFeedBackService
    {
        List<Feedback> GetAllFeedback();
        void SaveFeedback(Feedback feedback);
        void UpdateFeedback(Feedback feedback);
        void DeleteFeedback(short feedbackId);
        Feedback GetFeedbackById(short feedbackId);
        Task<bool> AddFeedbackAsync(Feedback feedback);
        (double OneStar, double TwoStar, double ThreeStar, double FourStar, double FiveStar) GetRatingPercentages();
    }
}
