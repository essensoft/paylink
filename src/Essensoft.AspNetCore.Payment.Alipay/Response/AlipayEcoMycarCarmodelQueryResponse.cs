using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayEcoMycarCarmodelQueryResponse.
    /// </summary>
    public class AlipayEcoMycarCarmodelQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 支付宝车型库品牌背景图片链接地址
        /// </summary>
        [JsonPropertyName("background_url")]
        public string BackgroundUrl { get; set; }

        /// <summary>
        /// 支付宝车型库品牌编号（系统唯一）
        /// </summary>
        [JsonPropertyName("brand_id")]
        public string BrandId { get; set; }

        /// <summary>
        /// 支付宝车型库品牌名称
        /// </summary>
        [JsonPropertyName("brand_name")]
        public string BrandName { get; set; }

        /// <summary>
        /// 支付宝车型库车型排量
        /// </summary>
        [JsonPropertyName("cc")]
        public string Cc { get; set; }

        /// <summary>
        /// 支付宝车型库厂商编号（系统唯一）
        /// </summary>
        [JsonPropertyName("company_id")]
        public string CompanyId { get; set; }

        /// <summary>
        /// 支付宝车型库厂商名称
        /// </summary>
        [JsonPropertyName("company_name")]
        public string CompanyName { get; set; }

        /// <summary>
        /// 支付宝车型库车型发动机号
        /// </summary>
        [JsonPropertyName("engine")]
        public string Engine { get; set; }

        /// <summary>
        /// 支付宝车型库品牌logo图片链接地址
        /// </summary>
        [JsonPropertyName("logo_url")]
        public string LogoUrl { get; set; }

        /// <summary>
        /// 支付宝车型库车型编号（系统唯一）
        /// </summary>
        [JsonPropertyName("model_id")]
        public string ModelId { get; set; }

        /// <summary>
        /// 支付宝车型库车型名称
        /// </summary>
        [JsonPropertyName("model_name")]
        public string ModelName { get; set; }

        /// <summary>
        /// 支付宝车型库车型生产年限
        /// </summary>
        [JsonPropertyName("prod_year")]
        public string ProdYear { get; set; }

        /// <summary>
        /// 支付宝车型库车系编号（系统唯一）
        /// </summary>
        [JsonPropertyName("serie_id")]
        public string SerieId { get; set; }

        /// <summary>
        /// 支付宝车型库车系名称
        /// </summary>
        [JsonPropertyName("serie_name")]
        public string SerieName { get; set; }

        /// <summary>
        /// 支付宝车型库车系图片连接地址
        /// </summary>
        [JsonPropertyName("serie_photo")]
        public string SeriePhoto { get; set; }

        /// <summary>
        /// 支付宝车型库车型年款
        /// </summary>
        [JsonPropertyName("style")]
        public string Style { get; set; }
    }
}
