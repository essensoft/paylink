using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipaySecurityDataAlibabaSecuritydataQueryModel Data Structure.
    /// </summary>
    public class AlipaySecurityDataAlibabaSecuritydataQueryModel : AlipayObject
    {
        /// <summary>
        /// 业务方调用唯一标识，可以是traceID
        /// </summary>
        [JsonPropertyName("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 查询服务名，由服务方给定
        /// </summary>
        [JsonPropertyName("service_name")]
        public string ServiceName { get; set; }

        /// <summary>
        /// 调用系统名
        /// </summary>
        [JsonPropertyName("system_name")]
        public string SystemName { get; set; }

        /// <summary>
        /// 查询服务表名
        /// </summary>
        [JsonPropertyName("table_name")]
        public string TableName { get; set; }

        /// <summary>
        /// 设备ID，需要hash处理，不能反解析。
        /// </summary>
        [JsonPropertyName("umid")]
        public string Umid { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
