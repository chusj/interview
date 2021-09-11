namespace GOFConsoleApp.FactoryMethod
{
    class BlackHumanFactory : AbstractHumanFacotry
    {
        public override IHuman CreateHuman()
        {
            return new BlackHuman();
        }
    }
}
