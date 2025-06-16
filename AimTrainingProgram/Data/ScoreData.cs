using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AimTrainingProgram.Data
{
    public class ScoreData
    {
        public DateTime Date { get; set; }
        public int Score { get; set; }
        public float GameSensitivity { get; set; }
        public int ControlPanelSpeed { get; set; }
        public string Mode { get; set; }  // 예: "Targeting" 또는 "Moving"
        public string Difficulty { get; set; }

    }

    namespace AimTrainingProgram.Data
    {
        public class TargetHitRecord
        {
            public Point Position { get; set; }
            public bool IsHit { get; set; }
        }
    }

}