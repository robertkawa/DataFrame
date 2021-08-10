using System;
using System.Collections;

namespace DataFrameComponent.DataTypes.Columns
{
    public abstract class DataFrameColumn : IEnumerable
    {
        private long _length;
        
        public long Length
        {
            get => _length;
            protected set => _length = value >= 0L ? value : throw new ArgumentOutOfRangeException(nameof(Length));
        }
        
        public Type DataType { get; }
        
        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
        
        public object this[long rowIndex]
        {
            get => GetValue(rowIndex);
            set => SetValue(rowIndex, value);
        }
        
        public virtual double Mean() => throw new NotImplementedException();

        public virtual double Median() => throw new NotImplementedException();
        
        public virtual long UniqueCount() => throw new NotImplementedException();
        
        public virtual double Sum() => throw new NotImplementedException();
        
        public virtual DataFrame GroupBy(int columnIndex, DataFrame dateFrame) => throw new NotImplementedException();
        
        protected abstract object GetValue(long rowIndex);
        
        protected abstract void SetValue(long rowIndex, object length);
    }
}