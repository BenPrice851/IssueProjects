using Plugin.Media;
using Plugin.Media.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace IssuesApp
{
    public class PhotoManager
    {
        public async Task<string> TakeNewPhoto()
        {
            try
            {
                if (!CrossMedia.IsSupported || !CrossMedia.Current.IsCameraAvailable || !CrossMedia.Current.IsTakePhotoSupported)
                {
                    return string.Empty;
                }

                if (!await PermissionHelpers.GetPermission<Permissions.Camera>())
                {
                    return string.Empty;
                }

                var photo = await CrossMedia.Current.TakePhotoAsync(new StoreCameraMediaOptions
                {
                    PhotoSize = PhotoSize.Small,
                    SaveToAlbum = false
                });

                if (photo != null)
                {
                    return "photo taken successfully";
                }

                return string.Empty;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
