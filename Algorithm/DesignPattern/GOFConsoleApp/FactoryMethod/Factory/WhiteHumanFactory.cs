namespace GOFConsoleApp.FactoryMethod
{
    class WhiteHumanFactory : AbstractHumanFacotry
    {
        public override IHuman CreateHuman()
        {
            return new WhiteHuman();
        }
    }
}
