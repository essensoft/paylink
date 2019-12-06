using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// EcoCenRenthousepayTypeList Data Structure.
    /// </summary>
    public class EcoCenRenthousepayTypeList : AlipayObject
    {
        /// <summary>
        /// 集中式房源最小押金
        /// </summary>
        [JsonPropertyName("foregift_amount")]
        public string ForegiftAmount { get; set; }

        /// <summary>
        /// 集中式最高价格，支持小数点后面2位。
        /// </summary>
        [JsonPropertyName("max_amount")]
        public string MaxAmount { get; set; }

        /// <summary>
        /// 集中式房源最大押金
        /// </summary>
        [JsonPropertyName("max_deposit_amount")]
        public string MaxDepositAmount { get; set; }

        /// <summary>
        /// 其它费用
        /// </summary>
        [JsonPropertyName("other_amount")]
        public List<EcoRenthouseOtherAmount> OtherAmount { get; set; }

        /// <summary>
        /// 付款方式（1：付一，2：付二）
        /// </summary>
        [JsonPropertyName("pay_type")]
        public long PayType { get; set; }

        /// <summary>
        /// 租金
        /// </summary>
        [JsonPropertyName("room_amount")]
        public string RoomAmount { get; set; }
    }
}
