using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// EinvTrade Data Structure.
    /// </summary>
    public class EinvTrade : AlipayObject
    {
        /// <summary>
        /// 订单编号
        /// </summary>
        [JsonPropertyName("bill_no")]
        public string BillNo { get; set; }

        /// <summary>
        /// 下单时间
        /// </summary>
        [JsonPropertyName("bill_time")]
        public string BillTime { get; set; }

        /// <summary>
        /// 商户所在城市(经营地址)
        /// </summary>
        [JsonPropertyName("city_name")]
        public string CityName { get; set; }

        /// <summary>
        /// 账单明细信息，酒店水单信息，行程单信息，餐饮小票信息
        /// </summary>
        [JsonPropertyName("detail_json")]
        public string DetailJson { get; set; }

        /// <summary>
        /// 账单明细信息，酒店水单，行程单，餐饮小票等pdf原件链接
        /// </summary>
        [JsonPropertyName("download_url")]
        public string DownloadUrl { get; set; }

        /// <summary>
        /// 扩展参数  不同组的k-v通过换行符区分
        /// </summary>
        [JsonPropertyName("extend_map")]
        public string ExtendMap { get; set; }

        /// <summary>
        /// 商家名称（显示名称，非企业名称，餐饮店、酒店、打车平台名称）
        /// </summary>
        [JsonPropertyName("merchant_name")]
        public string MerchantName { get; set; }

        /// <summary>
        /// 透传字段，不做处理，用于isv向后续报销税控方传递特殊信息标记
        /// </summary>
        [JsonPropertyName("out_json")]
        public string OutJson { get; set; }

        /// <summary>
        /// 销方名称
        /// </summary>
        [JsonPropertyName("payee_name")]
        public string PayeeName { get; set; }

        /// <summary>
        /// 支付金额  对应账单中的交易金额
        /// </summary>
        [JsonPropertyName("payment_amount")]
        public string PaymentAmount { get; set; }

        /// <summary>
        /// 支付时间  对应账单中的账单日期
        /// </summary>
        [JsonPropertyName("payment_time")]
        public string PaymentTime { get; set; }

        /// <summary>
        /// 交易类型来源 需要按照枚举映射  consume 账单  hotel 酒店水单  itinerary 打车行程单  catering 餐饮小票
        /// </summary>
        [JsonPropertyName("souce")]
        public string Souce { get; set; }

        /// <summary>
        /// 交易类型/账单分类
        /// </summary>
        [JsonPropertyName("trade_type")]
        public string TradeType { get; set; }
    }
}
