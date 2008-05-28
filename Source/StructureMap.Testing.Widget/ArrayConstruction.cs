using System;
using StructureMap.Pipeline;

namespace StructureMap.Testing.Widget
{
    public interface IList
    {
        int Count { get; }
    }

    [Pluggable("String")]
    public class StringList : IList
    {
        public string[] values;

        public StringList(string[] Values)
        {
            values = Values;
        }

        #region IList Members

        public int Count
        {
            get { return values.Length; }
        }

        #endregion
    }

    [Pluggable("Integer")]
    public class IntegerList : IList
    {
        public int[] values;

        public IntegerList(int[] Values)
        {
            values = Values;
        }

        #region IList Members

        public int Count
        {
            get { return values.Length; }
        }

        #endregion
    }


    public class StringListBuilder : InstanceBuilder
    {
        public override object BuildInstance(IConfiguredInstance instance, StructureMap.Pipeline.IBuildSession session)
        {
            return null;
        }


        public override Type PluggedType
        {
            get { return null; }
        }
    }
}