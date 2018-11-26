using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// FengdieSitesListRespModel Data Structure.
    /// </summary>
    [Serializable]
    public class FengdieSitesListRespModel : AlipayObject
    {
        /// <summary>
        /// 云凤蝶站点数据列表
        /// </summary>
        [JsonProperty("list")]
        [XmlArray("list")]
        [XmlArrayItem("fengdie_sites_list_model")]
        public List<FengdieSitesListModel> List { get; set; }

        /// <summary>
        /// 分页数据信息，包含总数，分页数，当前页码，请求每页的数量
        /// </summary>
        [JsonProperty("paginator")]
        [XmlElement("paginator")]
        public FengdieListPaginator Paginator { get; set; }
    }
}
