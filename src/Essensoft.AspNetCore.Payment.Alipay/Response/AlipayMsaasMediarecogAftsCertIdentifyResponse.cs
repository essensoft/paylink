using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMsaasMediarecogAftsCertIdentifyResponse.
    /// </summary>
    public class AlipayMsaasMediarecogAftsCertIdentifyResponse : AlipayResponse
    {
        /// <summary>
        /// 浮点数，属于该证件类型的概率
        /// </summary>
        [JsonPropertyName("cert_probability")]
        public long CertProbability { get; set; }

        /// <summary>
        /// 证件类型
        /// </summary>
        [JsonPropertyName("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 发动机号
        /// </summary>
        [JsonPropertyName("ocr_engine_number")]
        public string OcrEngineNumber { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        [JsonPropertyName("ocr_name")]
        public string OcrName { get; set; }

        /// <summary>
        /// 车牌
        /// </summary>
        [JsonPropertyName("ocr_plate_number")]
        public string OcrPlateNumber { get; set; }

        /// <summary>
        /// 车架号
        /// </summary>
        [JsonPropertyName("ocr_vehicle_id")]
        public string OcrVehicleId { get; set; }
    }
}
