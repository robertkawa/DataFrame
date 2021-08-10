using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace DataFrameComponent.DataTypes.Rows
{
    public class RowCollection : Collection<DataFrameRow>
    {
        private readonly DataFrame _dataFrame;
        private List<string> _columnNames = new();
        private Dictionary<string, int> _columnNameToIndexDictionary = new();
        
        public DataFrameRow this[long index] => new(_dataFrame, index);
        
        public RowCollection(DataFrame dataFrame) => _dataFrame = dataFrame ?? throw new ArgumentNullException(nameof (dataFrame));
    }
}