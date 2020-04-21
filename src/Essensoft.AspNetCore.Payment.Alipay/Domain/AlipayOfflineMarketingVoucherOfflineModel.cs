using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOfflineMarketingVoucherOfflineModel Data Structure.
    /// </summary>
    public class AlipayOfflineMarketingVoucherOfflineModel : AlipayObject
    {
        /// <summary>
        /// 下架描述
        /// </summary>
        [JsonPropertyName("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 外部流水号.需商家自己生成并保证每次请求的唯一性
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 券模板编号
        /// </summary>
        [JsonPropertyName("voucher_id")]
        public string VoucherId { get; set; }
    }
}
