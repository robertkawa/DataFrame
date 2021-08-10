using DataFrameComponent.DataTypes;

namespace DataFrameComponent.Factories
{
    public interface IDataFrameCreator
    {
        public DataFrame Create(string fileName);
    }
}