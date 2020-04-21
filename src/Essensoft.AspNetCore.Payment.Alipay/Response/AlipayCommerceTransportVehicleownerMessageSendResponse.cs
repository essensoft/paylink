using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceTransportVehicleownerMessageSendResponse.
    /// </summary>
    public class AlipayCommerceTransportVehicleownerMessageSendResponse : AlipayResponse
    {
        /// <summary>
        /// 批量发送结果
        /// </summary>
        [JsonPropertyName("send_result_list")]
        public List<VehicleMsgSendResultEntity> SendResultList { get; set; }
    }
}
