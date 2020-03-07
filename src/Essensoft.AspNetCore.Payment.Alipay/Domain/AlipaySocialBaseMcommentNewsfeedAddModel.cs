using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipaySocialBaseMcommentNewsfeedAddModel Data Structure.
    /// </summary>
    public class AlipaySocialBaseMcommentNewsfeedAddModel : AlipayObject
    {
        /// <summary>
        /// 活动地点名称
        /// </summary>
        [JsonPropertyName("activity_address")]
        public string ActivityAddress { get; set; }

        /// <summary>
        /// 活动名称
        /// </summary>
        [JsonPropertyName("activity_name")]
        public string ActivityName { get; set; }

        /// <summary>
        /// 动态关联的现场id
        /// </summary>
        [JsonPropertyName("aid")]
        public string Aid { get; set; }

        /// <summary>
        /// 业务系统ID,必须保证唯一性  规则：uid@时间戳
        /// </summary>
        [JsonPropertyName("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 动态的文字内容
        /// </summary>
        [JsonPropertyName("content")]
        public string Content { get; set; }

        /// <summary>
        /// 红包信息
        /// </summary>
        [JsonPropertyName("gift_info")]
        public NewsfeedMediaGiftInfo GiftInfo { get; set; }

        /// <summary>
        /// 图片信息
        /// </summary>
        [JsonPropertyName("img_infos")]
        public List<NewsfeedMediaImg> ImgInfos { get; set; }

        /// <summary>
        /// 动态的标题信息
        /// </summary>
        [JsonPropertyName("label_info")]
        public NewsfeedLabelInfo LabelInfo { get; set; }

        /// <summary>
        /// 链接信息（link类型时必填）
        /// </summary>
        [JsonPropertyName("link_info")]
        public NewsfeedMediaLinkInfo LinkInfo { get; set; }

        /// <summary>
        /// 动态相关的地理位置（发给现场的动态必填）
        /// </summary>
        [JsonPropertyName("location_info")]
        public NewsfeedLocationInfo LocationInfo { get; set; }

        /// <summary>
        /// 地理位置名称
        /// </summary>
        [JsonPropertyName("location_name")]
        public string LocationName { get; set; }

        /// <summary>
        /// 地理位置跳转链接（当前支持https和alipay开头）
        /// </summary>
        [JsonPropertyName("location_scheme")]
        public string LocationScheme { get; set; }

        /// <summary>
        /// 场景码,生活圈默认LFC
        /// </summary>
        [JsonPropertyName("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 支持口碑评论等特殊类型需要的评分，不为空可显示星级评分  满分10分，每1分代表半颗星
        /// </summary>
        [JsonPropertyName("score")]
        public long Score { get; set; }

        /// <summary>
        /// 接口请求来源
        /// </summary>
        [JsonPropertyName("source")]
        public string Source { get; set; }

        /// <summary>
        /// 用于标识来源app的图标
        /// </summary>
        [JsonPropertyName("source_icon")]
        public string SourceIcon { get; set; }

        /// <summary>
        /// 用于标识来源APP的名称
        /// </summary>
        [JsonPropertyName("source_name")]
        public string SourceName { get; set; }

        /// <summary>
        /// 个人动态扩散范围：0只生活圈，  1只现场，2既有生活圈也有现场
        /// </summary>
        [JsonPropertyName("spread_range")]
        public long SpreadRange { get; set; }

        /// <summary>
        /// 动态的类型：text纯文本，  image图片，video视频，link链接  ，crossVideo横屏视频
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// video信息（video、crossVideo类型时必填）
        /// </summary>
        [JsonPropertyName("video_info")]
        public NewsfeedMediaVideoInfo VideoInfo { get; set; }

        /// <summary>
        /// 动态的可见性：0公开，1私密（仅本人可见）
        /// </summary>
        [JsonPropertyName("visible")]
        public long Visible { get; set; }

        /// <summary>
        /// 动态的可见范围  visible为0,1时，为空列表  visible为2时，表示可见的标签分组列表，  visible为3时，表示不可见的标签分组列表
        /// </summary>
        [JsonPropertyName("visible_range")]
        public List<string> VisibleRange { get; set; }

        /// <summary>
        /// 和谁在一起，用户列表
        /// </summary>
        [JsonPropertyName("with_me")]
        public List<NewsfeedWithMeInfo> WithMe { get; set; }
    }
}
