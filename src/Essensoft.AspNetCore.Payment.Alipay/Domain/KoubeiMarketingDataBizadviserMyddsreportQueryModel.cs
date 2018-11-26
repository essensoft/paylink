using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiMarketingDataBizadviserMyddsreportQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMarketingDataBizadviserMyddsreportQueryModel : AlipayObject
    {
        /// <summary>
        /// req_parameters是请求参数汇集的一个json串和格式如下；  json串里需要传两个参数：shopId：门店Id   memberType会员类型，1:会员、2:潜客。  "req_parameters": [{            "paramKey": "shopId",            "paramValue": "门店Id 的值"            },{            "paramKey": "memberType",            "paramValue": "1"            }]
        /// </summary>
        [JsonProperty("req_parameters")]
        [XmlElement("req_parameters")]
        public string ReqParameters { get; set; }

        /// <summary>
        /// uniq_key 为请求类型，传值为shopMemberHeatmap时查询门店会员/潜在会员 热力图数据；
        /// </summary>
        [JsonProperty("uniq_key")]
        [XmlElement("uniq_key")]
        public string UniqKey { get; set; }
    }
}
