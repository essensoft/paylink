using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// EquipmentAuthRemoveQueryBypageDTO Data Structure.
    /// </summary>
    public class EquipmentAuthRemoveQueryBypageDTO : AlipayObject
    {
        /// <summary>
        /// 机具编号
        /// </summary>
        [JsonProperty("device_id")]
        public string DeviceId { get; set; }

        /// <summary>
        /// 解绑时间
        /// </summary>
        [JsonProperty("unbind_time")]
        public string UnbindTime { get; set; }
    }
}
