using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MybankCreditSceneprodPreadmitQueryModel Data Structure.
    /// </summary>
    public class MybankCreditSceneprodPreadmitQueryModel : AlipayObject
    {
        /// <summary>
        /// 客户姓名，开户时使用
        /// </summary>
        [JsonPropertyName("customer_name")]
        public string CustomerName { get; set; }

        /// <summary>
        /// 机构编码，机构接入场景金融平台时分配，固定值
        /// </summary>
        [JsonPropertyName("org_code")]
        public string OrgCode { get; set; }

        /// <summary>
        /// 机构特殊的校验规则
        /// </summary>
        [JsonPropertyName("pre_admit_rule")]
        public string PreAdmitRule { get; set; }

        /// <summary>
        /// 产品编码，场景金融平台给机构提供的产品编码
        /// </summary>
        [JsonPropertyName("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 本次请求流水号，全局唯一
        /// </summary>
        [JsonPropertyName("seq_no")]
        public string SeqNo { get; set; }

        /// <summary>
        /// 外部站点，比如：ALIPAY：支付宝站点，MYBANK：银行会员，B2B_CN：B2B中文站，B2B_EN：B2B国际站，TAOBAO：淘宝； PERSON：身份证；
        /// </summary>
        [JsonPropertyName("site")]
        public string Site { get; set; }

        /// <summary>
        /// 外部站点的userid，该字段内容与site的内容相关
        /// </summary>
        [JsonPropertyName("site_user_id")]
        public string SiteUserId { get; set; }
    }
}
