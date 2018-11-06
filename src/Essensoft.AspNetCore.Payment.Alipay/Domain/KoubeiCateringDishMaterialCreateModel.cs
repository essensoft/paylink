using System;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiCateringDishMaterialCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringDishMaterialCreateModel : AlipayObject
    {
        /// <summary>
        /// 菜品加料入参
        /// </summary>
        [JsonProperty("kb_dish_material_info")]
        [XmlElement("kb_dish_material_info")]
        public KbdishMaterialInfo KbDishMaterialInfo { get; set; }
    }
}
