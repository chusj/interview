namespace GOFConsoleApp.AbstractFactory
{
    class WhiteHumanFactory : AbstractHumanFactory
    {
        public override Man CreateMan()
        {
            return new WhiteMan();
        }

        public override Woman CreateWoman()
        {
            return new WhiteWoman();
        }
    }
}
