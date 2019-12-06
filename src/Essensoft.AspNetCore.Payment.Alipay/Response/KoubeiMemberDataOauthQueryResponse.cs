using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiMemberDataOauthQueryResponse.
    /// </summary>
    public class KoubeiMemberDataOauthQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 扩展信息, 目前保留未用
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 操作人id
        /// </summary>
        [JsonPropertyName("operator_id")]
        public string OperatorId { get; set; }

        /// <summary>
        /// 商户id
        /// </summary>
        [JsonPropertyName("operator_partner_id")]
        public string OperatorPartnerId { get; set; }

        /// <summary>
        /// 操作人身份，PROVIDER:服务商,PROVIDER_STAFF:服务商员工,MER:商户,MER_STAFF:商户员工,SALES:阿里销售小二
        /// </summary>
        [JsonPropertyName("operator_type")]
        public string OperatorType { get; set; }

        /// <summary>
        /// 操作人身份是商家员工(MER_STAFF)或服务商员工(PROVIDER_STAFF)时将返回其可操作的门店id列表
        /// </summary>
        [JsonPropertyName("shop_ids")]
        public string ShopIds { get; set; }
    }
}
