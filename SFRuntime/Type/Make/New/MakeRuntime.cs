using Core;

namespace Core.Shared
{
    using System;

    public partial class SFRuntime
    {
        public static SFRuntime MakeRuntimeNew(SFSource source, Boolean debug)
        {
            SFRuntime runtimeResult = default;

            runtimeResult = new SFRuntime(source, debug);

            return runtimeResult;
        }
    }
}
