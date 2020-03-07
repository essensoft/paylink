using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AntMerchantExpandMerchantTypeQueryResponse.
    /// </summary>
    public class AntMerchantExpandMerchantTypeQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 返回值及对应含义如下：  indirect-纯间连商户  duplex-间连直连双重身份商户  other-其他类型
        /// </summary>
        [JsonPropertyName("indirect_bind_type")]
        public string IndirectBindType { get; set; }

        /// <summary>
        /// 返回值及对应含义  koubei-口碑商户  other-非口碑商户
        /// </summary>
        [JsonPropertyName("kb_type")]
        public string KbType { get; set; }

        /// <summary>
        /// 返回值及对应汗液如下：  offline_pay_signed-已签约线下支付  other-其他情况
        /// </summary>
        [JsonPropertyName("merchant_sign_type")]
        public string MerchantSignType { get; set; }
    }
}
