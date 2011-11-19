
namespace MVVM.Events
{
    public class FunctionEventParameter
    {
        public string ViewName { get; set; }
        public object DataIn { get; set; }

        public FunctionEventParameter Init(string viewName, object dataIn)
        {
            ViewName = viewName;
            DataIn = dataIn;
            return this;
        }
    }
}
