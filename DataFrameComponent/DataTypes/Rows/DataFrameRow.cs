using System.Collections;
using System.Collections.Generic;

namespace DataFrameComponent.DataTypes.Rows
{
    public class DataFrameRow : IEnumerable<object>
    {
        private readonly DataFrame _dataFrame;
        private readonly long _rowIndex;
        
        public DataFrameRow(DataFrame dataFrame, long rowIndex)
        {
            _dataFrame = dataFrame;
            _rowIndex = rowIndex;
        }
        
        public IEnumerator<object> GetEnumerator()
        {
            foreach (var column in _dataFrame.Columns)
            {
                yield return column[_rowIndex];
            }
        }
        
        public object this[int index]
        {
            get => _dataFrame.Columns[index][_rowIndex];
            set => _dataFrame.Columns[index][_rowIndex] = value;
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}