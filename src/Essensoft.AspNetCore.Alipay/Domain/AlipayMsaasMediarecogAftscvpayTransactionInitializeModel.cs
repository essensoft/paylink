using Newtonsoft.Json;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// AlipayMsaasMediarecogAftscvpayTransactionInitializeModel Data Structure.
    /// </summary>
    public class AlipayMsaasMediarecogAftscvpayTransactionInitializeModel : AlipayObject
    {
        /// <summary>
        /// 商品信息,列表
        /// </summary>
        [JsonProperty("goods_infos")]
        public List<GoodInfo> GoodsInfos { get; set; }

        /// <summary>
        /// 售卖设备编号
        /// </summary>
        [JsonProperty("terminal_id")]
        public string TerminalId { get; set; }

        /// <summary>
        /// 云平台请求唯一标示,保证用户请求的幂等性.
        /// </summary>
        [JsonProperty("transaction_id")]
        public string TransactionId { get; set; }
    }
}
