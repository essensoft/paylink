using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// SubAccountAndBindDTO Data Structure.
    /// </summary>
    public class SubAccountAndBindDTO : AlipayObject
    {
        /// <summary>
        /// 银行子账号详情
        /// </summary>
        [JsonPropertyName("bank_sub_account_base_info_dto")]
        public BankSubAccountBaseInfoDTO BankSubAccountBaseInfoDto { get; set; }

        /// <summary>
        /// 业务唯一ID值。由业务方确保在同一个维度下值唯一。
        /// </summary>
        [JsonPropertyName("biz_unique_id")]
        public string BizUniqueId { get; set; }

        /// <summary>
        /// 业务唯一ID类型。用于识别子账号的不同维度。由AR平台预先分配
        /// </summary>
        [JsonPropertyName("biz_unique_type")]
        public string BizUniqueType { get; set; }

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
    }
}
