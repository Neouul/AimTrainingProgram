using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using AimTrainingProgram.Data;
using AimTrainingProgram.Data.AimTrainingProgram.Data;

namespace AimTrainingProgram
{
    public static class DataManager
    {
        private static readonly string filePath = "scoreData.txt";
        private static readonly string hitRecordPath = "hitRecords.txt";

        /// 점수 데이터를 저장하는 메서드
        public static void SaveScore(ScoreData data)
        {
            string dataLine = $"{data.Date} | {data.Score} | {data.GameSensitivity} | {data.ControlPanelSpeed} | {data.Mode} | {data.Difficulty}";
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine(dataLine);
                writer.Flush();
            }
        }

        public static void SaveHitRecords(List<TargetHitRecord> records)
        {
            using (StreamWriter writer = new StreamWriter(hitRecordPath, true))
            {
                foreach (var r in records)
                {
                    writer.WriteLine($"{r.Position.X},{r.Position.Y},{r.IsHit}");
                }
            }
        }

        /// 점수 데이터를 불러오는 메서드
        public static List<ScoreData> LoadScores()
        {
            List<ScoreData> scores = new List<ScoreData>();

            if (!File.Exists(filePath)) return scores;

            string[] lines = File.ReadAllLines(filePath);

            foreach (string line in lines)
            {
                string[] parts = line.Split('|');

                if (parts.Length == 6)
                {
                    try
                    {
                        DateTime date = DateTime.Parse(parts[0].Trim());
                        int score = int.Parse(parts[1].Trim());
                        float gameSens = float.Parse(parts[2].Trim());
                        int panelSpeed = int.Parse(parts[3].Trim());
                        string mode = parts[4].Trim();
                        string difficulty = parts[5].Trim();

                        scores.Add(new ScoreData
                        {
                            Date = date,
                            Score = score,
                            GameSensitivity = gameSens,
                            ControlPanelSpeed = panelSpeed,
                            Mode = mode,
                            Difficulty = difficulty
                        });
                    }
                    catch
                    {
                        // 잘못된 데이터는 무시
                        continue;
                    }
                }
            }

            return scores;
        }

        public static List<TargetHitRecord> LoadHitRecords()
        {
            List<TargetHitRecord> records = new List<TargetHitRecord>();
            if (!File.Exists(hitRecordPath)) return records;

            foreach (var line in File.ReadAllLines(hitRecordPath))
            {
                var parts = line.Split(',');
                if (parts.Length == 3 && int.TryParse(parts[0], out int x) && int.TryParse(parts[1], out int y) && bool.TryParse(parts[2], out bool hit))
                {
                    records.Add(new TargetHitRecord { Position = new Point(x, y), IsHit = hit });
                }
            }
            return records;
        }

        public static List<TargetHitRecord> LoadRecentHitRecords()
        {
            if (!File.Exists(hitRecordPath)) return new List<TargetHitRecord>();

            var lines = File.ReadAllLines(hitRecordPath);
            var grouped = new List<TargetHitRecord>();

            foreach (var line in lines)
            {
                if (string.IsNullOrWhiteSpace(line)) continue;
                var parts = line.Split(',');
                if (parts.Length == 3 &&
                    int.TryParse(parts[0], out int x) &&
                    int.TryParse(parts[1], out int y) &&
                    bool.TryParse(parts[2], out bool isHit))
                {
                    grouped.Add(new TargetHitRecord { Position = new Point(x, y), IsHit = isHit });
                }
            }

            return grouped;
        }

        public static void ClearHitRecords()
        {
            if (File.Exists(hitRecordPath))
            {
                File.WriteAllText(hitRecordPath, string.Empty); // 기록 파일 비우기
            }
        }

    }
}