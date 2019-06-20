using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// EcoCenRenthousepayTypeList Data Structure.
    /// </summary>
    [Serializable]
    public class EcoCenRenthousepayTypeList : AlipayObject
    {
        /// <summary>
        /// 集中式房源最小押金
        /// </summary>
        [JsonProperty("foregift_amount")]
        public string ForegiftAmount { get; set; }

        /// <summary>
        /// 集中式最高价格，支持小数点后面2位。
        /// </summary>
        [JsonProperty("max_amount")]
        public string MaxAmount { get; set; }

        /// <summary>
        /// 集中式房源最大押金
        /// </summary>
        [JsonProperty("max_deposit_amount")]
        public string MaxDepositAmount { get; set; }

        /// <summary>
        /// 其它费用
        /// </summary>
        [JsonProperty("other_amount")]
        public List<EcoRenthouseOtherAmount> OtherAmount { get; set; }

        /// <summary>
        /// 付款方式（1：付一，2：付二）
        /// </summary>
        [JsonProperty("pay_type")]
        public long PayType { get; set; }

        /// <summary>
        /// 租金
        /// </summary>
        [JsonProperty("room_amount")]
        public string RoomAmount { get; set; }
    }
}
