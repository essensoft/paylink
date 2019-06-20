using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MiniAppPackageInfo Data Structure.
    /// </summary>
    [Serializable]
    public class MiniAppPackageInfo : AlipayObject
    {
        /// <summary>
        /// 包二维码地址
        /// </summary>
        [JsonProperty("package_qr_code_url")]
        public string PackageQrCodeUrl { get; set; }

        /// <summary>
        /// 包大小
        /// </summary>
        [JsonProperty("package_size")]
        public long PackageSize { get; set; }

        /// <summary>
        /// 包状态  Packaged 打包成功  Packaging 打包中  Fail 打包失败  NotPackage 未打包
        /// </summary>
        [JsonProperty("package_status")]
        public string PackageStatus { get; set; }
    }
}
