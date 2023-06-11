using Core;

namespace Core.Shared
{
    using System;

    public partial class SFTarget
    {
        public static SFTarget Runtime_MakeTargetNew(String filename)
        {
            SFTarget targetResult = default;

            targetResult = MakeTargetNew(filename, SAPolicy.TargetDebugPolicy);

            return targetResult;
        }
    }
}
