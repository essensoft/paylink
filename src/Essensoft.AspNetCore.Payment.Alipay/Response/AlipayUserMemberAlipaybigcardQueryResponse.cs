using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayUserMemberAlipaybigcardQueryResponse.
    /// </summary>
    public class AlipayUserMemberAlipaybigcardQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 支付宝大卡片展现信息（缓存类），缓存类是对实时性要求不高的透出内容。缓存类用于存在缓存中，在调用接口超时或者降级时取用。
        /// </summary>
        [JsonPropertyName("alipay_big_card_cache_data")]
        public BigCardData AlipayBigCardCacheData { get; set; }

        /// <summary>
        /// 支付宝大卡片展现信息（实时），展现层数据信息，结构详见具体复杂类型，返回给用户的卡片展现信息包括实时类和缓存类两部分，实时类是精确信息，直接用于前端展现
        /// </summary>
        [JsonPropertyName("alipay_big_card_real_time_data")]
        public BigCardData AlipayBigCardRealTimeData { get; set; }

        /// <summary>
        /// 可存入缓存的卡片展示信息
        /// </summary>
        [JsonPropertyName("backup_display_info")]
        public string BackupDisplayInfo { get; set; }

        /// <summary>
        /// 工具类或卡片类，single_tool或single_content
        /// </summary>
        [JsonPropertyName("backup_template_code")]
        public string BackupTemplateCode { get; set; }

        /// <summary>
        /// 植入在手淘的埋点信息
        /// </summary>
        [JsonPropertyName("backup_track_info")]
        public string BackupTrackInfo { get; set; }

        /// <summary>
        /// 按照淘宝约定的格式返回的卡片展示结果，json格式
        /// </summary>
        [JsonPropertyName("display_info")]
        public string DisplayInfo { get; set; }

        /// <summary>
        /// 扩展字段备用
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 结果码
        /// </summary>
        [JsonPropertyName("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// 结果描述
        /// </summary>
        [JsonPropertyName("result_desc")]
        public string ResultDesc { get; set; }

        /// <summary>
        /// 业务失败是否可重试
        /// </summary>
        [JsonPropertyName("retryable")]
        public string Retryable { get; set; }

        /// <summary>
        /// 是否业务处理成功
        /// </summary>
        [JsonPropertyName("success")]
        public bool Success { get; set; }

        /// <summary>
        /// 工具类或卡片类，single_tool或single_content
        /// </summary>
        [JsonPropertyName("template_code")]
        public string TemplateCode { get; set; }

        /// <summary>
        /// 植入在手淘的埋点信息
        /// </summary>
        [JsonPropertyName("track_info")]
        public string TrackInfo { get; set; }
    }
}
