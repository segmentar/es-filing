using Core;

namespace Core.Shared
{
    using System;

    public partial class SFRuntime
    {
        public static SFRuntime ForgeRuntime(String value, String filename, Boolean debug)
        {
            SFRuntime runtimeResult = default;

            var text = SGText.Runtime_MakeTextNew(value);

            var target = SFTarget.Runtime_MakeTargetNew(filename);

            var source = SFSource.Runtime_MakeSourceNew(text, target);

            runtimeResult = MakeRuntimeNew(source, debug);

            return runtimeResult;
        }
    }
}
