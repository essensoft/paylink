using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceTransportVehicleownerCampaignPublishModel Data Structure.
    /// </summary>
    public class AlipayCommerceTransportVehicleownerCampaignPublishModel : AlipayObject
    {
        /// <summary>
        /// 0.优惠券（目前仅提供一种后续增加）。必选项，单选。
        /// </summary>
        [JsonPropertyName("activity_icon")]
        public string ActivityIcon { get; set; }

        /// <summary>
        /// 活动文案字符串，必填项，在加油小程序门店展位对用户展示
        /// </summary>
        [JsonPropertyName("activity_record")]
        public string ActivityRecord { get; set; }

        /// <summary>
        /// 活动链接URL地址字符串，必填项，需符合规范要求
        /// </summary>
        [JsonPropertyName("activity_url")]
        public string ActivityUrl { get; set; }

        /// <summary>
        /// 业务类型
        /// </summary>
        [JsonPropertyName("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// 活动截止时间(备注：除下架外其它场景类型必填)
        /// </summary>
        [JsonPropertyName("effective_end")]
        public string EffectiveEnd { get; set; }

        /// <summary>
        /// 活动生效开始时间(备注：除下架外其它场景类型必填)
        /// </summary>
        [JsonPropertyName("effective_start")]
        public string EffectiveStart { get; set; }

        /// <summary>
        /// 扩展参数
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 上架平台：0 代表支付宝APP端
        /// </summary>
        [JsonPropertyName("last_platform")]
        public string LastPlatform { get; set; }

        /// <summary>
        /// 上架门店id，逗号分隔开(备注：除上架外其它操作场景类型选填)
        /// </summary>
        [JsonPropertyName("last_store_id")]
        public string LastStoreId { get; set; }

        /// <summary>
        /// 外部订单号,商户端唯一
        /// </summary>
        [JsonPropertyName("out_biz_id")]
        public string OutBizId { get; set; }

        /// <summary>
        /// 展位优先级，整数，必填。同一门店多个活动时，优先级数值小优先展示
        /// </summary>
        [JsonPropertyName("priority_booth")]
        public string PriorityBooth { get; set; }
    }
}
