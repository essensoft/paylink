using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ApplySubAccountAndBindOrder Data Structure.
    /// </summary>
    public class ApplySubAccountAndBindOrder : AlipayObject
    {
        /// <summary>
        /// 机构ID，如ZL6、ZL7
        /// </summary>
        [JsonPropertyName("inst_id")]
        public string InstId { get; set; }

        /// <summary>
        /// 商户结算pid
        /// </summary>
        [JsonPropertyName("ip_role_id")]
        public string IpRoleId { get; set; }

        /// <summary>
        /// 上游申请请求单号，source + outBizNo 用于幂等。
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 来源，通常为业务系统名，source + outBizNo 用于幂等。
        /// </summary>
        [JsonPropertyName("source")]
        public string Source { get; set; }

        /// <summary>
        /// 财资业务识别码。用于财资识别需要使用的主账户。由财资预先分配。联系周丹
        /// </summary>
        [JsonPropertyName("treasury_business_type")]
        public string TreasuryBusinessType { get; set; }
    }
}
