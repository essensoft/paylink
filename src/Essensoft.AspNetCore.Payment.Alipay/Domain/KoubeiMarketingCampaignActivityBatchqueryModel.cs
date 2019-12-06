using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiMarketingCampaignActivityBatchqueryModel Data Structure.
    /// </summary>
    public class KoubeiMarketingCampaignActivityBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 操作人id，必须和operator_type配对存在，不填时默认是商户
        /// </summary>
        [JsonPropertyName("operator_id")]
        public string OperatorId { get; set; }

        /// <summary>
        /// 操作人类型,有以下值可填：MER（外部商户），MER_OPERATOR（外部商户操作员），PROVIDER（外部服务商），PROVIDER_STAFF（外部服务商员工），默认不需要填这个字段，默认为MER
        /// </summary>
        [JsonPropertyName("operator_type")]
        public string OperatorType { get; set; }

        /// <summary>
        /// 页码，默认为1
        /// </summary>
        [JsonPropertyName("page_number")]
        public string PageNumber { get; set; }

        /// <summary>
        /// 页大小，默认为20
        /// </summary>
        [JsonPropertyName("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 查询条件
        /// </summary>
        [JsonPropertyName("query_criterias")]
        public List<Condition> QueryCriterias { get; set; }
    }
}
