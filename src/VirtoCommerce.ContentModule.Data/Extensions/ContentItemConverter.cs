using System;
using VirtoCommerce.ContentModule.Core.Model;
using VirtoCommerce.AssetsModule.Core.Assets;
using VirtoCommerce.Platform.Core.Common;

namespace VirtoCommerce.ContentModule.Data.Extensions
{
    public static class ContentItemConverter
    {
        public static ContentFolder ToContentModel(this BlobFolder blobFolder)
        {
            if (blobFolder == null)
                throw new ArgumentNullException(nameof(blobFolder));

            var contentFolder = AbstractTypeFactory<ContentFolder>.TryCreateInstance();

            contentFolder.Name = blobFolder.Name;
            contentFolder.Url = blobFolder.Url;
            contentFolder.ParentUrl = blobFolder.ParentUrl;
            contentFolder.RelativeUrl = blobFolder.RelativeUrl;
            contentFolder.CreatedDate = blobFolder.CreatedDate;
            contentFolder.ModifiedDate = blobFolder.ModifiedDate;
            contentFolder.Type = blobFolder.Type;

            return contentFolder;
        }

        public static ContentFile ToContentModel(this BlobInfo blobInfo)
        {
            if (blobInfo == null)
                throw new ArgumentNullException(nameof(blobInfo));

            var contentFile = AbstractTypeFactory<ContentFile>.TryCreateInstance();

            contentFile.Name = blobInfo.Name;
            contentFile.Url = blobInfo.Url;
            contentFile.Size = blobInfo.Size.ToString();
            contentFile.RelativeUrl = blobInfo.RelativeUrl;
            contentFile.CreatedDate = blobInfo.CreatedDate;
            contentFile.ModifiedDate = blobInfo.ModifiedDate;
            contentFile.Type = blobInfo.Type;
            contentFile.MimeType = blobInfo.ContentType;

            return contentFile;
        }
    }
}
