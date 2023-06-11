using Core;

namespace Core.Shared
{
    using System;

    public partial class SFRuntime
    {
        public static SFRuntime Runtime_ForgeRuntime(String value, String filename)
        {
            SFRuntime runtimeResult = default;

            runtimeResult = ForgeRuntime(value, filename, SAPolicy.RuntimeDebugPolicy);

            return runtimeResult;
        }
    }
}
