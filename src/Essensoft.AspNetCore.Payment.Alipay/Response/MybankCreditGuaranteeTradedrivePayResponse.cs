using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// MybankCreditGuaranteeTradedrivePayResponse.
    /// </summary>
    public class MybankCreditGuaranteeTradedrivePayResponse : AlipayResponse
    {
        /// <summary>
        /// 调用成功则返回调用业务编码
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
