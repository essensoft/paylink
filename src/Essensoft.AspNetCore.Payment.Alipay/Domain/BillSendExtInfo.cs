using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// BillSendExtInfo Data Structure.
    /// </summary>
    public class BillSendExtInfo : AlipayObject
    {
        /// <summary>
        /// 分账金额
        /// </summary>
        [JsonPropertyName("royalty_amount")]
        public string RoyaltyAmount { get; set; }

        /// <summary>
        /// 2088xxx
        /// </summary>
        [JsonPropertyName("trans_in_pid")]
        public string TransInPid { get; set; }
    }
}
