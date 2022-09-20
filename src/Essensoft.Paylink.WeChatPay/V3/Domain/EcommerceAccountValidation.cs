using System.Text.Json.Serialization;

namespace Essensoft.Paylink.WeChatPay.V3.Domain
{
    /// <summary>
    /// 汇款账户验证信息
    /// </summary>
    public class EcommerceAccountValidation : WeChatPayObject
    {
        /// <summary>
        /// 付款户名
        /// </summary>
        /// <remarks>
        /// 需商户使用该户名的账户进行汇款。
        /// 该字段需进行解密处理，解密方法详见敏感信息加解密说明。
        /// <para>示例值：rDdICA3ZYXshYqeOSslSjSMf+MhhC4oaujiISFzq3AE+as7mAEDJly+DgRuVs74msmKUH8pl+3oA==</para>
        /// </remarks>
        [JsonPropertyName("account_name")]
        public string AccountName { get; set; }

        /// <summary>
        /// 付款卡号
        /// </summary>
        /// <remarks>
        /// 结算账户为对私时会返回，商户需使用该付款卡号进行汇款。
        /// 该字段需进行解密处理，解密方法详见敏感信息加解密说明。
        /// <para>示例值：9nZYDEvBT4rDdICA3ZYXshYqeOSslSjSauAE+as7mAEDJly+DgRuVs74msmKUH8pl+3oA==</para>
        /// </remarks>
        [JsonPropertyName("account_no")]
        public string AccountNo { get; set; }

        /// <summary>
        /// 汇款金额
        /// </summary>
        /// <remarks>
        /// 需要汇款的金额(单位：分)。
        /// <para>示例值：124</para>
        /// </remarks>
        [JsonPropertyName("pay_amount")]
        public int PayAmount { get; set; }

        /// <summary>
        /// 收款卡号
        /// </summary>
        /// <remarks>
        /// 收款账户的卡号
        /// <para>示例值：7222223333322332</para>
        /// </remarks>
        [JsonPropertyName("destination_account_number")]
        public string DestinationAccountNumber { get; set; }

        /// <summary>
        /// 收款户名
        /// </summary>
        /// <remarks>
        /// 收款账户名
        /// <para>示例值：财付通支付科技有限公司</para>
        /// </remarks>
        [JsonPropertyName("destination_account_name")]
        public string DestinationAccountName { get; set; }

        /// <summary>
        /// 开户银行
        /// </summary>
        /// <remarks>
        /// 收款账户的开户银行名称。
        /// <para>示例值：招商银行股份有限公司深圳汉京中心支行</para>
        /// </remarks>
        [JsonPropertyName("destination_account_bank")]
        public string DestinationAccountBank { get; set; }

        /// <summary>
        /// 省市信息
        /// </summary>
        /// <remarks>
        /// 收款账户的省市。
        /// <para>示例值：深圳</para>
        /// </remarks>
        [JsonPropertyName("city")]
        public string City { get; set; }

        /// <summary>
        /// 备注信息
        /// </summary>
        /// <remarks>
        /// 商户汇款时，需要填写的备注信息。
        /// <para>示例值：入驻账户验证</para>
        /// </remarks>
        [JsonPropertyName("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 汇款截止时间
        /// </summary>
        /// <remarks>
        /// 请在此时间前完成汇款。
        /// <para>示例值：2018-12-10 17:09:01</para>
        /// </remarks>
        [JsonPropertyName("deadline")]
        public string Deadline { get; set; }
    }
}
