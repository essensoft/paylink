using System.Collections.Generic;
using System.Xml.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// ZhimaCreditWatchlistiiGetResponse.
    /// </summary>
    public class ZhimaCreditWatchlistiiGetResponse : AlipayResponse
    {
        /// <summary>
        /// 芝麻信用对于每一次请求返回的业务号。后续可以通过此业务号进行对账
        /// </summary>
        [JsonProperty("biz_no")]
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 所查询的某个用户的行业关注名单列表。当is_matched为true时会返回该参数。
        /// </summary>
        [JsonProperty("details")]
        [XmlArray("details")]
        [XmlArrayItem("zm_watch_list_detail")]
        public List<ZmWatchListDetail> Details { get; set; }

        /// <summary>
        /// true=命中 在关注名单中  false=未命中
        /// </summary>
        [JsonProperty("is_matched")]
        [XmlElement("is_matched")]
        public bool IsMatched { get; set; }
    }
}
