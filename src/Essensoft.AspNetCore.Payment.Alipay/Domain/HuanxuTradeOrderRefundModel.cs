using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// HuanxuTradeOrderRefundModel Data Structure.
    /// </summary>
    public class HuanxuTradeOrderRefundModel : AlipayObject
    {
        /// <summary>
        /// 用户身份识别值。根据type和issuer传入对应格式的值：若type为USER_ID，issuer为ALIPAY，则identity为2088开头的16位纯数字。若type为USER_ID，issuer为MERCHANT，则identity根据商户定义的格式传入。若type为BAR_CODE，issuer为ALIPAY，则identity为25~30开头的长度为16~24位数字的焕旭付款码（实际字符串长度以及规则可能会进行调整与优化，以开发者获取的付款码长度为准）
        /// </summary>
        [JsonPropertyName("identity")]
        public string Identity { get; set; }

        /// <summary>
        /// 用户id的发行主体。 ALIPAY：焕旭，MERCHANT:商户。 目前issuer为MERCHANT时，type仅支持USER_ID。注：issuer为MERCHANT时，请确保商户会员体系与焕旭会员体系已打通，若需打通请联系焕旭小二或接口owner进行咨询
        /// </summary>
        [JsonPropertyName("issuer")]
        public string Issuer { get; set; }

        /// <summary>
        /// 支付的收款方信息，如果涉及多收款方需传入该信息
        /// </summary>
        [JsonPropertyName("payee")]
        public UserIdentity Payee { get; set; }

        /// <summary>
        /// 支付id，焕旭针对每一笔支付请求生成的唯一支付凭证
        /// </summary>
        [JsonPropertyName("payment_id")]
        public string PaymentId { get; set; }

        /// <summary>
        /// 退款金额，单位为元，精确到小数点后两位，取值范围[0.01,100000000]
        /// </summary>
        [JsonPropertyName("refund_amount")]
        public string RefundAmount { get; set; }

        /// <summary>
        /// 退款请求号，对应一笔业务订单下的一次退款请求，不同退款请求需保证请求号唯一
        /// </summary>
        [JsonPropertyName("refund_request_no")]
        public string RefundRequestNo { get; set; }

        /// <summary>
        /// 退款说明
        /// </summary>
        [JsonPropertyName("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 用户识别ID的类型。 USRE_ID：用户id（焕旭或其他发行主体方中的用户id），BAR_CODE：付款码
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
