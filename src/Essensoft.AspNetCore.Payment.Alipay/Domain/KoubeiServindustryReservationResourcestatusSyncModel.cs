using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiServindustryReservationResourcestatusSyncModel Data Structure.
    /// </summary>
    public class KoubeiServindustryReservationResourcestatusSyncModel : AlipayObject
    {
        /// <summary>
        /// 消息变更类型
        /// </summary>
        [JsonPropertyName("biz_type")]
        public List<string> BizType { get; set; }

        /// <summary>
        /// 周期库存时间，当周期库存变更时必填
        /// </summary>
        [JsonPropertyName("cycle_property_time")]
        public IsvCyclePropertyTimeModel CyclePropertyTime { get; set; }

        /// <summary>
        /// 资源状态变化的日期
        /// </summary>
        [JsonPropertyName("date")]
        public string Date { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        [JsonPropertyName("end_time")]
        public ReservationTimeUnit EndTime { get; set; }

        /// <summary>
        /// 预订所属的行业
        /// </summary>
        [JsonPropertyName("industry")]
        public string Industry { get; set; }

        /// <summary>
        /// 外部业务id，如ISV KTV包厢id
        /// </summary>
        [JsonPropertyName("out_biz_id")]
        public string OutBizId { get; set; }

        /// <summary>
        /// 口碑预订资源id
        /// </summary>
        [JsonPropertyName("resource_id")]
        public string ResourceId { get; set; }

        /// <summary>
        /// 口碑店铺id
        /// </summary>
        [JsonPropertyName("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        [JsonPropertyName("start_time")]
        public ReservationTimeUnit StartTime { get; set; }
    }
}
