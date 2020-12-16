using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// InvoiceOrderDTO Data Structure.
    /// </summary>
    public class InvoiceOrderDTO : AlipayObject
    {
        /// <summary>
        /// 商品code
        /// </summary>
        [JsonPropertyName("article_code")]
        public string ArticleCode { get; set; }

        /// <summary>
        /// 商品原价，单位元，最多2位小数
        /// </summary>
        [JsonPropertyName("article_fee")]
        public string ArticleFee { get; set; }

        /// <summary>
        /// 商品ID
        /// </summary>
        [JsonPropertyName("article_id")]
        public string ArticleId { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [JsonPropertyName("article_name")]
        public string ArticleName { get; set; }

        /// <summary>
        /// 订购时间，格式yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonPropertyName("buy_date")]
        public string BuyDate { get; set; }

        /// <summary>
        /// 拓展字段，json格式
        /// </summary>
        [JsonPropertyName("ext_json")]
        public string ExtJson { get; set; }

        /// <summary>
        /// 实付总金额，单位元，最多2位小数
        /// </summary>
        [JsonPropertyName("fact_total_fee")]
        public string FactTotalFee { get; set; }

        /// <summary>
        /// 商品规格CODE
        /// </summary>
        [JsonPropertyName("item_code")]
        public string ItemCode { get; set; }

        /// <summary>
        /// 商品规格ID
        /// </summary>
        [JsonPropertyName("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 商品规格名称
        /// </summary>
        [JsonPropertyName("item_name")]
        public string ItemName { get; set; }

        /// <summary>
        /// 服务市场订单号
        /// </summary>
        [JsonPropertyName("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 订购类型，可选值： 新订购：new， 续费：renew，线下转线上：online
        /// </summary>
        [JsonPropertyName("order_type")]
        public string OrderType { get; set; }
    }
}
