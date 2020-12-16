using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ZolozAuthenticationSmilefaceSendmeSendModel Data Structure.
    /// </summary>
    public class ZolozAuthenticationSmilefaceSendmeSendModel : AlipayObject
    {
        /// <summary>
        /// 业务类型
        /// </summary>
        [JsonPropertyName("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 活动ID，用于发送优惠券
        /// </summary>
        [JsonPropertyName("camp_id")]
        public string CampId { get; set; }

        /// <summary>
        /// 扩展字段
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 可通过线下刷脸获取
        /// </summary>
        [JsonPropertyName("ftoken")]
        public string Ftoken { get; set; }

        /// <summary>
        /// 推送消息到用户钱包中，并打开该小程序
        /// </summary>
        [JsonPropertyName("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 跳转到小程序内的页面
        /// </summary>
        [JsonPropertyName("path")]
        public string Path { get; set; }
    }
}
