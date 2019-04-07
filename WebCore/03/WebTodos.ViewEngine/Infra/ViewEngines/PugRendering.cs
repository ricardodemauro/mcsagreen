using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.NodeServices;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace WebTodos.ViewEngine.Infra.ViewEngines
{
    public class PugRendering
    {
        private readonly INodeServices _nodeServices;
        private PugzorViewEngineOptions _options;
        private readonly IFileProvider _fileProvider;

        private const string FILE_COMPRESSED = "embeddedNodeResources.zip";

        public PugRendering(INodeServices nodeServices, IFileProvider fileProvider, IOptions<PugzorViewEngineOptions> options)
        {
            _nodeServices = nodeServices;
            _options = options.Value;
            _fileProvider = fileProvider;

            ExtractNodeModules(FILE_COMPRESSED);
        }

        private void ExtractNodeModules(string fileName)
        {
            if (!File.Exists(fileName))
                throw new FileNotFoundException($"File {fileName} not found");

            using (var stream = _fileProvider.GetFileInfo(fileName).CreateReadStream())
            {
                var archive = new ZipArchive(stream, ZipArchiveMode.Read, false);
                var pugFile = _fileProvider.GetFileInfo("wwwroot/view-engine/pugcompile");


                var tempDir = new DirectoryInfo(pugFile.PhysicalPath);
                foreach (var entry in archive.Entries)
                {
                    var filePath = $"{tempDir.FullName}\\{entry.FullName}";
                    if (File.Exists(filePath))
                    {
                        continue;
                    }

                    Directory.CreateDirectory(new FileInfo(filePath).DirectoryName);
                    entry.ExtractToFile(filePath, true);
                }
            }
        }

        public async Task<string> Render(FileInfo pugFile, object model, ViewDataDictionary viewData, ModelStateDictionary modelState)
        {
            var opts = _options != null ? new
            {
                pretty = _options.Pretty ? "\t" : null,
                basedir = _options.BaseDir
            } : new object();

            return await _nodeServices
                .InvokeAsync<string>("pugcompile", pugFile.FullName, model, viewData, modelState, opts)
                .ConfigureAwait(false);
        }
    }
}
