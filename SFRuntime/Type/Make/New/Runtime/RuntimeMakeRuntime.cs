using Core;

namespace Core.Shared
{
    using System;

    public partial class SFRuntime
    {
        public static SFRuntime Runtime_MakeRuntimeNew(SFSource source)
        {
            SFRuntime runtimeResult = default;

            runtimeResult = MakeRuntimeNew(source, SAPolicy.RuntimeDebugPolicy);

            return runtimeResult;
        }
    }
}
