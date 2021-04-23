using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayUserAccountDeviceInfoQueryResponse.
    /// </summary>
    public class AlipayUserAccountDeviceInfoQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 满足投放条件的简要设备信息 1. device_id：对应入参中设备的唯一标识； 2. device_label：咨询的结果标签
        /// </summary>
        [JsonPropertyName("device_infos")]
        public List<DeviceResultInfo> DeviceInfos { get; set; }

        /// <summary>
        /// 设备类型，如：IDFA、IMEI、MOBILE等 注意：该字段正在废弃，由于该信息取自用户传入参数，所以此处不再做回填；
        /// </summary>
        [JsonPropertyName("device_type")]
        public string DeviceType { get; set; }

        /// <summary>
        /// 设备id的加密方式，如没有加密，可以不传。一般sha256即可满足需求，如其他方式，请和支付宝技术支持联系。 注意：该字段正在废弃，由于该信息取自用户传入参数，所以此处不再做回填；
        /// </summary>
        [JsonPropertyName("encrypt_type")]
        public string EncryptType { get; set; }

        /// <summary>
        /// 请求处理结果
        /// </summary>
        [JsonPropertyName("result_code")]
        public string ResultCode { get; set; }
    }
}
