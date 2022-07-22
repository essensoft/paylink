using System.Text.Json.Serialization;

namespace Essensoft.Paylink.WeChatPay.V3.Domain
{
    /// <summary>
    /// 分账接收方
    /// </summary>
    public class ReceiverResponse : WeChatPayObject
    {
        /// <summary>
        /// 分账金额
        /// </summary>
        /// <remarks>
        /// 分账金额，单位为分，只能为整数，不能超过原订单支付金额及最大分账比例金额
        /// <para>示例值: 100</para>
        /// </remarks>
        [JsonPropertyName("amount")]
        public int Amount { get; set; }

        /// <summary>
        /// 分账描述
        /// </summary>
        /// <remarks>
        /// 分账的原因描述，分账账单中需要体现
        /// <para>示例值: 分给商户1900000110</para>
        /// </remarks>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// 分账接收方类型
        /// </summary>
        /// <remarks>
        /// 1、MERCHANT_ID：商户号
        /// 2、PERSONAL_OPENID：个人openid（由父商户APPID转换得到）
        /// 3、PERSONAL_SUB_OPENID: 个人sub_openid（由子商户APPID转换得到）
        /// <para>示例值: MERCHANT_ID</para>
        /// </remarks>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// 分账接收方帐号
        /// </summary>
        /// <remarks>
        /// 1、分账接收方类型为MERCHANT_ID时，分账接收方账号为商户号
        /// 2、分账接收方类型为PERSONAL_OPENID时，分账接收方账号为个人openid
        /// 3、分账接收方类型为
        /// PERSONAL_SUB_OPENID时，分账接收方账号为个人sub_openid
        /// <para>示例值: 1900000109</para>
        /// </remarks>
        [JsonPropertyName("account")]
        public string Account { get; set; }

        /// <summary>
        /// 分账结果
        /// </summary>
        /// <remarks>
        /// 枚举值：
        /// 1、PENDING：待分账
        /// 2、SUCCESS：分账成功
        /// 3、CLOSED：已关闭
        /// <para>示例值: SUCCESS</para>
        /// </remarks>
        [JsonPropertyName("result")]
        public string Result { get; set; }

        /// <summary>
        /// 分账失败原因
        /// </summary>
        /// <remarks>
        /// 分账失败原因，当分账结果result为CLOSED（已关闭）时，返回该字段
        /// 枚举值：
        /// 1、ACCOUNT_ABNORMAL：分账接收账户异常
        /// 2、NO_RELATION：分账关系已解除
        /// 3、RECEIVER_HIGH_RISK：高风险接收方
        /// 4、RECEIVER_REAL_NAME_NOT_VERIFIED：接收方未实名
        /// 5、NO_AUTH：分账权限已解除
        /// 6、RECEIVER_RECEIPT_LIMIT：接收方已达收款限额
        /// 7、PAYER_ACCOUNT_ABNORMAL：分出方账户异常
        /// 8、INVALID_REQUEST: 描述参数设置失败
        /// <para>示例值：ACCOUNT_ABNORMAL</para>
        /// </remarks>
        [JsonPropertyName("fail_reason")]
        public string FailReason { get; set; }

        /// <summary>
        /// 分账创建时间
        /// </summary>
        /// <remarks>
        /// 分账创建时间，遵循rfc3339标准格式，格式为YYYY-MM-DDTHH:mm:ss.sss+TIMEZONE，YYYY-MM-DD表示年月日，T出现在字符串中，表示time元素的开头，HH:mm:ss.sss表示时分秒毫秒，TIMEZONE表示时区（+08:00表示东八区时间，领先UTC 8小时，即北京时间）。例如：2015-05-20T13:29:35.120+08:00表示，北京时间2015年5月20日 13点29分35秒。
        /// <para>示例值：2015-05-20T13:29:35.120+08:00</para>
        /// </remarks>
        [JsonPropertyName("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 分账完成时间
        /// </summary>
        /// <remarks>
        /// 分账完成时间，遵循rfc3339标准格式，格式为YYYY-MM-DDTHH:mm:ss.sss+TIMEZONE，YYYY-MM-DD表示年月日，T出现在字符串中，表示time元素的开头，HH:mm:ss.sss表示时分秒毫秒，TIMEZONE表示时区（+08:00表示东八区时间，领先UTC 8小时，即北京时间）。例如：2015-05-20T13:29:35.120+08:00表示，北京时间2015年5月20日 13点29分35秒。
        /// <para>示例值：2015-05-20T13:29:35.120+08:00</para>
        /// </remarks>
        [JsonPropertyName("finish_time")]
        public string FinishTime { get; set; }

        /// <summary>
        /// 分账明细单号
        /// </summary>
        /// <remarks>
        /// 微信分账明细单号，每笔分账业务执行的明细单号，可与资金账单对账使用
        /// <para>示例值：36011111111111111111111</para>
        /// </remarks>
        [JsonPropertyName("detail_id")]
        public string DetailId { get; set; }
    }
}
