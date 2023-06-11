using Core;

namespace Core.Shared
{
    using System;

    public partial class SFTarget
    {
        public override String ToString()
        {
            return String.Join('\n'.ToString(), new String[] { 
                String.Empty + nameof(SFTarget) + ' ' + "::" + ' ' + '{',
                String.Empty + '.' + "compress",
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(IsDebug) + ':' + ' ' + IsDebug,
                String.Empty + '.' + "compress-raw", 
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(Filename) + ':' + ' ' + $"[{Filename}]",
                String.Empty + '}'
            });
        }
    }
}
