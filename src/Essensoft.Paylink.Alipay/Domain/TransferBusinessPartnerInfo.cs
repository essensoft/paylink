using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// TransferBusinessPartnerInfo Data Structure.
    /// </summary>
    public class TransferBusinessPartnerInfo : AlipayObject
    {
        /// <summary>
        /// 企业本地名称
        /// </summary>
        [JsonPropertyName("business_local_name")]
        public string BusinessLocalName { get; set; }

        /// <summary>
        /// 企业名称
        /// </summary>
        [JsonPropertyName("business_name")]
        public string BusinessName { get; set; }

        /// <summary>
        /// logo
        /// </summary>
        [JsonPropertyName("logo")]
        public string Logo { get; set; }

        /// <summary>
        /// logo类型
        /// </summary>
        [JsonPropertyName("logo_type")]
        public string LogoType { get; set; }

        /// <summary>
        /// mcc
        /// </summary>
        [JsonPropertyName("mcc")]
        public string Mcc { get; set; }

        /// <summary>
        /// 地址
        /// </summary>
        [JsonPropertyName("operation_address")]
        public TransferAddressInfo OperationAddress { get; set; }
    }
}
