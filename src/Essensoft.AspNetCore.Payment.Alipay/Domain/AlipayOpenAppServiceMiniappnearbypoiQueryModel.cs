using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenAppServiceMiniappnearbypoiQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppServiceMiniappnearbypoiQueryModel : AlipayObject
    {
        /// <summary>
        /// poiCode列表
        /// </summary>
        [JsonProperty("poi_code_list")]
        public List<string> PoiCodeList { get; set; }

        /// <summary>
        /// 服务编码
        /// </summary>
        [JsonProperty("service_code")]
        public string ServiceCode { get; set; }
    }
}
