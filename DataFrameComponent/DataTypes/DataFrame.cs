using System;
using DataFrameComponent.DataTypes.Columns;
using DataFrameComponent.DataTypes.Rows;

namespace DataFrameComponent.DataTypes
{
    public class DataFrame
    {
        private readonly ColumnCollection _columnCollection;
        private readonly RowCollection _rowCollection;
        
        public ColumnCollection Columns => _columnCollection;
        
        public RowCollection Rows => _rowCollection;

        public double Mean(string columnName)
        {
            var columnCollection = _columnCollection[columnName];
            return columnCollection.Mean();
        }
        
        public double UniqueCount(string columnName)
        {
            var columnCollection = _columnCollection[columnName];
            return columnCollection.Mean();
        }

        public DataFrame GroupBy(string columnName)
        {
            var index = _columnCollection.IndexOf(columnName);
            return _columnCollection[index].GroupBy(index, this);
        }
        
        public DataFrame OrderBy(string columnName) => OrderBy(columnName, true);
        
        public DataFrame OrderByDescending(string columnName) => OrderBy(columnName, false);
        
        private DataFrame OrderBy(string columnName, bool isAscending)
        {
            throw new NotImplementedException();
        }
        
        public DataFrame Filter(string columnName, Func<DataFrameColumn, bool> predicate)
        {
            throw new NotImplementedException();
        }
    }
}