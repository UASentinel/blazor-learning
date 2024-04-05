namespace BlazorServerApp.Pages
{
    public partial class Sandbox
    {
        private string userName = "Volodymyr";
        private int age = 19;
        private List<TestClass> elements;

        protected override void OnInitialized()
        {
            base.OnInitialized();

            elements = new List<TestClass>() { new TestClass(1, "One"), new TestClass(2, "Two") };
        }

        private string GetUserName()
        {
            return userName;
        }

        private int GetSum()
        {
            return 2 + 2;
        }

        private void ChangeUserName()
        {
            userName = "Vadym";
        }

        private class TestClass
        {
            public int Value { get; set; }
            public string Label { get; set; }

            public TestClass(int value, string label)
            {
                Value = value;
                Label = label;
            }
        }
    }
}
