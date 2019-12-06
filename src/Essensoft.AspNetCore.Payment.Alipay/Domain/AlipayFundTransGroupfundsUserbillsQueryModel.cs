using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayFundTransGroupfundsUserbillsQueryModel Data Structure.
    /// </summary>
    public class AlipayFundTransGroupfundsUserbillsQueryModel : AlipayObject
    {
        /// <summary>
        /// 指定具体活动对应的批次号列表，不超过20个批次
        /// </summary>
        [JsonPropertyName("batch_nos")]
        public List<string> BatchNos { get; set; }

        /// <summary>
        /// 当前用户支付宝账户ID
        /// </summary>
        [JsonPropertyName("current_user_id")]
        public string CurrentUserId { get; set; }
    }
}
