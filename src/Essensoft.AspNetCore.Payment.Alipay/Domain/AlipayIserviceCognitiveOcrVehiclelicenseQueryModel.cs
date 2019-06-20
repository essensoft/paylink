using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayIserviceCognitiveOcrVehiclelicenseQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceCognitiveOcrVehiclelicenseQueryModel : AlipayObject
    {
        /// <summary>
        /// 行驶证图片base64加密后内容，大小限制在1.5M
        /// </summary>
        [JsonProperty("image_content")]
        public string ImageContent { get; set; }

        /// <summary>
        /// face: 行驶证正面 back: 行驶证副页 缺省值是：face
        /// </summary>
        [JsonProperty("side")]
        public string Side { get; set; }
    }
}
