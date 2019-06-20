using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ContentInfoModel Data Structure.
    /// </summary>
    [Serializable]
    public class ContentInfoModel : AlipayObject
    {
        /// <summary>
        /// 展台
        /// </summary>
        [JsonProperty("booth")]
        public string Booth { get; set; }

        /// <summary>
        /// 内容id 加密串
        /// </summary>
        [JsonProperty("content_id_str")]
        public string ContentIdStr { get; set; }

        /// <summary>
        /// 扩展信息列表
        /// </summary>
        [JsonProperty("ext_info")]
        public ContentExtInfoModel ExtInfo { get; set; }

        /// <summary>
        /// 内容跳转地址
        /// </summary>
        [JsonProperty("link_url")]
        public string LinkUrl { get; set; }

        /// <summary>
        /// 内容对应的图片 logo
        /// </summary>
        [JsonProperty("logo")]
        public string Logo { get; set; }

        /// <summary>
        /// 权益领取状态:  noReceive ( 未领取 )   received ( 已领取 )  todayEnded ( 暂时缺货 )   ended ( 已抢光 )   stoped ( 已结束)  notBegin ( 未开始 )
        /// </summary>
        [JsonProperty("receive_status")]
        public string ReceiveStatus { get; set; }

        /// <summary>
        /// 场景
        /// </summary>
        [JsonProperty("scene")]
        public string Scene { get; set; }

        /// <summary>
        /// 内容副标题
        /// </summary>
        [JsonProperty("sub_title")]
        public string SubTitle { get; set; }

        /// <summary>
        /// 内容主标题
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// 阵地
        /// </summary>
        [JsonProperty("touch_point")]
        public string TouchPoint { get; set; }
    }
}
