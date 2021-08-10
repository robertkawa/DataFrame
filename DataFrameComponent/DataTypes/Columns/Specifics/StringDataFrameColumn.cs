using System;
using System.Linq;

namespace DataFrameComponent.DataTypes.Columns.Specifics
{
    public class StringDataFrameColumn : PrimitiveDataFrameColumn<string>
    {
        public override long CountUnique() => Convert.ToInt64(this.Distinct());
    }
}