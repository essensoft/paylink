using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOfflineMarketingVoucherStatusQueryModel Data Structure.
    /// </summary>
    public class AlipayOfflineMarketingVoucherStatusQueryModel : AlipayObject
    {
        /// <summary>
        /// 外部流水号
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 券模板id
        /// </summary>
        [JsonPropertyName("voucher_id")]
        public string VoucherId { get; set; }
    }
}
