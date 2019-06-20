using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEbppIndustryBizinfoQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppIndustryBizinfoQueryModel : AlipayObject
    {
        /// <summary>
        /// 业务机构简称
        /// </summary>
        [JsonProperty("biz_inst")]
        public string BizInst { get; set; }

        /// <summary>
        /// 业务类型，公服业务：IND
        /// </summary>
        [JsonProperty("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 业务数据码，标识业务场景
        /// </summary>
        [JsonProperty("data_code")]
        public string DataCode { get; set; }

        /// <summary>
        /// 请求上下文，json格式
        /// </summary>
        [JsonProperty("request_context")]
        public string RequestContext { get; set; }
    }
}
