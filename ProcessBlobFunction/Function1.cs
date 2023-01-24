using System;
using System.IO;
using System.Threading.Tasks;
using Azure.Storage.Blobs;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace ProcessBlobFunction
{
    public class Function1
    {
        [FunctionName("Function1")]
        public async Task Run([BlobTrigger("anishstorage78692/{name}", Connection = "connectionString")]Stream myBlob, [Blob("anishcontainer/{name}", FileAccess.ReadWrite)] BlobClient newBlob, string name, ILogger log)
        {
            await newBlob.UploadAsync(myBlob);
        }
    }
}
