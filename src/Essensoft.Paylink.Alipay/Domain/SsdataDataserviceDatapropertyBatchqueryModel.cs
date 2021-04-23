using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// SsdataDataserviceDatapropertyBatchqueryModel Data Structure.
    /// </summary>
    public class SsdataDataserviceDatapropertyBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 描述针对datachannel需要执行的操作
        /// </summary>
        [JsonPropertyName("action")]
        public string Action { get; set; }

        /// <summary>
        /// 业务请求入参，云上系统直接转发给域内用来拼接参数
        /// </summary>
        [JsonPropertyName("action_param")]
        public string ActionParam { get; set; }

        /// <summary>
        /// 描述业务调用方名字基础信息
        /// </summary>
        [JsonPropertyName("base")]
        public string Base { get; set; }

        /// <summary>
        /// 描述调用的具体数据渠道名
        /// </summary>
        [JsonPropertyName("data_channel")]
        public string DataChannel { get; set; }

        /// <summary>
        /// 业务访问的tag名
        /// </summary>
        [JsonPropertyName("visit_ac")]
        public string VisitAc { get; set; }

        /// <summary>
        /// 业务线
        /// </summary>
        [JsonPropertyName("visit_biz_line")]
        public string VisitBizLine { get; set; }

        /// <summary>
        /// bu名称
        /// </summary>
        [JsonPropertyName("visit_bu")]
        public string VisitBu { get; set; }
    }
}
