using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayPcreditHuabeiSelleradmitRealtimeCertifyModel Data Structure.
    /// </summary>
    public class AlipayPcreditHuabeiSelleradmitRealtimeCertifyModel : AlipayObject
    {
        /// <summary>
        /// 支付宝id
        /// </summary>
        [JsonPropertyName("alipay_id")]
        public string AlipayId { get; set; }

        /// <summary>
        /// 请求来源应用名
        /// </summary>
        [JsonPropertyName("from_app")]
        public string FromApp { get; set; }

        /// <summary>
        /// 店铺所属行业
        /// </summary>
        [JsonPropertyName("industry")]
        public string Industry { get; set; }

        /// <summary>
        /// 店铺主营类目，多个逗号分隔
        /// </summary>
        [JsonPropertyName("main_category")]
        public string MainCategory { get; set; }

        /// <summary>
        /// 卖家店铺归属平台
        /// </summary>
        [JsonPropertyName("platform")]
        public string Platform { get; set; }

        /// <summary>
        /// 卖家准入场景
        /// </summary>
        [JsonPropertyName("seller_admit_scene")]
        public string SellerAdmitScene { get; set; }

        /// <summary>
        /// 卖家店铺id
        /// </summary>
        [JsonPropertyName("seller_id")]
        public string SellerId { get; set; }
    }
}
