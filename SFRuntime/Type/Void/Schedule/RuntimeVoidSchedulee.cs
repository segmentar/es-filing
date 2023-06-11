using Core;

namespace Core.Shared
{
    using System;

    public partial class SFRuntime
    {
        public static void ScheduleRuntimeVoid(SFSource source)
        {
            SArchitecture.RuntimeRunning.Source = source;

            return;
        }
    }
}
