using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// PosDishCookModel Data Structure.
    /// </summary>
    public class PosDishCookModel : AlipayObject
    {
        /// <summary>
        /// 渠道    eatin堂食，takeout外卖,paipai 扫码,kbb2c 口碑点餐
        /// </summary>
        [JsonPropertyName("cook_channel")]
        public string CookChannel { get; set; }

        /// <summary>
        /// 菜谱ID
        /// </summary>
        [JsonPropertyName("cook_id")]
        public string CookId { get; set; }

        /// <summary>
        /// 菜谱名称
        /// </summary>
        [JsonPropertyName("cook_name")]
        public string CookName { get; set; }

        /// <summary>
        /// 操作员
        /// </summary>
        [JsonPropertyName("create_user")]
        public string CreateUser { get; set; }

        /// <summary>
        /// 数据的创建时间
        /// </summary>
        [JsonPropertyName("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 数据的修改时间
        /// </summary>
        [JsonPropertyName("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 商户id
        /// </summary>
        [JsonPropertyName("merchant_id")]
        public string MerchantId { get; set; }

        /// <summary>
        /// 菜谱描述
        /// </summary>
        [JsonPropertyName("remarks")]
        public string Remarks { get; set; }

        /// <summary>
        /// 门店ID
        /// </summary>
        [JsonPropertyName("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// yazuo,meituan,ele
        /// </summary>
        [JsonPropertyName("source_from")]
        public string SourceFrom { get; set; }

        /// <summary>
        /// open 启动 stop 停用
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
