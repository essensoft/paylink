using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMarketingToolPromocommoptOpeneventSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingToolPromocommoptOpeneventSendModel : AlipayObject
    {
        /// <summary>
        /// 外部事件发生时间，必须是（yyyy-MM-dd HH:mm:ss）格式
        /// </summary>
        [JsonProperty("biz_time")]
        public string BizTime { get; set; }

        /// <summary>
        /// 唯一事件编码，用来区分不同的事件类型。事件类型是给定的，当前事件类型只有PARKING（停车场事件）一种
        /// </summary>
        [JsonProperty("event_code")]
        public string EventCode { get; set; }

        /// <summary>
        /// 每一个事件码对应的扩展信息，是Map<String,String>的类型JSON格式化的字符串。  事件类型为PARKING的KEY如下：  parking_lot_id：停车场ID（必填）  action： IN（进场）、OUT 出场（必填）  content_id：内容ID（必填）
        /// </summary>
        [JsonProperty("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 事件发生的纬度信息。经度信息和纬度信息必须同时存在，要么都填，要么都不填。
        /// </summary>
        [JsonProperty("latitude")]
        public long Latitude { get; set; }

        /// <summary>
        /// 事件发生的经度信息。经度信息和纬度信息必须同时存在，要么都填，要么都不填。
        /// </summary>
        [JsonProperty("longitude")]
        public long Longitude { get; set; }

        /// <summary>
        /// 事件唯一编号，用来做幂等控制。每一次用户在商户所发生的事件，out_biz_no都不能一样。比如用户每次进入停车场、离开停车场的out_biz_no不能一样。
        /// </summary>
        [JsonProperty("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 支付宝用户ID
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}
