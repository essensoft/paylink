using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ZhimaCreditEpRatingInnerInitializeModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditEpRatingInnerInitializeModel : AlipayObject
    {
        /// <summary>
        /// 企业信用类目，支持以下值：  ZMSCCO_4_1_1:快(服务效率)-快速收款-商家货款快收  ZMSCCO_4_2_1:快(服务效率)-快速理赔-多收多保  ZMSCCO_6_1_1:省(交易成本)-信用后付-设备先享后付  ZMSCCO_6_2_1:省(交易成本)-保证金保险-免保证金
        /// </summary>
        [JsonProperty("credit_category")]
        public string CreditCategory { get; set; }

        /// <summary>
        /// 企业证件号，如果MemberType=ENTERPRISE,支持传入企业证件号来指定企业认证
        /// </summary>
        [JsonProperty("ep_cert_no")]
        public string EpCertNo { get; set; }

        /// <summary>
        /// 企业名称，如果MemberType=ENTERPRISE,支持传入企业名称进行指定企业认证
        /// </summary>
        [JsonProperty("ep_name")]
        public string EpName { get; set; }

        /// <summary>
        /// 客户经营行业分类
        /// </summary>
        [JsonProperty("m_category")]
        public string MCategory { get; set; }

        /// <summary>
        /// 企业会员类型，支持的类型为ENTERPRISE和INDIVIDUAL_BUSINESS。可空，不传按照默认行为，即INDIVIDUAL_BUSINESS商家身份。
        /// </summary>
        [JsonProperty("member_type")]
        public string MemberType { get; set; }

        /// <summary>
        /// 商户请求的唯一标志，64位长度的字母数字下划线组合。该标识作为对账的关键信息，商户要保证其唯一性。
        /// </summary>
        [JsonProperty("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}
