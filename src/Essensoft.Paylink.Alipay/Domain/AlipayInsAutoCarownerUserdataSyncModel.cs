using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayInsAutoCarownerUserdataSyncModel Data Structure.
    /// </summary>
    public class AlipayInsAutoCarownerUserdataSyncModel : AlipayObject
    {
        /// <summary>
        /// 发动机号
        /// </summary>
        [JsonPropertyName("car_engine_no")]
        public string CarEngineNo { get; set; }

        /// <summary>
        /// 车架号
        /// </summary>
        [JsonPropertyName("car_frame_no")]
        public string CarFrameNo { get; set; }

        /// <summary>
        /// 车辆品牌型号
        /// </summary>
        [JsonPropertyName("car_model")]
        public string CarModel { get; set; }

        /// <summary>
        /// 车牌号
        /// </summary>
        [JsonPropertyName("car_no")]
        public string CarNo { get; set; }

        /// <summary>
        /// md5加密后的证件号
        /// </summary>
        [JsonPropertyName("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 保险公司标识
        /// </summary>
        [JsonPropertyName("com_id")]
        public string ComId { get; set; }

        /// <summary>
        /// 注册日期
        /// </summary>
        [JsonPropertyName("first_register_date")]
        public string FirstRegisterDate { get; set; }

        /// <summary>
        /// 外部名单id
        /// </summary>
        [JsonPropertyName("out_leads_id")]
        public string OutLeadsId { get; set; }

        /// <summary>
        /// 数据发送时间
        /// </summary>
        [JsonPropertyName("send_time")]
        public string SendTime { get; set; }
    }
}
