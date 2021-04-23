using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipaySecurityDataAlibabaSecuritydataSendModel Data Structure.
    /// </summary>
    public class AlipaySecurityDataAlibabaSecuritydataSendModel : AlipayObject
    {
        /// <summary>
        /// 业务描述信息
        /// </summary>
        [JsonPropertyName("biz_content_value")]
        public string BizContentValue { get; set; }

        /// <summary>
        /// 业务数据唯一标识，可以是traceId
        /// </summary>
        [JsonPropertyName("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 数据平台数据接入名称
        /// </summary>
        [JsonPropertyName("ingest_name")]
        public string IngestName { get; set; }

        /// <summary>
        /// 数据主体类型
        /// </summary>
        [JsonPropertyName("main_target_type")]
        public string MainTargetType { get; set; }

        /// <summary>
        /// 数据主体值
        /// </summary>
        [JsonPropertyName("main_target_value")]
        public string MainTargetValue { get; set; }

        /// <summary>
        /// 一级属性
        /// </summary>
        [JsonPropertyName("property")]
        public string Property { get; set; }

        /// <summary>
        /// 二级属性
        /// </summary>
        [JsonPropertyName("property_second")]
        public string PropertySecond { get; set; }

        /// <summary>
        /// 三级属性
        /// </summary>
        [JsonPropertyName("property_third")]
        public string PropertyThird { get; set; }

        /// <summary>
        /// 风险类型
        /// </summary>
        [JsonPropertyName("risk_type")]
        public string RiskType { get; set; }

        /// <summary>
        /// 数据使用范围，security或者其他范围
        /// </summary>
        [JsonPropertyName("scope")]
        public string Scope { get; set; }

        /// <summary>
        /// 数据来源
        /// </summary>
        [JsonPropertyName("source")]
        public string Source { get; set; }

        /// <summary>
        /// 数据发送方系统名称
        /// </summary>
        [JsonPropertyName("system_name")]
        public string SystemName { get; set; }

        /// <summary>
        /// 安全数据平台资产表名
        /// </summary>
        [JsonPropertyName("table_name")]
        public string TableName { get; set; }

        /// <summary>
        /// 数据产生时间
        /// </summary>
        [JsonPropertyName("time")]
        public string Time { get; set; }

        /// <summary>
        /// 数据使用范围，security或者其他范围
        /// </summary>
        [JsonPropertyName("use_scope")]
        public string UseScope { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
