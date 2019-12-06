using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// InvoiceTitleModel Data Structure.
    /// </summary>
    public class InvoiceTitleModel : AlipayObject
    {
        /// <summary>
        /// 是否为用户设置默认抬头  字段值包括两种情况：  false（非默认）  true（默认抬头）
        /// </summary>
        [JsonPropertyName("is_default")]
        public bool IsDefault { get; set; }

        /// <summary>
        /// 支付宝用户登录名
        /// </summary>
        [JsonPropertyName("logon_id")]
        public string LogonId { get; set; }

        /// <summary>
        /// 银行账号
        /// </summary>
        [JsonPropertyName("open_bank_account")]
        public string OpenBankAccount { get; set; }

        /// <summary>
        /// 开户银行
        /// </summary>
        [JsonPropertyName("open_bank_name")]
        public string OpenBankName { get; set; }

        /// <summary>
        /// 纳税人识别号
        /// </summary>
        [JsonPropertyName("tax_register_no")]
        public string TaxRegisterNo { get; set; }

        /// <summary>
        /// 用户私人手机号
        /// </summary>
        [JsonPropertyName("tele_phone_no")]
        public string TelePhoneNo { get; set; }

        /// <summary>
        /// 抬头名称
        /// </summary>
        [JsonPropertyName("title_name")]
        public string TitleName { get; set; }

        /// <summary>
        /// 抬头类型  字段值有两种情况抬:  PERSONAL（个人）   CORPORATION（单位）
        /// </summary>
        [JsonPropertyName("title_type")]
        public string TitleType { get; set; }

        /// <summary>
        /// 地址
        /// </summary>
        [JsonPropertyName("user_address")]
        public string UserAddress { get; set; }

        /// <summary>
        /// 邮箱
        /// </summary>
        [JsonPropertyName("user_email")]
        public string UserEmail { get; set; }

        /// <summary>
        /// 支付宝用户id
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 电话号码
        /// </summary>
        [JsonPropertyName("user_mobile")]
        public string UserMobile { get; set; }
    }
}
