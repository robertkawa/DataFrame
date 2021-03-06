#nullable enable
using System;
using System.Collections;
using System.Collections.Generic;

namespace DataFrameComponent.DataTypes.Columns
{
    public class PrimitiveDataFrameColumn<T> : DataFrameColumn, IEnumerable<T?>
    {
        public IEnumerator<T?> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        protected override object GetValue(long rowIndex)
        {
            throw new NotImplementedException();
        }

        protected override void SetValue(long rowIndex, object value)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}