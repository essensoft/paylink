using System;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KbdishMaterialInfo Data Structure.
    /// </summary>
    [Serializable]
    public class KbdishMaterialInfo : AlipayObject
    {
        /// <summary>
        /// 加价金额，最小加价金额0
        /// </summary>
        [JsonProperty("add_price")]
        [XmlElement("add_price")]
        public string AddPrice { get; set; }

        /// <summary>
        /// 创建人，在新增时必传
        /// </summary>
        [JsonProperty("create_user")]
        [XmlElement("create_user")]
        public string CreateUser { get; set; }

        /// <summary>
        /// 扩展字段
        /// </summary>
        [JsonProperty("ext_info")]
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 加料id，加料的唯一标识。  新增时该项不用传，修改删除时必传。
        /// </summary>
        [JsonProperty("material_id")]
        [XmlElement("material_id")]
        public string MaterialId { get; set; }

        /// <summary>
        /// 口碑的加料图片id
        /// </summary>
        [JsonProperty("material_img")]
        [XmlElement("material_img")]
        public string MaterialImg { get; set; }

        /// <summary>
        /// 加料的名称
        /// </summary>
        [JsonProperty("material_name")]
        [XmlElement("material_name")]
        public string MaterialName { get; set; }

        /// <summary>
        /// SHOP/PID。代表加料类型是商户或者门店。
        /// </summary>
        [JsonProperty("material_type")]
        [XmlElement("material_type")]
        public string MaterialType { get; set; }

        /// <summary>
        /// 表示单个菜品加料最多可以加料的份数
        /// </summary>
        [JsonProperty("max_num")]
        [XmlElement("max_num")]
        public string MaxNum { get; set; }

        /// <summary>
        /// 商户id
        /// </summary>
        [JsonProperty("merchant_id")]
        [XmlElement("merchant_id")]
        public string MerchantId { get; set; }

        /// <summary>
        /// 公共字段，根据materialType的类型，这里填入商户id或者口碑门店id。
        /// </summary>
        [JsonProperty("public_id")]
        [XmlElement("public_id")]
        public string PublicId { get; set; }

        /// <summary>
        /// 修改人，在新增和修改，删除时必传
        /// </summary>
        [JsonProperty("update_user")]
        [XmlElement("update_user")]
        public string UpdateUser { get; set; }
    }
}
