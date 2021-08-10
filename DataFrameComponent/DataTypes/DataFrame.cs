using System;
using DataFrameComponent.DataTypes.Columns;
using DataFrameComponent.DataTypes.Rows;

namespace DataFrameComponent.DataTypes
{
    public class DataFrame
    {
        public ColumnCollection Columns { get; }

        public RowCollection Rows { get; }

        public DataFrame(ColumnCollection columns, RowCollection rows)
        {
            Columns = columns;
            Rows = rows;
        }

        public double Mean(string columnName) => Columns[columnName].Mean();
        
        public double UniqueCount(string columnName) => Columns[columnName].UniqueCount();

        public double Sum(string columnName) => Columns[columnName].Sum();

        public double Median(string columnName) => Columns[columnName].Median();

        public DataFrame GroupBy(string columnName)
        {
            var index = Columns.IndexOf(columnName);
            return Columns[index].GroupBy(index, this);
        }
        
        public DataFrame OrderBy(string columnName) => OrderBy(columnName, true);
        
        public DataFrame OrderByDescending(string columnName) => OrderBy(columnName, false);
        
        private DataFrame OrderBy(string columnName, bool isAscending) => throw new NotImplementedException();
        
        public DataFrame Filter(string columnName, Func<DataFrameColumn, bool> predicate) => throw new NotImplementedException();
    }
}