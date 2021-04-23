using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// ZhimaCreditEpSceneRatingInitializeModel Data Structure.
    /// </summary>
    public class ZhimaCreditEpSceneRatingInitializeModel : AlipayObject
    {
        /// <summary>
        /// 申请的信用额度，单位为分（人民币），整型。
        /// </summary>
        [JsonPropertyName("apply_amount")]
        public long ApplyAmount { get; set; }

        /// <summary>
        /// 特定业务场景传输的扩展参数，以JSON形式传输。具体业务场景需要传入参数请参考<a href="https://docs.open.alipay.com/11270#s3">业务场景传输的扩展参数</a>
        /// </summary>
        [JsonPropertyName("biz_ext_param")]
        public string BizExtParam { get; set; }

        /// <summary>
        /// 企业信用类目。请参考<a href= "https://docs.open.alipay.com/11270#s0">企业信用类目</a>
        /// </summary>
        [JsonPropertyName("credit_category")]
        public string CreditCategory { get; set; }

        /// <summary>
        /// 企业证件号，如果MemberType=ENTERPRISE,支持传入企业证件号来指定企业认证。
        /// </summary>
        [JsonPropertyName("ep_cert_no")]
        public string EpCertNo { get; set; }

        /// <summary>
        /// 企业名称，如果MemberType=ENTERPRISE,支持传入企业名称进行指定企业认证。
        /// </summary>
        [JsonPropertyName("ep_name")]
        public string EpName { get; set; }

        /// <summary>
        /// 评估类型。为空时默认为 CUSTOMER（对客户进行评估）。枚举如下： * CUSTOMER：对客户进行评估。 * TRADE：对交易进行评估。
        /// </summary>
        [JsonPropertyName("evaluate_type")]
        public string EvaluateType { get; set; }

        /// <summary>
        /// 客户经营行业分类。请参考<a href="https://docs.open.alipay.com/11270#s2">客户经营行业分类</a>
        /// </summary>
        [JsonPropertyName("m_category")]
        public string MCategory { get; set; }

        /// <summary>
        /// 会员类型。为空时默认为 INDIVIDUAL_BUSINESS（商家类型）进行评估。枚举如下： * ENTERPRISE：评估的会员类型为企业； * INDIVIDUAL_BUSINESS：评估的会员类型为商家。
        /// </summary>
        [JsonPropertyName("member_type")]
        public string MemberType { get; set; }

        /// <summary>
        /// 商户请求订单号，由商户自定义且必须在当前PID下唯一。用于唯一标识商户发起的一次请求。
        /// </summary>
        [JsonPropertyName("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 产品码。固定为 w1010100001000003531。
        /// </summary>
        [JsonPropertyName("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 用户userId，为2088开头的支付宝用户唯一id。获取方式开发者可以参考<a href="https://docs.open.alipay.com/284/106001">获取会员信息</a>。
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
