﻿namespace Indian_States_Census_Analyzer_Problem
{
    public abstract class CensusAdapter
    {
        protected string[] GetCensusData(string csvFilePath, string dataHeaders)
        {
            string[] censusData;
            if (!File.Exists(csvFilePath))
            {
                throw new CensusAnalyserException("File not found", CensusAnalyserException.ExceptionType.FILE_NOT_FOUND);
            }
            if (Path.GetExtension(csvFilePath) != ".csv")
            {
                throw new CensusAnalyserException("Invalid file type", CensusAnalyserException.ExceptionType.FILE_NOT_FOUND);
            }
            censusData = File.ReadAllLines(csvFilePath);
            if (censusData[0] != dataHeaders)
            {
                throw new CensusAnalyserException("Incorrect header in Data", CensusAnalyserException.ExceptionType.INCORRECR_HEADER);
            }
            return censusData;
        }
    }
}