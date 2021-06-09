using System.Text.Json.Serialization;

namespace Essensoft.Paylink.WeChatPay.V3.Domain
{
    /// <summary>
    /// 资金应用 - 分账 - 请求分账回退 - 请求JSON参数
    /// </summary>
    /// <remarks>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter8_1_3.shtml">分账 - 请求分账回退API</a> - 最新更新时间：2021.05.11</para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter8_1_3.shtml">分账(服务商) - 请求分账回退API</a> - 最新更新时间：2021.05.11</para>
    /// </remarks>
    public class WeChatPayProfitSharingReturnOrdersBodyModel : WeChatPayObject
    {
        /// <summary>
        /// 子商户号 
        /// </summary>
        /// <remarks>
        /// 微信支付分配的子商户号，即分账的出资商户号。
        /// <para>示例值：1900000109</para>
        /// </remarks>
        [JsonPropertyName("sub_mchid")]
        public string SubMchId { get; set; }

        /// <summary>
        /// 微信分账单号
        /// </summary>
        /// <remarks>
        /// 微信分账单号，微信系统返回的唯一标识。
        /// <para>示例值：3008450740201411110007820472</para>
        /// </remarks>
        [JsonPropertyName("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 商户分账单号
        /// </summary>
        /// <remarks>
        /// 商户系统内部的分账单号，在商户系统内部唯一，同一分账单号多次请求等同一次。 取值范围：[0-9a-zA-Z_*@-]
        /// <para>示例值：P20150806125346</para>
        /// </remarks>
        [JsonPropertyName("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 商户回退单号
        /// </summary>
        /// <remarks>
        /// 此回退单号是商户在自己后台生成的一个新的回退单号，在商户后台唯一
        /// <para>示例值：R20190516001</para>
        /// </remarks>
        [JsonPropertyName("out_return_no")]
        public string OutReturnNo { get; set; }

        /// <summary>
        /// 回退商户号
        /// </summary>
        /// <remarks>
        /// 分账回退的出资商户，只能对原分账请求中成功分给商户接收方进行回退
        /// <para>示例值：86693852</para>
        /// </remarks>
        [JsonPropertyName("return_mchid")]
        public string ReturnMchid { get; set; }

        /// <summary>
        /// 回退金额
        /// </summary>
        /// <remarks>
        /// 需要从分账接收方回退的金额，单位为分，只能为整数，不能超过原始分账单分出给该接收方的金额
        /// <para>示例值：10</para>
        /// </remarks>
        [JsonPropertyName("amount")]
        public int Amount { get; set; }

        /// <summary>
        /// 回退描述
        /// </summary>
        /// <remarks>
        /// 分账回退的原因描述
        /// <para>示例值：用户退款</para>
        /// </remarks>
        [JsonPropertyName("description")]
        public string Description { get; set; }
    }
}
