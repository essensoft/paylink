using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KbdishMaterialInfo Data Structure.
    /// </summary>
    public class KbdishMaterialInfo : AlipayObject
    {
        /// <summary>
        /// 加价金额，最小加价金额0
        /// </summary>
        [JsonPropertyName("add_price")]
        public string AddPrice { get; set; }

        /// <summary>
        /// 创建人，在新增时必传
        /// </summary>
        [JsonPropertyName("create_user")]
        public string CreateUser { get; set; }

        /// <summary>
        /// 扩展字段
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 加料的描述字段
        /// </summary>
        [JsonPropertyName("material_desc")]
        public string MaterialDesc { get; set; }

        /// <summary>
        /// 加料id，加料的唯一标识。  新增时该项不用传，修改删除时必传。
        /// </summary>
        [JsonPropertyName("material_id")]
        public string MaterialId { get; set; }

        /// <summary>
        /// 口碑的加料图片id
        /// </summary>
        [JsonPropertyName("material_img")]
        public string MaterialImg { get; set; }

        /// <summary>
        /// 加料的名称
        /// </summary>
        [JsonPropertyName("material_name")]
        public string MaterialName { get; set; }

        /// <summary>
        /// SHOP/PID。代表加料类型是门店或者商户。
        /// </summary>
        [JsonPropertyName("material_type")]
        public string MaterialType { get; set; }

        /// <summary>
        /// 表示单个菜品加料最多可以加料的份数
        /// </summary>
        [JsonPropertyName("max_num")]
        public string MaxNum { get; set; }

        /// <summary>
        /// 商户id
        /// </summary>
        [JsonPropertyName("merchant_id")]
        public string MerchantId { get; set; }

        /// <summary>
        /// 外部isv的加料id
        /// </summary>
        [JsonPropertyName("out_material_id")]
        public string OutMaterialId { get; set; }

        /// <summary>
        /// 公共字段，根据materialType的类型，这里填入商户id或者口碑门店id。
        /// </summary>
        [JsonPropertyName("public_id")]
        public string PublicId { get; set; }

        /// <summary>
        /// 加料的单位id
        /// </summary>
        [JsonPropertyName("unit_id")]
        public string UnitId { get; set; }

        /// <summary>
        /// 修改人，在新增和修改，删除时必传
        /// </summary>
        [JsonPropertyName("update_user")]
        public string UpdateUser { get; set; }
    }
}
