using Newtonsoft.Json;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Alipay.Response
{
    /// <summary>
    /// AlipayOfflineMaterialImageDownloadResponse.
    /// </summary>
    public class AlipayOfflineMaterialImageDownloadResponse : AlipayResponse
    {
        /// <summary>
        /// 图片地址列表，按入参id顺序返回，如果某个id转化失败，则用空字符占位
        /// </summary>
        [JsonProperty("image_urls")]
        public List<string> ImageUrls { get; set; }
    }
}
