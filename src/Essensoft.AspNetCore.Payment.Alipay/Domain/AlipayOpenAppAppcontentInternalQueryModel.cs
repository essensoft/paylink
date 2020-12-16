using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenAppAppcontentInternalQueryModel Data Structure.
    /// </summary>
    public class AlipayOpenAppAppcontentInternalQueryModel : AlipayObject
    {
        /// <summary>
        /// 当前页码
        /// </summary>
        [JsonPropertyName("page_num")]
        public string PageNum { get; set; }

        /// <summary>
        /// 分页条数，最大20
        /// </summary>
        [JsonPropertyName("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 商户PID
        /// </summary>
        [JsonPropertyName("pid")]
        public string Pid { get; set; }

        /// <summary>
        /// 查询模式 QUERY_MINIAPP_BY_PID: 根据PID查询小程序服务，支持分页  QUERY_FUNCTION_BY_APPID: 根据APPID查询功能服务，不支持分页  QUERY_FUNCTION_BY_SERVICE_CODES: 根据服务编码批量查询功能服务，不支持分页
        /// </summary>
        [JsonPropertyName("query_mode")]
        public string QueryMode { get; set; }

        /// <summary>
        /// appid
        /// </summary>
        [JsonPropertyName("ref_app_id")]
        public string RefAppId { get; set; }

        /// <summary>
        /// 请求方系统名称
        /// </summary>
        [JsonPropertyName("request_system")]
        public string RequestSystem { get; set; }

        /// <summary>
        /// 服务编码列表，单次最多10个
        /// </summary>
        [JsonPropertyName("service_code_list")]
        public List<string> ServiceCodeList { get; set; }
    }
}
