namespace GOFConsoleApp.FactoryMethod
{
    class HumanFacotry
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="time">时间长短 1.长 2.短  3.时间刚好</param>
        /// <returns></returns>
        public IHuman CreateHuman(int time)
        {
            if (time == 1)
            {
                return new BlackHuman();
            }
            else if(time == 2)
            {
                return new WhiteHuman();
            }
            else
            {
                return null;
            }
        }
    }
}
