using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AntMerchantExpandImageUploadResponse.
    /// </summary>
    public class AntMerchantExpandImageUploadResponse : AlipayResponse
    {
        /// <summary>
        /// 图片在sfs中的标识
        /// </summary>
        [JsonProperty("image_id")]
        [XmlElement("image_id")]
        public string ImageId { get; set; }
    }
}
