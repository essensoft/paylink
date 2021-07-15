using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// BillSendExtInfo Data Structure.
    /// </summary>
    public class BillSendExtInfo : AlipayObject
    {
        /// <summary>
        /// 账单唤起收银台的方式： 1-手机wap;2-当面付。默认值为1（不传值或传非数字值）
        /// </summary>
        [JsonPropertyName("order_pay_type")]
        public string OrderPayType { get; set; }

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
