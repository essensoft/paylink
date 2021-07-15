using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayInsSceneHealthDrugcatalogueBatchqueryModel Data Structure.
    /// </summary>
    public class AlipayInsSceneHealthDrugcatalogueBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 蚂蚁合约单号
        /// </summary>
        [JsonPropertyName("ant_ser_contract_no")]
        public string AntSerContractNo { get; set; }

        /// <summary>
        /// 疾病名称列表
        /// </summary>
        [JsonPropertyName("disease_name_list")]
        public List<string> DiseaseNameList { get; set; }

        /// <summary>
        /// 是否急诊，true急诊，false非急诊
        /// </summary>
        [JsonPropertyName("emergency")]
        public bool Emergency { get; set; }

        /// <summary>
        /// 药品通用名列表
        /// </summary>
        [JsonPropertyName("general_name_list")]
        public List<string> GeneralNameList { get; set; }
    }
}
