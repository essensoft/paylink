using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOfflineMaterialImageDownloadResponse.
    /// </summary>
    public class AlipayOfflineMaterialImageDownloadResponse : AlipayResponse
    {
        /// <summary>
        /// 图片地址列表，按入参id顺序返回，如果某个id转化失败，则用空字符占位
        /// </summary>
        [JsonPropertyName("image_urls")]
        public List<string> ImageUrls { get; set; }
    }
}
