using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// EquipmentBindInfo Data Structure.
    /// </summary>
    public class EquipmentBindInfo : AlipayObject
    {
        /// <summary>
        /// 机具ID
        /// </summary>
        [JsonProperty("equipment_id")]
        public string EquipmentId { get; set; }

        /// <summary>
        /// 是否绑定门店，T绑定，F不绑定
        /// </summary>
        [JsonProperty("is_bind_shop")]
        public string IsBindShop { get; set; }
    }
}
