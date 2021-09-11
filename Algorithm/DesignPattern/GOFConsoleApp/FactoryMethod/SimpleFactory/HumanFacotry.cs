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
            else //缺点：如果增加黄种人、其他颜色人种，需要N个if判断语句
            {
                return null;
            }
        }
    }
}
