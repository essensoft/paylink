using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// TradeSettleInfo Data Structure.
    /// </summary>
    [Serializable]
    public class TradeSettleInfo : AlipayObject
    {
        /// <summary>
        /// 交易结算明细信息
        /// </summary>
        [JsonProperty("trade_settle_detail_list")]
        public List<TradeSettleDetail> TradeSettleDetailList { get; set; }
    }
}
