using Core;

namespace Core.Shared
{
    using System;

    using System.IO;

    using System.Text;

    public partial class SFSource
    {
        public static SFSource CreateFilename(String filename)
        {
            SFSource sourceResult = default;

            sourceResult = new SFSource();

            Byte[] byteArray;

            using (FileStream stream = File.OpenRead(filename))
            {
                byteArray = new Byte[stream.Length];

                var count = stream.Read(byteArray, 0, byteArray.Length);

                var encode = Encoding.Default.GetString(byteArray, 0, count);

                var text = SGText.Runtime_MakeTextNew(encode);

                SFTarget target;

                target = SFTarget.Runtime_MakeTargetNew(filename);

                sourceResult.Target = target;

                sourceResult.Text = text;

                stream.Flush();

                stream.Close();

                stream.Dispose();
            }

            return sourceResult;
        }
    }
}
