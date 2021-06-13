using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// SettleExtendParams Data Structure.
    /// </summary>
    public class SettleExtendParams : AlipayObject
    {
        /// <summary>
        /// 本笔交易的分账操作是否已完结，可传入的值：true/false。 如果指定完结分账，则本次分账处理完成后会把该笔交易的剩余冻结金额全额解冻；
        /// </summary>
        [JsonPropertyName("royalty_finish")]
        public string RoyaltyFinish { get; set; }
    }
}
