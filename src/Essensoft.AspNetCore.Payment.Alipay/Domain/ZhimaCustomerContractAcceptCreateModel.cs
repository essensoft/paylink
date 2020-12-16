using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ZhimaCustomerContractAcceptCreateModel Data Structure.
    /// </summary>
    public class ZhimaCustomerContractAcceptCreateModel : AlipayObject
    {
        /// <summary>
        /// 业务主体id，比如淘宝id
        /// </summary>
        [JsonPropertyName("biz_principal_id")]
        public string BizPrincipalId { get; set; }

        /// <summary>
        /// 业务主体类型
        /// </summary>
        [JsonPropertyName("biz_principal_type")]
        public string BizPrincipalType { get; set; }

        /// <summary>
        /// 合约号
        /// </summary>
        [JsonPropertyName("contract_no")]
        public string ContractNo { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
