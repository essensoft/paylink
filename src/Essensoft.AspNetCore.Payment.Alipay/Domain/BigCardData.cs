using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// BigCardData Data Structure.
    /// </summary>
    public class BigCardData : AlipayObject
    {
        /// <summary>
        /// 主文本行动点文案，在卡片的button处展现
        /// </summary>
        [JsonPropertyName("action_text")]
        public string ActionText { get; set; }

        /// <summary>
        /// 业务码，拼音或者数字，用于我淘搜集相关卡片的展现信息，便于分析各个卡片的点击率等数据情况
        /// </summary>
        [JsonPropertyName("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// 主文本信息文案，如XXXX元，XXXX积分
        /// </summary>
        [JsonPropertyName("biz_data")]
        public string BizData { get; set; }

        /// <summary>
        /// 主文本副文案，在主文本的下方作为补充说明
        /// </summary>
        [JsonPropertyName("biz_title")]
        public string BizTitle { get; set; }

        /// <summary>
        /// 主文本字体颜色（如12545元）
        /// </summary>
        [JsonPropertyName("color")]
        public string Color { get; set; }

        /// <summary>
        /// 卡片的图链接， 1 图 400x400 (3x)， toolType 2 图 450x249 (3x) 或 300x166 (2x)，图片体积要求 50k 以内
        /// </summary>
        [JsonPropertyName("image_url")]
        public string ImageUrl { get; set; }

        /// <summary>
        /// 左侧行动点图片链接，对应leftAction里面的imageUrl字段
        /// </summary>
        [JsonPropertyName("left_image_url")]
        public string LeftImageUrl { get; set; }

        /// <summary>
        /// 左侧行动点链接，对应leftAction的targetUrl字段
        /// </summary>
        [JsonPropertyName("left_target_url")]
        public string LeftTargetUrl { get; set; }

        /// <summary>
        /// 左侧行动点文案，对应leftAction里面的title字段
        /// </summary>
        [JsonPropertyName("left_title")]
        public string LeftTitle { get; set; }

        /// <summary>
        /// 右侧行动点图片链接，对应rightAction里面的imageUrl字段
        /// </summary>
        [JsonPropertyName("right_image_url")]
        public string RightImageUrl { get; set; }

        /// <summary>
        /// 右侧行动点链接，对应rightAction的targetUrl字段
        /// </summary>
        [JsonPropertyName("right_target_url")]
        public string RightTargetUrl { get; set; }

        /// <summary>
        /// 右侧行动点文案，对应rightAction里面的title字段
        /// </summary>
        [JsonPropertyName("right_title")]
        public string RightTitle { get; set; }

        /// <summary>
        /// 支付宝卡片副标题文字内容
        /// </summary>
        [JsonPropertyName("sub_title")]
        public string SubTitle { get; set; }

        /// <summary>
        /// 主文本行动点跳转链接
        /// </summary>
        [JsonPropertyName("target_url")]
        public string TargetUrl { get; set; }

        /// <summary>
        /// 卡片类型，目前只会传1或2，标识工具类的类型1和类型2
        /// </summary>
        [JsonPropertyName("tool_type")]
        public long ToolType { get; set; }
    }
}
