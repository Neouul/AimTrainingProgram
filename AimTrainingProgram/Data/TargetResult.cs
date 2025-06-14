using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AimTrainingProgram.Data
{
    public class TargetResult
    {
        public Point Position { get; set; }   // 타겟 중심 위치
        public bool IsHit { get; set; }       // 명중 여부
    }
}
