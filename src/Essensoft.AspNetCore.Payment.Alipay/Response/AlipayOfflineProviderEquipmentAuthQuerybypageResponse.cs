using System.Collections.Generic;
using System.Xml.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOfflineProviderEquipmentAuthQuerybypageResponse.
    /// </summary>
    public class AlipayOfflineProviderEquipmentAuthQuerybypageResponse : AlipayResponse
    {
        /// <summary>
        /// 机具解绑按照条件分页查询返回信息
        /// </summary>
        [JsonProperty("equipmentauthremovequerybypagelist")]
        [XmlArray("equipmentauthremovequerybypagelist")]
        [XmlArrayItem("equipment_auth_remove_query_bypage_d_t_o")]
        public List<EquipmentAuthRemoveQueryBypageDTO> Equipmentauthremovequerybypagelist { get; set; }

        /// <summary>
        /// 总记录数
        /// </summary>
        [JsonProperty("total")]
        [XmlElement("total")]
        public long Total { get; set; }
    }
}
