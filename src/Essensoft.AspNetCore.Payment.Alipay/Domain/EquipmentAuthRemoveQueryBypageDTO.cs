using System.Text.Json.Serialization;

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
        [JsonPropertyName("device_id")]
        public string DeviceId { get; set; }

        /// <summary>
        /// 解绑时间
        /// </summary>
        [JsonPropertyName("unbind_time")]
        public string UnbindTime { get; set; }
    }
}
