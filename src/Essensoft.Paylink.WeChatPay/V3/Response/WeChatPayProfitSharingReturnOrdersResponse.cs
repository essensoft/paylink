using System.Text.Json.Serialization;

namespace Essensoft.Paylink.WeChatPay.V3.Response
{
    /// <summary>
    /// 资金应用 - 分账 - 请求分账回退 - 返回参数
    /// </summary>
    /// <remarks>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter8_1_3.shtml">分账 - 请求分账回退API</a> - 最新更新时间：2021.05.11</para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter8_1_3.shtml">分账(服务商) - 请求分账回退API</a> - 最新更新时间：2021.05.11</para>
    /// </remarks>
    public class WeChatPayProfitSharingReturnOrdersResponse : WeChatPayResponse
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
        /// 微信分账单号，微信系统返回的唯一标识
        /// <para>示例值：3008450740201411110007820472</para>
        /// </remarks>
        [JsonPropertyName("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 商户分账单号
        /// </summary>
        /// <remarks>
        /// 服务商系统内部的分账单号，在服务商系统内部唯一，同一分账单号多次请求等同一次。只能是数字、大小写字母_-|*@
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
        /// 微信回退单号
        /// </summary>
        /// <remarks>
        /// 微信分账回退单号，微信系统返回的唯一标识
        /// <para>示例值：3008450740201411110007820472</para>
        /// </remarks>
        [JsonPropertyName("return_id")]
        public string ReturnId { get; set; }

        /// <summary>
        /// 回退商户号
        /// </summary>
        /// <remarks>
        /// 只能对原分账请求中成功分给商户接收方进行回退
        /// <para>示例值：86693852</para>
        /// </remarks>
        [JsonPropertyName("return_mchid")]
        public string ReturnMchId { get; set; }

        /// <summary>
        /// 回退金额
        /// </summary>
        /// <remarks>
        /// 需要从分账接收方回退的金额，单位为分，只能为整数
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

        /// <summary>
        /// 回退结果
        /// </summary>
        /// <remarks>
        /// 如果请求返回为处理中，则商户可以通过调用回退结果查询接口获取请求的最终处理结果。如果查询到回退结果在处理中，请勿变更商户回退单号，使用相同的参数再次发起分账回退，否则会出现资金风险。在处理中状态的回退单如果5天没有成功，会因为超时被设置为已失败。
        /// 枚举值：
        /// PROCESSING：处理中
        /// SUCCESS：已成功
        /// FAILED：已失败
        /// <para>示例值: SUCCESS</para>
        /// </remarks>
        [JsonPropertyName("result")]
        public string Result { get; set; }

        /// <summary>
        /// 失败原因
        /// </summary>
        /// <remarks>
        /// 失败原因。包含以下枚举值：
        /// ACCOUNT_ABNORMAL : 分账接收方账户异常
        /// TIME_OUT_CLOSED : 超时关单
        /// PAYER_ACCOUNT_ABNORMAL：原分账分出方账户异常
        /// <para>示例值：TIME_OUT_CLOSED</para>
        /// </remarks>
        [JsonPropertyName("fail_reason")]
        public string FailReason { get; set; }

        /// <summary>
        /// 分账创建时间
        /// </summary>
        /// <remarks>
        /// 分账回退创建时间，遵循rfc3339标准格式，格式为YYYY-MM-DDTHH:mm:ss.sss+TIMEZONE，YYYY-MM-DD表示年月日，T出现在字符串中，表示time元素的开头，HH:mm:ss.sss表示时分秒毫秒，TIMEZONE表示时区（+08:00表示东八区时间，领先UTC 8小时，即北京时间）。例如：2015-05-20T13:29:35.120+08:00表示，北京时间2015年5月20日 13点29分35秒。
        /// <para>示例值：2015-05-20T13:29:35.120+08:00</para>
        /// </remarks>
        [JsonPropertyName("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 完成时间
        /// </summary>
        /// <remarks>
        /// 分账回退完成时间，遵循rfc3339标准格式，格式为YYYY-MM-DDTHH:mm:ss.sss+TIMEZONE，YYYY-MM-DD表示年月日，T出现在字符串中，表示time元素的开头，HH:mm:ss.sss表示时分秒毫秒，TIMEZONE表示时区（+08:00表示东八区时间，领先UTC 8小时，即北京时间）。例如：2015-05-20T13:29:35.120+08:00表示，北京时间2015年5月20日 13点29分35秒。
        /// <para>示例值：2015-05-20T13:29:35.120+08:00</para>
        /// </remarks>
        [JsonPropertyName("finish_time")]
        public string FinishTime { get; set; }
    }
}
