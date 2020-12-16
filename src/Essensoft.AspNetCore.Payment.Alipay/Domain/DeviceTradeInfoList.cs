using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// DeviceTradeInfoList Data Structure.
    /// </summary>
    public class DeviceTradeInfoList : AlipayObject
    {
        /// <summary>
        /// 设备id
        /// </summary>
        [JsonPropertyName("biz_tid")]
        public string BizTid { get; set; }

        /// <summary>
        /// DAU
        /// </summary>
        [JsonPropertyName("dau")]
        public long Dau { get; set; }

        /// <summary>
        /// 刷脸DAU
        /// </summary>
        [JsonPropertyName("device_face_trade_dau")]
        public long DeviceFaceTradeDau { get; set; }

        /// <summary>
        /// 设备名称
        /// </summary>
        [JsonPropertyName("device_name")]
        public string DeviceName { get; set; }

        /// <summary>
        /// 设备序列号
        /// </summary>
        [JsonPropertyName("device_sn")]
        public string DeviceSn { get; set; }

        /// <summary>
        /// 设备激活状态
        /// </summary>
        [JsonPropertyName("device_status")]
        public string DeviceStatus { get; set; }

        /// <summary>
        /// 扫脸交易笔数
        /// </summary>
        [JsonPropertyName("face_trade_cnt")]
        public long FaceTradeCnt { get; set; }

        /// <summary>
        /// 激活时间
        /// </summary>
        [JsonPropertyName("gmt_active")]
        public string GmtActive { get; set; }

        /// <summary>
        /// 统计时间
        /// </summary>
        [JsonPropertyName("max_dt")]
        public string MaxDt { get; set; }

        /// <summary>
        /// 商家pid
        /// </summary>
        [JsonPropertyName("merchant_pid")]
        public string MerchantPid { get; set; }

        /// <summary>
        /// 门店信息
        /// </summary>
        [JsonPropertyName("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 交易金额
        /// </summary>
        [JsonPropertyName("trade_amt")]
        public string TradeAmt { get; set; }

        /// <summary>
        /// 交易笔数
        /// </summary>
        [JsonPropertyName("trade_cnt")]
        public long TradeCnt { get; set; }
    }
}
