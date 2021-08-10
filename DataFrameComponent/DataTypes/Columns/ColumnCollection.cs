using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using DataFrameComponent.DataTypes.Columns.Specifics;
using DataFrameComponent.Resources;

namespace DataFrameComponent.DataTypes.Columns
{
    public class ColumnCollection : Collection<DataFrameColumn>
    {
        private List<string> _columnNames = new();
        private Dictionary<string, int> _columnNameToIndexDictionary = new();
        
        public IntegerDataFrameColumn GetIntegerColumn(string name)
        {
            var dataFrameColumn = this[name];
            
            return dataFrameColumn is IntegerDataFrameColumn integerDataFrameColumn
                ? integerDataFrameColumn
                : throw new ArgumentException(string.Format(Errors.BadColumnCast, dataFrameColumn.DataType, typeof(int)));
        }
        
        public StringDataFrameColumn GetStringColumn(string name)
        {
            var dataFrameColumn = this[name];
            
            return dataFrameColumn is StringDataFrameColumn stringDataFrameColumn
                ? stringDataFrameColumn
                : throw new ArgumentException(string.Format(Errors.BadColumnCast, dataFrameColumn.DataType, typeof(string)));
        }
        
        public DecimalDataFrameColumn GetDecimalColumn(string name)
        {
            var dataFrameColumn = this[name];
            
            return dataFrameColumn is DecimalDataFrameColumn decimalDataFrameColumn
                ? decimalDataFrameColumn
                : throw new ArgumentException(string.Format(Errors.BadColumnCast, dataFrameColumn.DataType, typeof(byte)));
        }
        
        public DataFrameColumn this[string columnName]
        {
            get
            {
                var index = IndexOf(columnName);
                return index != -1 ? this[index] : throw new ArgumentException(string.Format(Errors.InvalidColumnName, columnName), nameof (columnName));
            }
            set
            {
                var index = IndexOf(columnName);
                if (index == -1)
                {
                    Insert(Count, value);
                }
                else
                {
                    this[index] = value;
                }
            }
        }
        
        public int IndexOf(string columnName)
        {
            return columnName != null && _columnNameToIndexDictionary.TryGetValue(columnName, out var num) ? num : -1;
        }
    }
}