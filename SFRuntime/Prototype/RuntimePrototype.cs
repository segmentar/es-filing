using Core;

namespace Core.Shared
{
    using System;

    public partial class SFRuntime
    {
        public SFRuntime(SFSource source, Boolean debug)
        {
            this.Source = source;

            if (debug is true)
            {
                this.IsDebug = true;
            }
            else
                "false".ToString();

            return;
        }
    }
}
