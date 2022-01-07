namespace DesingPatterns.FactoryMethod
{
    class FactoryClass1 : IClass1
    {
       
        public static IClass1 Create()
        {
            return Class1.Create();
        }
    }
}
