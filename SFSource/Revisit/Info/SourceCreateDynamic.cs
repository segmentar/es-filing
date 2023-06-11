using Core;

namespace Core.Shared
{
    using System;

    using System.IO;

    using System.Text;

    public partial class SFSource
    {
        public static SFSource CreateDynamic(String name, String code)
        {
            SFSource sourceResult = default;

            /*var path_directory_full_name = Path.Combine(SharedEnvironment.GetDynamicFolder(), name);

            if (Directory.Exists(path_directory_full_name) is false)
            {
                Directory.CreateDirectory(path_directory_full_name);
            }
            else
                "false".ToString();

            var path_filename = Path.Combine(path_directory_full_name, $"{name}-guid-{Guid.NewGuid()}");

            var path_filename_with_extension = Path.ChangeExtension(path_filename, "esc");

            using (FileStream stream = File.Create(path_filename_with_extension))
            {
                var byteArray = Encoding.Default.GetBytes(code);

                stream.Write(byteArray, 0, byteArray.Length);

                stream.Flush();

                stream.Close();

                stream.Dispose();
            }

            SFTarget target;

            target = SFTarget.Runtime_MakeTargetNew(path_filename_with_extension);

            sourceResult = new SFSource();

            sourceResult.Target = target;

            sourceResult.Text = code;*/

            return sourceResult;
        }
    }
}
