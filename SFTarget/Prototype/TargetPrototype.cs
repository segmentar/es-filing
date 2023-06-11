using Core;

namespace Core.Shared
{
    using System;

    public partial class SFTarget
    {
        public SFTarget(String filename, Boolean debug)
        {
            this.Filename = filename;

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
