using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMiniCardData Data Structure.
    /// </summary>
    public class AlipayMiniCardData : AlipayObject
    {
        /// <summary>
        /// 行动点链接，用户点击卡片的button时跳转到支付宝相应页面的链接地址
        /// </summary>
        [JsonPropertyName("action_link")]
        public string ActionLink { get; set; }

        /// <summary>
        /// 行动点文案，在卡片的button处展现
        /// </summary>
        [JsonPropertyName("action_text")]
        public string ActionText { get; set; }

        /// <summary>
        /// 应用英文名，固定值，用于手淘识别卡片所属类型为支付宝卡片
        /// </summary>
        [JsonPropertyName("app_name")]
        public string AppName { get; set; }

        /// <summary>
        /// 业务码，拼音或者数字，用于我淘搜集相关卡片的展现信息，便于分析各个卡片的点击率等数据情况
        /// </summary>
        [JsonPropertyName("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// 卡片类型，数字表示相应的不同卡片类型，包括1.提醒类（暂不支持） 2.玩法权益类 3.内容类（暂不支持） 4.商品类（暂不支持） 5.工具类，数字对应手淘约定的几种卡片类型
        /// </summary>
        [JsonPropertyName("card_type")]
        public long CardType { get; set; }

        /// <summary>
        /// 权益图链接，权益类卡片的权益图片，图片链接由运营进行配置
        /// </summary>
        [JsonPropertyName("coupon_pic")]
        public string CouponPic { get; set; }

        /// <summary>
        /// 支付宝卡片标题文字内容，标题组合起来的文案为我的支付宝：XXXX积分，目前固定展现蚂蚁会员的用户积分
        /// </summary>
        [JsonPropertyName("edit_text")]
        public string EditText { get; set; }

        /// <summary>
        /// 图文卡片中的图片链接（图片卡片文字用subText表示）
        /// </summary>
        [JsonPropertyName("item_pic")]
        public string ItemPic { get; set; }

        /// <summary>
        /// 主文本，工具类卡片展示的主文本文案
        /// </summary>
        [JsonPropertyName("main_text")]
        public string MainText { get; set; }

        /// <summary>
        /// 子文本，工具类卡片展示的子文本文案
        /// </summary>
        [JsonPropertyName("sub_text")]
        public string SubText { get; set; }
    }
}
