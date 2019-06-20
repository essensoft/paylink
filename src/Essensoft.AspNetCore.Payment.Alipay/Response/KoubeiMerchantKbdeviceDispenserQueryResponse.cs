using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.Alipay.Domain;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiMerchantKbdeviceDispenserQueryResponse.
    /// </summary>
    public class KoubeiMerchantKbdeviceDispenserQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 取餐柜设备是否可用
        /// </summary>
        [JsonProperty("availability")]
        public bool Availability { get; set; }

        /// <summary>
        /// 取餐柜的单元格详情列表
        /// </summary>
        [JsonProperty("cell_info_list")]
        public List<FoodDispenserCellInfo> CellInfoList { get; set; }

        /// <summary>
        /// 取餐柜的唯一设备ID
        /// </summary>
        [JsonProperty("device_id")]
        public string DeviceId { get; set; }
    }
}
