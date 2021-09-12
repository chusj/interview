namespace GOFConsoleApp.AbstractFactory
{
    /// <summary>
    /// 女娲，造人了
    /// </summary>
    class NvWa2
    {
        public void Create()
        {
            AbstractHumanFactory factory = new BlackHumanFactory();
            Man blackMan = factory.CreateMan();
            blackMan.Gender();
            blackMan.SkinColor();

            Woman  woman = factory.CreateWoman();
            woman.Gender();
            woman.SkinColor();
        }
    }
}
