using PPM.Acumen.DataService.Client.Files.DTOs;
using System.IO;
using System.Threading.Tasks;

namespace PPM.Acumen.DataService.Client.Files.Interfaces
{
    public interface IFilesService
    {
        /// <summary>
        /// Uploads a gzip-compressed workbook JSON payload to object storage.
        /// Returns a FileUploadResponse containing a short-lived fileUid (valid 1 hour)
        /// to pass to the import endpoint.
        /// </summary>
        /// <param name="content">Gzip-compressed workbook JSON stream. Maximum 200 MB.</param>
        /// <param name="fileName">File name sent in the multipart Content-Disposition header.</param>
        Task<FileUploadResponse> UploadAsync(Stream content, string fileName = "workbook.json.gz");
    }
}
