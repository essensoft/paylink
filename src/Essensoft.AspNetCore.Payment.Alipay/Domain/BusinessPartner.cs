using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// BusinessPartner Data Structure.
    /// </summary>
    public class BusinessPartner : AlipayObject
    {
        /// <summary>
        /// 机构本地名称
        /// </summary>
        [JsonPropertyName("business_local_name")]
        public string BusinessLocalName { get; set; }

        /// <summary>
        /// 商业合作伙伴别名，一般业务场景下所使用，对商户的简称、缩写或别称
        /// </summary>
        [JsonPropertyName("business_name")]
        public string BusinessName { get; set; }

        /// <summary>
        /// Business logo
        /// </summary>
        [JsonPropertyName("logo")]
        public string Logo { get; set; }

        /// <summary>
        /// logo的类型
        /// </summary>
        [JsonPropertyName("logo_type")]
        public string LogoType { get; set; }

        /// <summary>
        /// Merchant category code
        /// </summary>
        [JsonPropertyName("mcc")]
        public string Mcc { get; set; }

        /// <summary>
        /// 营业地址
        /// </summary>
        [JsonPropertyName("operation_address")]
        public OperationAddress OperationAddress { get; set; }
    }
}
