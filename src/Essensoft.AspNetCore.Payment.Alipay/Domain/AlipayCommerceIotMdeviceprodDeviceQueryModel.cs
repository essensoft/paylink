using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceIotMdeviceprodDeviceQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceIotMdeviceprodDeviceQueryModel : AlipayObject
    {
        /// <summary>
        /// 真实设备sn
        /// </summary>
        [JsonProperty("device_sn")]
        public string DeviceSn { get; set; }

        /// <summary>
        /// 物料id，supplier_sn/item_id二选一必填，如果在supplier_sn item_id都输入的情况下，优先匹配supplier_sn
        /// </summary>
        [JsonProperty("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 供应商id，supplier_sn/item_id参数二选一必填，如果在supplier_sn item_id都输入的情况下，优先匹配supplier_sn
        /// </summary>
        [JsonProperty("supplier_sn")]
        public string SupplierSn { get; set; }
    }
}
