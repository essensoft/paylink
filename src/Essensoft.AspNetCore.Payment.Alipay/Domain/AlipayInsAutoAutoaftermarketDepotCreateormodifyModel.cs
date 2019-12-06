using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayInsAutoAutoaftermarketDepotCreateormodifyModel Data Structure.
    /// </summary>
    public class AlipayInsAutoAutoaftermarketDepotCreateormodifyModel : AlipayObject
    {
        /// <summary>
        /// 操作类型:  ONLINE-上线，  OFFLINE-下线，  UPDATE-修改修理厂信息（如修改修理厂名称，修理厂某几天的库存）
        /// </summary>
        [JsonPropertyName("action_type")]
        public string ActionType { get; set; }

        /// <summary>
        /// 营业结束时间，格式:HH:MM
        /// </summary>
        [JsonPropertyName("business_end_time")]
        public string BusinessEndTime { get; set; }

        /// <summary>
        /// 开始营业时间，格式HH:MM
        /// </summary>
        [JsonPropertyName("business_start_time")]
        public string BusinessStartTime { get; set; }

        /// <summary>
        /// 需要更新库存的日期:  如果需要修改某几天的库存，该字段必传，若该字段不传，则默认修改所有的库存  格式:yyyy-MM-dd
        /// </summary>
        [JsonPropertyName("calendars")]
        public List<string> Calendars { get; set; }

        /// <summary>
        /// 修理厂支付宝账号，用于后续结算线上化
        /// </summary>
        [JsonPropertyName("depot_account")]
        public string DepotAccount { get; set; }

        /// <summary>
        /// 修理厂详细地址
        /// </summary>
        [JsonPropertyName("depot_address")]
        public string DepotAddress { get; set; }

        /// <summary>
        /// 服务商侧的修理厂id，需要唯一
        /// </summary>
        [JsonPropertyName("depot_id")]
        public string DepotId { get; set; }

        /// <summary>
        /// 修理厂名称
        /// </summary>
        [JsonPropertyName("depot_name")]
        public string DepotName { get; set; }

        /// <summary>
        /// 扩展信息，json格式
        /// </summary>
        [JsonPropertyName("extra")]
        public string Extra { get; set; }

        /// <summary>
        /// 修理厂联系方式
        /// </summary>
        [JsonPropertyName("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// 修理厂维修范围，json格式
        /// </summary>
        [JsonPropertyName("repair_scope")]
        public string RepairScope { get; set; }

        /// <summary>
        /// 修理厂每日可修数量
        /// </summary>
        [JsonPropertyName("threshold")]
        public long Threshold { get; set; }
    }
}
