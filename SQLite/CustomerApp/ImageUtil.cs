using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace CustomerApp {
    public static class ImageUtil {
        // BitmapImageをバイト配列に変換（データベース保存用）
        public static byte[] ToByteArray(BitmapImage image) {
            if (image == null || image.UriSource == null) return null;

            try {
                // 画像をJPEG形式でエンコード
                JpegBitmapEncoder encoder = new JpegBitmapEncoder();
                encoder.Frames.Add(BitmapFrame.Create(image));

                using (MemoryStream ms = new MemoryStream()) {
                    encoder.Save(ms);
                    return ms.ToArray();
                }
            }
            catch {
                return null; // 変換エラー時はnullを返す
            }
        }


        public static BitmapImage ToBitmapImage(byte[] imageBytes) {
            if (imageBytes == null || imageBytes.Length == 0) return null;

            try {
                using (var ms = new MemoryStream(imageBytes)) {
                    var image = new BitmapImage();
                    image.BeginInit();
                    image.CacheOption = BitmapCacheOption.OnLoad;
                    image.StreamSource = ms;
                    image.EndInit();
                    image.Freeze();
                    return image;
                }
            }
            catch {
                return null; 
            }
        }
    }
}
