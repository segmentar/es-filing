using Core;

namespace Core.Shared
{
    using System;

    public partial class SFTarget
    {
        public static SFTarget MakeTargetNew(String filename, Boolean debug)
        {
            SFTarget targetResult = default;

            targetResult = new SFTarget(filename, debug);

            return targetResult;
        }
    }
}
