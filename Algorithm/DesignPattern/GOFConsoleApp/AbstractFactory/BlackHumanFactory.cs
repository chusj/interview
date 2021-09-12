namespace GOFConsoleApp.AbstractFactory
{
    class BlackHumanFactory : AbstractHumanFactory
    {
        public override Man CreateMan()
        {
            return new BlackMan(); ;
        }

        public override Woman CreateWoman()
        {
            return new BlackWoman();
        }
    }
}
