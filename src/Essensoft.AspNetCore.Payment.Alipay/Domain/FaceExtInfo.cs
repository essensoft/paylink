using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// FaceExtInfo Data Structure.
    /// </summary>
    public class FaceExtInfo : AlipayObject
    {
        /// <summary>
        /// query_type不填, 返回uid  query_type=1, 返回手机号  query_type=2, 返回图片
        /// </summary>
        [JsonPropertyName("query_type")]
        public string QueryType { get; set; }
    }
}
