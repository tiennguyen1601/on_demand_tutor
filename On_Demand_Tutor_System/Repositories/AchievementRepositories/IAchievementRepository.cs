﻿using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.AchievementRepositories
{
    public interface IAchievementRepository
    {
        List<Achievement> GetAllAchievement();
        void SaveAchievement(Achievement achievement);
        void UpdateAchievement(Achievement achievement);
        void DeleteAchievement(short achievementId);
        Achievement GetAchievementById(short achievementId);
    }
}
