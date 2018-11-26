using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoMycarDataExternalSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoMycarDataExternalSendModel : AlipayObject
    {
        /// <summary>
        /// external_system_name
        /// </summary>
        [JsonProperty("external_system_name")]
        [XmlElement("external_system_name")]
        public string ExternalSystemName { get; set; }

        /// <summary>
        /// is_transfer_uid
        /// </summary>
        [JsonProperty("is_transfer_uid")]
        [XmlElement("is_transfer_uid")]
        public string IsTransferUid { get; set; }

        /// <summary>
        /// operate_type
        /// </summary>
        [JsonProperty("operate_type")]
        [XmlElement("operate_type")]
        public string OperateType { get; set; }

        /// <summary>
        /// send_data
        /// </summary>
        [JsonProperty("send_data")]
        [XmlElement("send_data")]
        public string SendData { get; set; }
    }
}
