using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayDataDataserviceDmpserviceCreateModel Data Structure.
    /// </summary>
    public class AlipayDataDataserviceDmpserviceCreateModel : AlipayObject
    {
        /// <summary>
        /// 转化id event_type = 1时必填
        /// </summary>
        [JsonPropertyName("conversion_id")]
        public long ConversionId { get; set; }

        /// <summary>
        /// 转化时间 event_type = 1时必填
        /// </summary>
        [JsonPropertyName("conversion_time")]
        public string ConversionTime { get; set; }

        /// <summary>
        /// 转化类型，0-表单提交，1-客户资讯搜集，2-商品加购物车，3-订单提交，4-我要投保，5-保险交易笔数，6-保险交易金额，7-基金交易笔数，8-基金交易金额 event_type = 1时必填
        /// </summary>
        [JsonPropertyName("conversion_type")]
        public string ConversionType { get; set; }

        /// <summary>
        /// 设备id  device_id和user_id不能同时为空
        /// </summary>
        [JsonPropertyName("device_id")]
        public string DeviceId { get; set; }

        /// <summary>
        /// 设备类型, 0:imei, 1:idfa, 2:imei_md5, 3:imei_sha256, 4:idfa_md5, 5:idfa_sha256  设备类型和device_id是同时存在 device_id和user_id不能同时为空
        /// </summary>
        [JsonPropertyName("device_type")]
        public long DeviceType { get; set; }

        /// <summary>
        /// 0-落地页到达事件 1-转化事件
        /// </summary>
        [JsonPropertyName("event_type")]
        public long EventType { get; set; }

        /// <summary>
        /// 扩展字段，json格式存储，列表里面包含kv
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 1:转化, 0:非转化 event_type = 1时必填
        /// </summary>
        [JsonPropertyName("is_conversion")]
        public long IsConversion { get; set; }

        /// <summary>
        /// 请求id
        /// </summary>
        [JsonPropertyName("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 数据来源，如来源数立，可以SL
        /// </summary>
        [JsonPropertyName("source")]
        public string Source { get; set; }

        /// <summary>
        /// 当前访问的url  encode后的字符串
        /// </summary>
        [JsonPropertyName("track_url")]
        public string TrackUrl { get; set; }

        /// <summary>
        /// 用户id  设备id和用户id不能同时为空
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
