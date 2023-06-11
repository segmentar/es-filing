using Core;

namespace Core.Shared
{
    using System;

    public partial class SFSource
    {
        public SFSource(SGText text, SFTarget target, Boolean debug)
        {
            this.Text = text;

            this.Target = target;

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
