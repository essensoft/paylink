using System;
using Newtonsoft.Json;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// FengdieSpaceListRespModel Data Structure.
    /// </summary>
    [Serializable]
    public class FengdieSpaceListRespModel : AlipayObject
    {
        /// <summary>
        /// 当前VIP用户下面所有的空间详情列表
        /// </summary>
        [JsonProperty("list")]
        [XmlArray("list")]
        [XmlArrayItem("fengdie_space_detail_model")]
        public List<FengdieSpaceDetailModel> List { get; set; }

        /// <summary>
        /// 分页数据信息，包含总数，分页数，当前页码，请求每页的数量
        /// </summary>
        [JsonProperty("paginator")]
        [XmlElement("paginator")]
        public FengdieListPaginator Paginator { get; set; }
    }
}
