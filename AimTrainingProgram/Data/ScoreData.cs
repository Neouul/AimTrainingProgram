using System;
using System.Collections.Generic;
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
    }
}