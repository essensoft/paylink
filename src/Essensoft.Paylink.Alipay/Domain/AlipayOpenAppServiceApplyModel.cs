using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenAppServiceApplyModel Data Structure.
    /// </summary>
    public class AlipayOpenAppServiceApplyModel : AlipayObject
    {
        /// <summary>
        /// 行业类目id
        /// </summary>
        [JsonPropertyName("category_id")]
        public string CategoryId { get; set; }

        /// <summary>
        /// 外部业务编号,平台会基于appId+out_biz_no做幂等控制，如果出现幂等，会返回幂等的service_code
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 服务schema版本
        /// </summary>
        [JsonPropertyName("schema_version")]
        public string SchemaVersion { get; set; }

        /// <summary>
        /// 服务xml
        /// </summary>
        [JsonPropertyName("service_xml")]
        public string ServiceXml { get; set; }
    }
}
