using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayInsAutoAutoaftermarketInserviceorderNotifyModel Data Structure.
    /// </summary>
    public class AlipayInsAutoAutoaftermarketInserviceorderNotifyModel : AlipayObject
    {
        /// <summary>
        /// 蚂蚁服务申请单号
        /// </summary>
        [JsonPropertyName("ant_ser_apply_no")]
        public string AntSerApplyNo { get; set; }

        /// <summary>
        /// 业务状态变更时间。 格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonPropertyName("event_time")]
        public string EventTime { get; set; }

        /// <summary>
        /// 扩展信息，json格式
        /// </summary>
        [JsonPropertyName("extra")]
        public string Extra { get; set; }

        /// <summary>
        /// 机构服务申请单号
        /// </summary>
        [JsonPropertyName("inst_ser_apply_no")]
        public string InstSerApplyNo { get; set; }

        /// <summary>
        /// 如果是确认维修项，则该字段必传
        /// </summary>
        [JsonPropertyName("repair_item")]
        public List<RepairItem> RepairItem { get; set; }

        /// <summary>
        /// ARRIVED_DEPOT("ARRIVED_DEPOT", "已到店"), NOT_ARRIVE_DEPOT("NOT_ARRIVE_DEPOT", "未到店"), REPAIR_ABANDON("REPAIR_ABANDON", "已放弃修理"), REPAIRING("REPAIRING", "修理中"), REPAIR_COMPLETED("REPAIR_COMPLETED", "维修完成"), DEPOT_CONFIRMED_REPAIR_ITEM("DEPOT_CONFIRMED_REPAIR_ITEM", "修理厂已确认维修项");
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
