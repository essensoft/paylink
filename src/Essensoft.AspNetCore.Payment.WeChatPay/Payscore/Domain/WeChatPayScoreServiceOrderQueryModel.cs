using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.WeChatPay.Payscore.Domain
{
    /// <summary>
    ///  微信支付分 - 查询支付分订单API
    ///  <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter6_1_15.shtml">查询支付分订单API</a></para>
    /// </summary>
    public class WeChatPayScoreServiceOrderQueryModel : WeChatPayScoreModelBase
    {
        /// <summary>
        /// 商户订单号
        /// </summary>
        /// <remarks>
        /// 商户系统内部服务订单号（不是交易单号），要求此参数只能由数字、大小写字母_-|*组成，且在同一个商户号下唯一。
        /// 详见[商户订单号]。示例值：1234323JKHDFE1243252
        /// </remarks>
        [JsonPropertyName("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 回跳查询ID
        /// </summary>
        /// <remarks>
        /// 微信侧回跳到商户前端时用于查单的单据查询id。详见章节“小程序跳转接口，回跳商户接口”。
        /// 商户单号与回跳查询id必填其中一个.不允许都填写或都不填写。
        /// 示例值：15646546545165651651
        /// </remarks>
        [JsonPropertyName("query_id")]
        public string QueryId { get; set; }
    }
}
