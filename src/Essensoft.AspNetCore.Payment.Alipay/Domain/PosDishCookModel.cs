using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// PosDishCookModel Data Structure.
    /// </summary>
    [Serializable]
    public class PosDishCookModel : AlipayObject
    {
        /// <summary>
        /// 渠道    eatin堂食，takeout外卖,paipai 扫码,kbb2c 口碑点餐
        /// </summary>
        [JsonProperty("cook_channel")]
        public string CookChannel { get; set; }

        /// <summary>
        /// 菜谱ID
        /// </summary>
        [JsonProperty("cook_id")]
        public string CookId { get; set; }

        /// <summary>
        /// 菜谱名称
        /// </summary>
        [JsonProperty("cook_name")]
        public string CookName { get; set; }

        /// <summary>
        /// 操作员
        /// </summary>
        [JsonProperty("create_user")]
        public string CreateUser { get; set; }

        /// <summary>
        /// 数据的创建时间
        /// </summary>
        [JsonProperty("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 数据的修改时间
        /// </summary>
        [JsonProperty("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 商户id
        /// </summary>
        [JsonProperty("merchant_id")]
        public string MerchantId { get; set; }

        /// <summary>
        /// 菜谱描述
        /// </summary>
        [JsonProperty("remarks")]
        public string Remarks { get; set; }

        /// <summary>
        /// 门店ID
        /// </summary>
        [JsonProperty("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// yazuo,meituan,ele
        /// </summary>
        [JsonProperty("source_from")]
        public string SourceFrom { get; set; }

        /// <summary>
        /// open 启动 stop 停用
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
