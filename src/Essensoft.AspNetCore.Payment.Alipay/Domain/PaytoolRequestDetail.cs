using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// PaytoolRequestDetail Data Structure.
    /// </summary>
    public class PaytoolRequestDetail : AlipayObject
    {
        /// <summary>
        /// 支付工具金额。单位为元，精确到小数点后两位，取值范围[0.01,100000000]
        /// </summary>
        [JsonPropertyName("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 付款方身份识别信息
        /// </summary>
        [JsonPropertyName("payer_identity")]
        public UserIdentity PayerIdentity { get; set; }

        /// <summary>
        /// 定义为商户定制化的支付请求业务信息，由支付宝定义和管控，通常业务信息对于支付工具本身是弱依赖的。格式为json格式的字符串，需带上转移符。
        /// </summary>
        [JsonPropertyName("paytool_business_info")]
        public string PaytoolBusinessInfo { get; set; }

        /// <summary>
        /// 商户支付工具单据号。注：不同的请求需更换不同的paytool_request_no，否则视为幂等请求
        /// </summary>
        [JsonPropertyName("paytool_request_no")]
        public string PaytoolRequestNo { get; set; }

        /// <summary>
        /// 支付宝统一分配的支付工具编码;  现金:CASH;支付宝:ALIPAY,营销:TMARKETING;POS支付:POS,商户预付卡:MERCHANT_MCARD,OTHER:其他。注：通常情况下不传入OTHER，若需传入，请与接口owner联系确认
        /// </summary>
        [JsonPropertyName("tool_code")]
        public string ToolCode { get; set; }
    }
}
