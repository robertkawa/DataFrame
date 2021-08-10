using System;
using System.Linq;

namespace DataFrameComponent.DataTypes.Columns.Specifics
{
    public class IntegerDataFrameColumn : PrimitiveDataFrameColumn<int>
    {
        public override double Mean() => Length == 0L ? 0.0 : Sum() / Length;
        
        public override long CountUnique() => Convert.ToInt64(this.Distinct());
    }
}