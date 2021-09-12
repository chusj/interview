namespace GOFConsoleApp.AbstractFactory
{
    abstract class AbstractHumanFactory
    {
        public abstract Man CreateMan();

        public abstract Woman CreateWoman();
    }
}
