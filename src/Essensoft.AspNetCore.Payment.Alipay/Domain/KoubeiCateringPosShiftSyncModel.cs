using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiCateringPosShiftSyncModel Data Structure.
    /// </summary>
    public class KoubeiCateringPosShiftSyncModel : AlipayObject
    {
        /// <summary>
        /// 班次信息
        /// </summary>
        [JsonPropertyName("schedules")]
        public List<ShopPosSchedule> Schedules { get; set; }

        /// <summary>
        /// 门店ID
        /// </summary>
        [JsonPropertyName("shop_id")]
        public string ShopId { get; set; }
    }
}
