using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// InvestigCategoryData Data Structure.
    /// </summary>
    public class InvestigCategoryData : AlipayObject
    {
        /// <summary>
        /// 数据项
        /// </summary>
        [JsonPropertyName("category")]
        public string Category { get; set; }

        /// <summary>
        /// 采集的数据的版本号。
        /// </summary>
        [JsonPropertyName("data_version")]
        public string DataVersion { get; set; }

        /// <summary>
        /// 实体code
        /// </summary>
        [JsonPropertyName("entity_code")]
        public string EntityCode { get; set; }

        /// <summary>
        /// 实体名
        /// </summary>
        [JsonPropertyName("entity_name")]
        public string EntityName { get; set; }

        /// <summary>
        /// 实体类别
        /// </summary>
        [JsonPropertyName("entity_type")]
        public string EntityType { get; set; }

        /// <summary>
        /// 征信模型结果,以JSON格式输出，包括征信评分creditScore、不准入原因refuseReasons、模型标识码modelIdCode三个字段
        /// </summary>
        [JsonPropertyName("model_result_object")]
        public string ModelResultObject { get; set; }

        /// <summary>
        /// 采集状态
        /// </summary>
        [JsonPropertyName("state")]
        public string State { get; set; }
    }
}
