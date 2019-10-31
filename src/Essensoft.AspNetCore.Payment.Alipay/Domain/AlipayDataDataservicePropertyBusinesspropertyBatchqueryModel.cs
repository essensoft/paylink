using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayDataDataservicePropertyBusinesspropertyBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataservicePropertyBusinesspropertyBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 业务画像id
        /// </summary>
        [JsonProperty("business_profile_id")]
        public string BusinessProfileId { get; set; }

        /// <summary>
        /// 业务画像标签id列表，逗号分隔
        /// </summary>
        [JsonProperty("business_property_ids")]
        public List<string> BusinessPropertyIds { get; set; }

        /// <summary>
        /// 业务画像标签对应的columnGuid
        /// </summary>
        [JsonProperty("column_guid")]
        public string ColumnGuid { get; set; }

        /// <summary>
        /// 标签名称
        /// </summary>
        [JsonProperty("property_name")]
        public string PropertyName { get; set; }

        /// <summary>
        /// 标签状态，逗号分隔
        /// </summary>
        [JsonProperty("status")]
        public List<string> Status { get; set; }

        /// <summary>
        /// 业务画像标签对应的tableGuid
        /// </summary>
        [JsonProperty("table_guid")]
        public string TableGuid { get; set; }
    }
}
