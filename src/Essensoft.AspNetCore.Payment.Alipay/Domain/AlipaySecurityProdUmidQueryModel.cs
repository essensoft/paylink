using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipaySecurityProdUmidQueryModel Data Structure.
    /// </summary>
    public class AlipaySecurityProdUmidQueryModel : AlipayObject
    {
        /// <summary>
        /// tokenID,客户端对应的token值: token由应用系统生成, 缓存在前台页面, 生成UMID的时候会传到UMID系统
        /// </summary>
        [JsonPropertyName("token_id")]
        public string TokenId { get; set; }
    }
}
