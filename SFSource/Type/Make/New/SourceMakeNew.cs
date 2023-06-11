using Core;

namespace Core.Shared
{
    using System;

    public partial class SFSource
    {
        public static SFSource MakeSourceNew(SGText text, SFTarget target, Boolean debug)
        {
            SFSource sourceResult = default;

            sourceResult = new SFSource(text, target, debug);

            return sourceResult;
        }
    }
}
