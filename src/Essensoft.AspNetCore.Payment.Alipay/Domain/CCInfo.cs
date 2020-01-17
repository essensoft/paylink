using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// CCInfo Data Structure.
    /// </summary>
    public class CCInfo : AlipayObject
    {
        /// <summary>
        /// 收件人详细地址
        /// </summary>
        [JsonPropertyName("address")]
        public string Address { get; set; }

        /// <summary>
        /// 清关资质等扩展信息
        /// </summary>
        [JsonPropertyName("cc_ext")]
        public string CcExt { get; set; }

        /// <summary>
        /// 国家及地区编码
        /// </summary>
        [JsonPropertyName("cr_code")]
        public string CrCode { get; set; }

        /// <summary>
        /// 国家及地区描述
        /// </summary>
        [JsonPropertyName("cr_desc")]
        public string CrDesc { get; set; }

        /// <summary>
        /// 邮箱
        /// </summary>
        [JsonPropertyName("email")]
        public string Email { get; set; }

        /// <summary>
        /// 物料中文名
        /// </summary>
        [JsonPropertyName("item_alias_name")]
        public string ItemAliasName { get; set; }

        /// <summary>
        /// 物料描述：含材质、用途
        /// </summary>
        [JsonPropertyName("item_desc")]
        public string ItemDesc { get; set; }

        /// <summary>
        /// 物料id
        /// </summary>
        [JsonPropertyName("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 物料英文名
        /// </summary>
        [JsonPropertyName("item_name")]
        public string ItemName { get; set; }

        /// <summary>
        /// 物料份数
        /// </summary>
        [JsonPropertyName("quantity")]
        public long Quantity { get; set; }

        /// <summary>
        /// 收件公司全名
        /// </summary>
        [JsonPropertyName("recipient_entity_name")]
        public string RecipientEntityName { get; set; }

        /// <summary>
        /// 收件人姓名: first name + last name 空格分隔
        /// </summary>
        [JsonPropertyName("recipient_name")]
        public string RecipientName { get; set; }

        /// <summary>
        /// 收件人电话
        /// </summary>
        [JsonPropertyName("recipient_phone")]
        public string RecipientPhone { get; set; }

        /// <summary>
        /// 申报价值单件价
        /// </summary>
        [JsonPropertyName("unit_price")]
        public string UnitPrice { get; set; }

        /// <summary>
        /// 邮编
        /// </summary>
        [JsonPropertyName("zip_code")]
        public string ZipCode { get; set; }
    }
}
