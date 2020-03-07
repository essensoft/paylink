using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiMarketingCampaignVoucherDetailQueryResponse.
    /// </summary>
    public class KoubeiMarketingCampaignVoucherDetailQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 券状态列表如下：  VALID：可用；WRITED_OFF：已核销；EXPIRED：已过期；CLOSED：已关闭；WAIT_APPLY：已冻结；DELETED：已删除；
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// 券详情对象
        /// </summary>
        [JsonPropertyName("voucher")]
        public Voucher Voucher { get; set; }

        /// <summary>
        /// 券id
        /// </summary>
        [JsonPropertyName("voucher_id")]
        public string VoucherId { get; set; }
    }
}
