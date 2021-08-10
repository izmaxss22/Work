namespace BoxingTrouble
{
    interface ISomeInterface
    {
        void Call();
    }
    struct SomeStruct : ISomeInterface
    {
        public void Call() { }
    }
    class SomeClass
    {
        public void Run()
        {
            var someStruct = new SomeStruct();
            SomeMethod(someStruct);
        }
        public void SomeMethod(SomeStruct someStruct)
        {
            someStruct.Call();
        }
    }
}
