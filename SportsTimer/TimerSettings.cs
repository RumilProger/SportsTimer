namespace SportsTimer
{
    internal struct TimerSettings
    {
        public TimerSettings(int intervals, int circles, int space, int firstTime, int secondTime)
        {
            Intervals = intervals;
            Circles = circles;
            Space = space;
            FirstTime = firstTime;
            SecondTime = secondTime;
        }

        public int Intervals { get; internal set; }
        public int Circles { get; internal set; }
        public int FirstTime { get; internal set; }
        public int SecondTime{ get; internal set; }
        public int Space { get; internal set; }
    }
}