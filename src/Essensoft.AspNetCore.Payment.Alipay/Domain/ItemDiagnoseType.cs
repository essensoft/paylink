using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ItemDiagnoseType Data Structure.
    /// </summary>
    [Serializable]
    public class ItemDiagnoseType : AlipayObject
    {
        /// <summary>
        /// 001是明星菜品，002是潜力菜品，003是其他菜品（除明星菜品和潜力菜品之外的其他一律作为其他菜品 编号为003）。  2- 如果要查询所有的则传入999。具体的值可以通过koubei.marketing.data.dishdiagnosetype.batchquery来查询，同时会返回类型与说明
        /// </summary>
        [JsonProperty("item_diagnose")]
        [XmlElement("item_diagnose")]
        public string ItemDiagnose { get; set; }

        /// <summary>
        /// 对类型的描述
        /// </summary>
        [JsonProperty("item_diagnose_desc")]
        [XmlElement("item_diagnose_desc")]
        public string ItemDiagnoseDesc { get; set; }
    }
}
