using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceTransportVehicleownerMessageSendModel Data Structure.
    /// </summary>
    public class AlipayCommerceTransportVehicleownerMessageSendModel : AlipayObject
    {
        /// <summary>
        /// 消息条数，需和msg_list数组中消息实际条数保持一致，上限20条
        /// </summary>
        [JsonPropertyName("batch_size")]
        public long BatchSize { get; set; }

        /// <summary>
        /// 敏感字段加密类型，目前支持md5，默认加密字段是msg_list中每条消息的“certificate_number”字段
        /// </summary>
        [JsonPropertyName("encrypt_type")]
        public string EncryptType { get; set; }

        /// <summary>
        /// 消息列表
        /// </summary>
        [JsonPropertyName("msg_list")]
        public List<VehMessageEntity> MsgList { get; set; }
    }
}
