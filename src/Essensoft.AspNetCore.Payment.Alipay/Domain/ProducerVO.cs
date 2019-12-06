using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ProducerVO Data Structure.
    /// </summary>
    public class ProducerVO : AlipayObject
    {
        /// <summary>
        /// 业务状态，EFFECTIVE:有效、INVALID:无效
        /// </summary>
        [JsonPropertyName("biz_status")]
        public string BizStatus { get; set; }

        /// <summary>
        /// 经营信息
        /// </summary>
        [JsonPropertyName("business_desc")]
        public string BusinessDesc { get; set; }

        /// <summary>
        /// 证照信息，枚举值如下：  LICENSE_NO:许可证号,  LICENSE_DATE:营业执照有效期,  PAYMENT_DAYS:账期天数,  TAX_NUMBER:税务证号,  BANK:开户银行,  BANK_ACCOUNT:银行账号,  CONTACT:联系人,  PHONE:联系电话,  ACCOUNT_DAY:结账日期
        /// </summary>
        [JsonPropertyName("certificate_desc")]
        public string CertificateDesc { get; set; }

        /// <summary>
        /// 生产厂商ID
        /// </summary>
        [JsonPropertyName("producer_id")]
        public string ProducerId { get; set; }

        /// <summary>
        /// 生产厂商名称
        /// </summary>
        [JsonPropertyName("producer_name")]
        public string ProducerName { get; set; }

        /// <summary>
        /// 短码
        /// </summary>
        [JsonPropertyName("short_code")]
        public string ShortCode { get; set; }
    }
}
