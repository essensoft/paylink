using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiCateringPosShiftSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringPosShiftSyncModel : AlipayObject
    {
        /// <summary>
        /// 班次信息
        /// </summary>
        [JsonProperty("schedules")]
        public List<ShopPosSchedule> Schedules { get; set; }

        /// <summary>
        /// 门店ID
        /// </summary>
        [JsonProperty("shop_id")]
        public string ShopId { get; set; }
    }
}
