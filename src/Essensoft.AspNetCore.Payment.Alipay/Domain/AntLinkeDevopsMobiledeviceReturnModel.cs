using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AntLinkeDevopsMobiledeviceReturnModel Data Structure.
    /// </summary>
    public class AntLinkeDevopsMobiledeviceReturnModel : AlipayObject
    {
        /// <summary>
        /// device_id+唯一+设备释放对象+antdevops.mobiledevice.get接口返回参数+必须先占用才能释放
        /// </summary>
        [JsonPropertyName("device_id")]
        public string DeviceId { get; set; }

        /// <summary>
        /// access_host+唯一+释放设备的host信息+apply结果返回结果
        /// </summary>
        [JsonPropertyName("remote_host")]
        public string RemoteHost { get; set; }
    }
}
