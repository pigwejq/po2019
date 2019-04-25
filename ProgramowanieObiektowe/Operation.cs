namespace Finances
{
    namespace Employees
    {
        public class Operation
        {
            private string Label;
            private string Type;
            private decimal Value;

            public Operation(string label, string type, decimal value)
            {
                Label = label;
                Type = type;
                Value = value;
            }

            public void SetLabel(string label)
            {
                Label = label;
            }
            public void SetType(string type)
            {
                Type = type;
            }
            public void SetValue(decimal value)
            {
                Value = value;
            }

            public string OperationInfo()
            {
                return $"Operation label: {Label}\nOperation Type: {Type}\nOperation Value: {Value}";
            }
        }
    }
}
