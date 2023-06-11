using Core;

namespace Core.Shared
{
    using System;

    public partial class SFSource
    {
        public static SFSource Runtime_MakeSourceNew(SGText text, SFTarget target)
        {
            SFSource sourceResult = default;

            sourceResult = new SFSource(text, target, SAPolicy.SourceDebugPolicy);

            return sourceResult;
        }
    }
}
