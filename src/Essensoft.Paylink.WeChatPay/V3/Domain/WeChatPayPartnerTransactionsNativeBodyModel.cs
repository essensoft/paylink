using System.Text.Json.Serialization;

namespace Essensoft.Paylink.WeChatPay.V3.Domain
{
    /// <summary>
    /// 基础支付(服务商) - Native支付 - 统一下单 - 请求JSON参数
    /// </summary>
    /// <remarks>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter4_4_1.shtml">Native支付 - 统一下单API</a> - 最新更新时间：2020.05.26</para>
    /// </remarks>
    public class WeChatPayPartnerTransactionsNativeBodyModel : WeChatPayObject
    {
        /// <summary>
        /// 服务商应用ID
        /// </summary>
        /// <remarks>
        /// 服务商申请的公众号或移动应用appid。
        /// <para>示例值：wx8888888888888888</para>
        /// </remarks>
        [JsonPropertyName("sp_appid")]
        public string SpAppId { get; set; }

        /// <summary>
        /// 服务商户号
        /// </summary>
        /// <remarks>
        /// 服务商户号，由微信支付生成并下发
        /// <para>示例值：1230000109</para>
        /// </remarks>
        [JsonPropertyName("sp_mchid")]
        public string SpMchId { get; set; }

        /// <summary>
        /// 子商户公众号ID
        /// </summary>
        /// <remarks>
        /// 子商户申请的公众号或移动应用appid。
        /// <para>示例值：wxd678efh567hg6999</para>
        /// </remarks>
        [JsonPropertyName("sub_appid")]
        public string SubAppId { get; set; }

        /// <summary>
        /// 子商户号
        /// </summary>
        /// <remarks>
        /// 子商户的商户号，有微信支付生成并下发。
        /// <para>示例值：1900000109</para>
        /// </remarks>
        [JsonPropertyName("sub_mchid")]
        public string SubMchId { get; set; }

        /// <summary>
        /// 商品描述
        /// </summary>
        /// <remarks>
        /// 商品描述
        /// <para>示例值：Image形象店-深圳腾大-QQ公仔</para>
        /// </remarks>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// 商户订单号
        /// </summary>
        /// <remarks>
        /// 商户系统内部订单号，只能是数字、大小写字母_-*且在同一个商户号下唯一，详见【商户订单号】。
        /// 特殊规则：最小字符长度为6
        /// <para>示例值：1217752501201407033233368018</para>
        /// </remarks>
        [JsonPropertyName("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 交易结束时间
        /// </summary>
        /// <remarks>
        /// 订单失效时间，遵循rfc3339标准格式，格式为YYYY-MM-DDTHH:mm:ss+TIMEZONE，YYYY-MM-DD表示年月日，T出现在字符串中，表示time元素的开头，HH:mm:ss表示时分秒，TIMEZONE表示时区（+08:00表示东八区时间，领先UTC 8小时，即北京时间）。例如：2015-05-20T13:29:35+08:00表示，北京时间2015年5月20日 13点29分35秒。
        /// <para>示例值：2018-06-08T10:34:56+08:00</para>
        /// </remarks>
        [JsonPropertyName("time_expire")]
        public string TimeExpire { get; set; }

        /// <summary>
        /// 附加数据
        /// </summary>
        /// <remarks>
        /// 附加数据，在查询API和支付通知中原样返回，可作为自定义参数使用
        /// <para>示例值：自定义数据</para>
        /// </remarks>
        [JsonPropertyName("attach")]
        public string Attach { get; set; }

        /// <summary>
        /// 通知地址
        /// </summary>
        /// <remarks>
        /// 通知URL必须为直接可访问的URL，不允许携带查询串。
        /// 格式：URL
        /// <para>示例值：https://www.weixin.qq.com/wxpay/pay.php</para>
        /// </remarks>
        [JsonPropertyName("notify_url")]
        public string NotifyUrl { get; set; }

        /// <summary>
        /// 订单优惠标记
        /// </summary>
        /// <remarks>
        /// 订单优惠标记
        /// <para>示例值：WXG</para>
        /// </remarks>
        [JsonPropertyName("goods_tag")]
        public string GoodsTag { get; set; }

        /// <summary>
        /// 结算信息
        /// </summary>
        /// <remarks>
        /// 结算信息
        /// </remarks>
        [JsonPropertyName("settle_info")]
        public SettleInfo SettleInfo { get; set; }

        /// <summary>
        /// 订单金额
        /// </summary>
        /// <remarks>
        /// 订单金额信息
        /// </remarks>
        [JsonPropertyName("amount")]
        public Amount Amount { get; set; }

        /// <summary>
        /// 优惠功能
        /// </summary>
        /// <remarks>
        /// 优惠功能
        /// </remarks>
        [JsonPropertyName("detail")]
        public Detail Detail { get; set; }

        /// <summary>
        /// 场景信息
        /// </summary>
        /// <remarks>
        /// 支付场景描述
        /// </remarks>
        [JsonPropertyName("scene_info")]
        public SceneInfo SceneInfo { get; set; }
    }
}
