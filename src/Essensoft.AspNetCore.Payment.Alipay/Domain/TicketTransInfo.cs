using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// TicketTransInfo Data Structure.
    /// </summary>
    [Serializable]
    public class TicketTransInfo : AlipayObject
    {
        /// <summary>
        /// 流水创建时间
        /// </summary>
        [JsonProperty("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 最后修改时间，也就是流水状态更新为成功的时间
        /// </summary>
        [JsonProperty("last_modify_time")]
        public string LastModifyTime { get; set; }

        /// <summary>
        /// 流水涉及凭证数量，若为普通商品则为1， 若为次卡则为操作的凭证份数
        /// </summary>
        [JsonProperty("quantity")]
        public string Quantity { get; set; }

        /// <summary>
        /// 凭证流水id
        /// </summary>
        [JsonProperty("ticket_trans_id")]
        public string TicketTransId { get; set; }

        /// <summary>
        /// 流水类型
        /// </summary>
        [JsonProperty("ticket_trans_type")]
        public string TicketTransType { get; set; }
    }
}
