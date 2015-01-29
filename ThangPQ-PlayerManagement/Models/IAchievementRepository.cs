using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThangPQ_PlayerManagement.Models
{
    public interface IAchievementRepository
    {
        IEnumerable<Achievement> GetAchievements();
        Achievement GetAchievementByName(String name);
        void InsertAchievement(Achievement achievement);
        void DeleteAchievement(String name);
        void EditAchievement(Achievement achievement);
    }
}
