using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayIserviceCognitiveOcrVehicledashboardQueryResponse.
    /// </summary>
    public class AlipayIserviceCognitiveOcrVehicledashboardQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 服务ip
        /// </summary>
        [JsonPropertyName("ip")]
        public string Ip { get; set; }

        /// <summary>
        /// 识别结果
        /// </summary>
        [JsonPropertyName("result")]
        public List<VehicleDashboardResult> Result { get; set; }

        /// <summary>
        /// 0为识别成功，1为识别失败
        /// </summary>
        [JsonPropertyName("ret")]
        public long Ret { get; set; }

        /// <summary>
        /// 识别服务的RT,单位为毫秒ms
        /// </summary>
        [JsonPropertyName("rt")]
        public long Rt { get; set; }

        /// <summary>
        /// 识别服务的session id
        /// </summary>
        [JsonPropertyName("sid")]
        public string Sid { get; set; }
    }
}
