using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiCateringPosShiftQueryResponse.
    /// </summary>
    public class KoubeiCateringPosShiftQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 班次信息列表
        /// </summary>
        [JsonPropertyName("shop_pos_schedules")]
        public List<ShopPosSchedule> ShopPosSchedules { get; set; }
    }
}
