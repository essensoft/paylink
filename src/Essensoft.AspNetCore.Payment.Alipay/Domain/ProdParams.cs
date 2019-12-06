using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ProdParams Data Structure.
    /// </summary>
    public class ProdParams : AlipayObject
    {
        /// <summary>
        /// 预授权业务信息
        /// </summary>
        [JsonPropertyName("auth_biz_params")]
        public string AuthBizParams { get; set; }
    }
}
