using System;
using System.Linq;

namespace DataFrameComponent.DataTypes.Columns.Specifics
{
    public class DecimalDataFrameColumn : PrimitiveDataFrameColumn<decimal>
    {
        public override double Mean() => Length == 0L ? 0.0 : Sum() / Length;
        
        public override long UniqueCount() => Convert.ToInt64(this.Distinct());
    }
}