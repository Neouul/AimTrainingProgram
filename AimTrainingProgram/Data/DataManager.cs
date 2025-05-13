﻿using System;
using System.Collections.Generic;
using System.IO;
using AimTrainingProgram.Data;

namespace AimTrainingProgram
{
    public static class DataManager
    {
        private static readonly string filePath = "scoreData.txt";

        /// 점수 데이터를 저장하는 메서드
        public static void SaveScore(ScoreData data)
        {
            string dataLine = $"{data.Date} | {data.Score} | {data.GameSensitivity} | {data.ControlPanelSpeed}";
            File.AppendAllText(filePath, dataLine + Environment.NewLine);
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

                if (parts.Length == 4)
                {
                    try
                    {
                        DateTime date = DateTime.Parse(parts[0].Trim());
                        int score = int.Parse(parts[1].Trim());
                        int gameSens = int.Parse(parts[2].Trim());
                        int panelSpeed = int.Parse(parts[3].Trim());

                        scores.Add(new ScoreData
                        {
                            Date = date,
                            Score = score,
                            GameSensitivity = gameSens,
                            ControlPanelSpeed = panelSpeed
                        });
                    }
                    catch
                    {
                        // 잘못된 형식의 데이터는 무시
                        continue;
                    }
                }
            }

            return scores;
        }
    }
}