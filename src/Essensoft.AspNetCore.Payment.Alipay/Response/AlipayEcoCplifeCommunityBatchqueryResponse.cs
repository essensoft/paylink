using System.Collections.Generic;
using System.Xml.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayEcoCplifeCommunityBatchqueryResponse.
    /// </summary>
    public class AlipayEcoCplifeCommunityBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 若查询到符合条件的小区，返回物业小区摘要信息列表
        /// </summary>
        [JsonProperty("community_list")]
        [XmlArray("community_list")]
        [XmlArrayItem("c_p_community_set")]
        public List<CPCommunitySet> CommunityList { get; set; }

        /// <summary>
        /// 当前页码
        /// </summary>
        [JsonProperty("current_page_num")]
        [XmlElement("current_page_num")]
        public long CurrentPageNum { get; set; }

        /// <summary>
        /// 开发者帮助物业创建成功并符合查询条件的小区总数。  若不传入app_auth_token参数，则返回开发者代创建成功的所有小区总数。  若传入app_auth_token参数，则返回对应开发者帮助该授权物业公司创建成功的小区总数。
        /// </summary>
        [JsonProperty("total_community_count")]
        [XmlElement("total_community_count")]
        public long TotalCommunityCount { get; set; }
    }
}
