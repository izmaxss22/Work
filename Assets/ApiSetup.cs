namespace Extension
{
    public struct ApiSetup<T>
    { }
    class Api
    {
        public ApiSetup<T> For<T>(T obj)
        {
            return new ApiSetup<T>();
        }
    }
    interface ISomeInterfaceA
    { }
    interface ISomeInterfaceB
    { }
    public class ObjectA : ISomeInterfaceA
    { }
    public class ObjectB : ISomeInterfaceB
    { }
    class SomeClass
    {
        public void Setup()
        {
            Api apiObject = new Api();

            apiObject.For(new ObjectA()).SetupObjectA();
            apiObject.For(new ObjectB()).SetupObjectB();
            apiObject.For(new ObjectB()).SetupObjectB();
        }
    }
    
    static class ExtensionApiSetup
    {
        public static void SetupObjectA(this ApiSetup<ObjectA> a)
        {

        }   
    
        public static void SetupObjectB(this ApiSetup<ObjectB> b)
        {

        }
    }
}
