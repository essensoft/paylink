using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayDataDataservicePropertyBusinesspropertyBatchqueryModel Data Structure.
    /// </summary>
    public class AlipayDataDataservicePropertyBusinesspropertyBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 业务画像id
        /// </summary>
        [JsonPropertyName("business_profile_id")]
        public string BusinessProfileId { get; set; }

        /// <summary>
        /// 业务画像标签id列表，逗号分隔
        /// </summary>
        [JsonPropertyName("business_property_ids")]
        public List<string> BusinessPropertyIds { get; set; }

        /// <summary>
        /// 业务画像标签对应的columnGuid
        /// </summary>
        [JsonPropertyName("column_guid")]
        public string ColumnGuid { get; set; }

        /// <summary>
        /// 标签名称
        /// </summary>
        [JsonPropertyName("property_name")]
        public string PropertyName { get; set; }

        /// <summary>
        /// 标签状态，逗号分隔
        /// </summary>
        [JsonPropertyName("status")]
        public List<string> Status { get; set; }

        /// <summary>
        /// 业务画像标签对应的tableGuid
        /// </summary>
        [JsonPropertyName("table_guid")]
        public string TableGuid { get; set; }
    }
}
