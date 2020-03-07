using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayEcoLicenseOcrIdentifyResponse.
    /// </summary>
    public class AlipayEcoLicenseOcrIdentifyResponse : AlipayResponse
    {
        /// <summary>
        /// 地址
        /// </summary>
        [JsonPropertyName("address")]
        public string Address { get; set; }

        /// <summary>
        /// 经营范围
        /// </summary>
        [JsonPropertyName("business")]
        public string Business { get; set; }

        /// <summary>
        /// 注册资本
        /// </summary>
        [JsonPropertyName("captial")]
        public string Captial { get; set; }

        /// <summary>
        /// 成立日期
        /// </summary>
        [JsonPropertyName("establish_date")]
        public string EstablishDate { get; set; }

        /// <summary>
        /// 公司名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 法定代表人
        /// </summary>
        [JsonPropertyName("person")]
        public string Person { get; set; }

        /// <summary>
        /// 统一社会信用代码
        /// </summary>
        [JsonPropertyName("reg_num")]
        public string RegNum { get; set; }

        /// <summary>
        /// 营业期限
        /// </summary>
        [JsonPropertyName("valid_period")]
        public string ValidPeriod { get; set; }
    }
}
