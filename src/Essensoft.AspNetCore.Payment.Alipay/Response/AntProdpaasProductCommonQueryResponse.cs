using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AntProdpaasProductCommonQueryResponse.
    /// </summary>
    public class AntProdpaasProductCommonQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 产品基本信息
        /// </summary>
        [JsonPropertyName("prod_base")]
        public ProductBaseVO ProdBase { get; set; }

        /// <summary>
        /// 产品条件信息。值为json结构,嵌套结构。normal代表普通条件，其他代表息费等复杂条件，key为条件别名，value为条件值.
        /// </summary>
        [JsonPropertyName("prod_condition")]
        public string ProdCondition { get; set; }

        /// <summary>
        /// 产品参与者关系列表
        /// </summary>
        [JsonPropertyName("prod_ip_list")]
        public List<ProdIPRelationVO> ProdIpList { get; set; }

        /// <summary>
        /// 产品区域关联信息列表
        /// </summary>
        [JsonPropertyName("prod_lo_list")]
        public List<ProdLORelationVO> ProdLoList { get; set; }

        /// <summary>
        /// 产品外标关系列表
        /// </summary>
        [JsonPropertyName("prod_mark_list")]
        public List<ProdMarkRelationVO> ProdMarkList { get; set; }

        /// <summary>
        /// 产品间关系列表
        /// </summary>
        [JsonPropertyName("prod_rel_list")]
        public List<ProdRelationVO> ProdRelList { get; set; }
    }
}
