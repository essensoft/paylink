using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMarketingVoucherStockMatchResponse.
    /// </summary>
    public class AlipayMarketingVoucherStockMatchResponse : AlipayResponse
    {
        /// <summary>
        /// 已存在券码列表, 已通过创建接口上传的列表
        /// </summary>
        [JsonProperty("exist_list")]
        [XmlArray("exist_list")]
        [XmlArrayItem("string")]
        public List<string> ExistList { get; set; }

        /// <summary>
        /// 不存券码列表，还未上传过的券码
        /// </summary>
        [JsonProperty("not_exist_list")]
        [XmlArray("not_exist_list")]
        [XmlArrayItem("string")]
        public List<string> NotExistList { get; set; }
    }
}
