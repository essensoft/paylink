using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoMycarMaintainOrderserverNotifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoMycarMaintainOrderserverNotifyModel : AlipayObject
    {
        /// <summary>
        /// 更改金额。变更项影响金额。金额增加为正数，金额减少为负数。金额单位(元)，保留两位小数。
        /// </summary>
        [JsonProperty("change_cost")]
        public string ChangeCost { get; set; }

        /// <summary>
        /// 变更描述，描述订单变更内容。
        /// </summary>
        [JsonProperty("change_desc")]
        public string ChangeDesc { get; set; }

        /// <summary>
        /// 车主平台订单编号
        /// </summary>
        [JsonProperty("order_no")]
        public string OrderNo { get; set; }
    }
}
