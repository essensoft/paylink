using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ContentInfoModel Data Structure.
    /// </summary>
    public class ContentInfoModel : AlipayObject
    {
        /// <summary>
        /// 展台
        /// </summary>
        [JsonPropertyName("booth")]
        public string Booth { get; set; }

        /// <summary>
        /// 内容id 加密串
        /// </summary>
        [JsonPropertyName("content_id_str")]
        public string ContentIdStr { get; set; }

        /// <summary>
        /// 扩展信息列表
        /// </summary>
        [JsonPropertyName("ext_info")]
        public ContentExtInfoModel ExtInfo { get; set; }

        /// <summary>
        /// 内容跳转地址
        /// </summary>
        [JsonPropertyName("link_url")]
        public string LinkUrl { get; set; }

        /// <summary>
        /// 内容对应的图片 logo
        /// </summary>
        [JsonPropertyName("logo")]
        public string Logo { get; set; }

        /// <summary>
        /// 权益领取状态:  noReceive ( 未领取 )   received ( 已领取 )  todayEnded ( 暂时缺货 )   ended ( 已抢光 )   stoped ( 已结束)  notBegin ( 未开始 )
        /// </summary>
        [JsonPropertyName("receive_status")]
        public string ReceiveStatus { get; set; }

        /// <summary>
        /// 场景
        /// </summary>
        [JsonPropertyName("scene")]
        public string Scene { get; set; }

        /// <summary>
        /// 内容副标题
        /// </summary>
        [JsonPropertyName("sub_title")]
        public string SubTitle { get; set; }

        /// <summary>
        /// 内容主标题
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }

        /// <summary>
        /// 阵地
        /// </summary>
        [JsonPropertyName("touch_point")]
        public string TouchPoint { get; set; }
    }
}
