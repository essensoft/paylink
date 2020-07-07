using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.WeChatPay.V3.Domain
{
    /// <summary>
    /// 合单下单子单信息
    /// </summary>       
    public class CombineSubOrderInfo : WeChatPayObject
    {
        /// <summary>
        /// 子单商户号
        /// 子单发起方商户号，必须与发起方appid有绑定关系。
        /// 示例值：1900000109
        /// </summary>
        [JsonPropertyName("mchid")]
        public string MchId { get; set; }

        /// <summary>
        /// 附加数据
        /// 附加数据，在查询API和支付通知中原样返回，可作为自定义参数使用。
        /// 示例值：深圳分店
        /// </summary>
        [JsonPropertyName("attach")]
        public string Attach { get; set; }

        /// <summary>
        /// 订单金额
        /// 订单金额信息
        /// </summary>
        [JsonPropertyName("amount")]
        public CombineAmount Amount { get; set; }

        /// <summary>
        /// 子单商户订单号
        /// 商户系统内部订单号，要求32个字符内，只能是数字、大小写字母_-|*@ ，且在同一个商户号下唯一。
        /// 特殊规则：最小字符长度为6
        /// 示例值：20150806125346
        /// </summary>
        [JsonPropertyName("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 二级商户号
        /// 二级商户商户号，由微信支付生成并下发。
        /// 注意：仅适用于电商平台 服务商
        /// 示例值：1900000109
        /// </summary>
        [JsonPropertyName("sub_mchid")]
        public string SubMchId { get; set; }

        /// <summary>
        /// 商品描述
        /// 商品简单描述。需传入应用市场上的APP名字-实际商品名称，例如：天天爱消除-游戏充值。
        /// 示例值：腾讯充值中心-QQ会员充值
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// 结算信息
        /// 结算信息
        /// </summary>
        [JsonPropertyName("settle_info")]
        public SettleInfo SettleInfo { get; set; }
    }
}
