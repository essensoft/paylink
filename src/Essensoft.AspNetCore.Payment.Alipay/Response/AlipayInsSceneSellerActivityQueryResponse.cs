using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayInsSceneSellerActivityQueryResponse.
    /// </summary>
    public class AlipayInsSceneSellerActivityQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 关于签约查询结果的告知
        /// </summary>
        [JsonPropertyName("ins_seller_activity")]
        public InsSellerActivity InsSellerActivity { get; set; }
    }
}
