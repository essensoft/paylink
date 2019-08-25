using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceIotMdeviceprodTradeBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceIotMdeviceprodTradeBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 真实设备sn
        /// </summary>
        [JsonProperty("device_sn")]
        public string DeviceSn { get; set; }

        /// <summary>
        /// 物料id
        /// </summary>
        [JsonProperty("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 供应商id
        /// </summary>
        [JsonProperty("supplier_sn")]
        public string SupplierSn { get; set; }

        /// <summary>
        /// 交易流水号，优先级最高，如果传入则根据流水号查询
        /// </summary>
        [JsonProperty("trade_no")]
        public string TradeNo { get; set; }
    }
}
