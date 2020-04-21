using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// SceneProdPaymentAccountInfo Data Structure.
    /// </summary>
    public class SceneProdPaymentAccountInfo : AlipayObject
    {
        /// <summary>
        /// 账号外标，如支付宝登录号,网商银行卡卡号
        /// </summary>
        [JsonPropertyName("account_ext_no")]
        public string AccountExtNo { get; set; }

        /// <summary>
        /// 金融机构码
        /// </summary>
        [JsonPropertyName("account_fip_code")]
        public string AccountFipCode { get; set; }

        /// <summary>
        /// 金融机构名称
        /// </summary>
        [JsonPropertyName("account_fip_name")]
        public string AccountFipName { get; set; }

        /// <summary>
        /// 资金账号,支付宝2088开头或银行卡号
        /// </summary>
        [JsonPropertyName("account_no")]
        public string AccountNo { get; set; }

        /// <summary>
        /// 账号分类, ALIPAY:支付宝 , CURRENT: 网商银行
        /// </summary>
        [JsonPropertyName("account_type")]
        public string AccountType { get; set; }

        /// <summary>
        /// 资金操作金额，单位分
        /// </summary>
        [JsonPropertyName("amt")]
        public string Amt { get; set; }

        /// <summary>
        /// 账户对公对私类型,P-对私，B-对公
        /// </summary>
        [JsonPropertyName("bank_card_category")]
        public string BankCardCategory { get; set; }

        /// <summary>
        /// 持卡人姓名
        /// </summary>
        [JsonPropertyName("card_holder_name")]
        public string CardHolderName { get; set; }

        /// <summary>
        /// 资产工具为外部银行卡时可填，且为外部贷记卡模式下必须填写为CC，其余无需填写。
        /// </summary>
        [JsonPropertyName("ext_card_type")]
        public string ExtCardType { get; set; }

        /// <summary>
        /// 扩展信息，map格式
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 开户行联行号，机构可以通过联行号查询网商查询获取。
        /// </summary>
        [JsonPropertyName("inst_out_code")]
        public string InstOutCode { get; set; }

        /// <summary>
        /// 网商参与者id
        /// </summary>
        [JsonPropertyName("ip_id")]
        public string IpId { get; set; }

        /// <summary>
        /// 网商银行角色id
        /// </summary>
        [JsonPropertyName("ip_role_id")]
        public string IpRoleId { get; set; }

        /// <summary>
        /// 账单备注
        /// </summary>
        [JsonPropertyName("payment_mark")]
        public string PaymentMark { get; set; }
    }
}
