using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// QueryResult Data Structure.
    /// </summary>
    [Serializable]
    public class QueryResult : AlipayObject
    {
        /// <summary>
        /// 支付宝车型库品牌背景图片链接地址，  query_type参数的值为brands时此参数必填；query_type参数的值为series,models，company时不返回
        /// </summary>
        [JsonProperty("background_url")]
        public string BackgroundUrl { get; set; }

        /// <summary>
        /// 支付宝车型库品牌编号query_type参数的值为brands，models时此参数必填；query_type参数的值为series，company时不返回，系统唯一
        /// </summary>
        [JsonProperty("brand_id")]
        public string BrandId { get; set; }

        /// <summary>
        /// 支付宝车型库品牌名称query_type参数的值为brands， models时此参数必填；query_type参数的值为series，company时不返回
        /// </summary>
        [JsonProperty("brand_name")]
        public string BrandName { get; set; }

        /// <summary>
        /// 支付宝车型库排量，query_type参数的值为models时此参数必填, query_type参数的值为series，company, brands时此参数不返回
        /// </summary>
        [JsonProperty("cc")]
        public string Cc { get; set; }

        /// <summary>
        /// 支付宝车型库厂商编号，query_type参数的值为series， models，company时此参数必填；query_type参数的值为brands时不返回，系统唯一
        /// </summary>
        [JsonProperty("company_id")]
        public string CompanyId { get; set; }

        /// <summary>
        /// 支付宝车型库厂商名称，query_type参数的值为series， models，company时此参数必填，query_type参数的值为brands时此参数不返回
        /// </summary>
        [JsonProperty("company_name")]
        public string CompanyName { get; set; }

        /// <summary>
        /// 支付宝车型库发动机号，query_type参数的值为models时此参数必填, query_type参数的值为series，company, brands时此参数不返回
        /// </summary>
        [JsonProperty("engine")]
        public string Engine { get; set; }

        /// <summary>
        /// 支付宝车型库品牌logo图片链接地址，  query_type参数的值为brands时此参数必填；query_type参数的值为series,models，company时不返回
        /// </summary>
        [JsonProperty("logo_url")]
        public string LogoUrl { get; set; }

        /// <summary>
        /// 支付宝车型库车型编号，query_type参数的值为models时此参数必填，query_type参数的值为series，company, brands时此参数不返回，系统唯一
        /// </summary>
        [JsonProperty("model_id")]
        public string ModelId { get; set; }

        /// <summary>
        /// 支付宝车型库车型名称，query_type参数的值为models时此参数必填, query_type参数的值为series，company, brands时此参数不返回
        /// </summary>
        [JsonProperty("model_name")]
        public string ModelName { get; set; }

        /// <summary>
        /// 支付宝车型库生产年限，query_type参数的值为models时此参数必填, query_type参数的值为series，company, brands时此参数不返回
        /// </summary>
        [JsonProperty("prod_year")]
        public string ProdYear { get; set; }

        /// <summary>
        /// 支付宝车型库车系组别，query_type参数的值为series时此参数必填，query_type参数的值为brands， models时此参数不返回
        /// </summary>
        [JsonProperty("serie_group")]
        public string SerieGroup { get; set; }

        /// <summary>
        /// 支付宝车型库车系编号query_type参数的值为series，models，company时此参数必填；query_type参数的值为brands时不返回，系统唯一
        /// </summary>
        [JsonProperty("serie_id")]
        public string SerieId { get; set; }

        /// <summary>
        /// 支付宝车型库车系名称，query_type参数的值为series，models时此参数必填；query_type参数的值为brands时不返回
        /// </summary>
        [JsonProperty("serie_name")]
        public string SerieName { get; set; }

        /// <summary>
        /// 支付宝车型库车系图片连接地址，  query_type参数的值为series时此参数必填；query_type参数的值为brands,models时不返回
        /// </summary>
        [JsonProperty("serie_photo")]
        public string SeriePhoto { get; set; }

        /// <summary>
        /// 支付宝车型库年款，query_type参数的值为models时此参数必填, query_type参数的值为series，company, brands时此参数不返回
        /// </summary>
        [JsonProperty("style")]
        public string Style { get; set; }
    }
}
