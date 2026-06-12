using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace Project
{
    [Serializable]
    public class PlayerSaveData
    {
        public string Name;
        public int Income;
        public List<int> HighScore;
        public List<int[]> BestTime;   // [hour, min, sec]
        public List<int[]> PrevTime;

        public PlayerSaveData(Players p)
        {
            Name = p.Name;
            Income = p.Income;
            HighScore = new List<int>(p.HighScore);
            BestTime = p.BestTime
                          .Select(t => new int[] { t.Hour, t.Minute, t.Second })
                          .ToList();
            PrevTime = p.PrevTime
                          .Select(t => new int[] { t.Hour, t.Minute, t.Second })
                          .ToList();
        }
    }
}