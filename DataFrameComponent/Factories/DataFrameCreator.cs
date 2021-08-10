using System;
using DataFrameComponent.DataTypes;
using DataFrameComponent.Factories.Specifics;

namespace DataFrameComponent.Factories
{
    public static class DataFrameCreator
    {
        public static DataFrame Create(string fileName, DataFrameSourceType sourceType)
        {
            if (string.IsNullOrEmpty(fileName))
            {
                throw new ArgumentException("File name is empty", nameof(fileName));
            }

            var dataFrameCreator = CreateConcreteDataFrameCreator(sourceType);

            return dataFrameCreator.Create(fileName);
        }

        private static IDataFrameCreator CreateConcreteDataFrameCreator(DataFrameSourceType sourceType)
        {
            return sourceType switch
            {
                DataFrameSourceType.Json => new JsonDataFrameCreator(),
                DataFrameSourceType.Excel => new ExcelDataFrameCreator(),
                DataFrameSourceType.Csv => new CsvDataFrameCreator(),
                _ => throw new ArgumentOutOfRangeException(nameof(sourceType), sourceType, null)
            };
        }
    }
}