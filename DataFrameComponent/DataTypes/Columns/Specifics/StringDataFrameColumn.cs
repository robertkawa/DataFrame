using System;
using System.Linq;

namespace DataFrameComponent.DataTypes.Columns.Specifics
{
    public class StringDataFrameColumn : PrimitiveDataFrameColumn<string>
    {
        public override long UniqueCount() => Convert.ToInt64(this.Distinct());
    }
}