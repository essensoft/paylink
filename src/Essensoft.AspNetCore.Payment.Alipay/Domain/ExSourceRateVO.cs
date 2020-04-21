using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ExSourceRateVO Data Structure.
    /// </summary>
    public class ExSourceRateVO : AlipayObject
    {
        /// <summary>
        /// 买入价
        /// </summary>
        [JsonPropertyName("bid")]
        public string Bid { get; set; }

        /// <summary>
        /// 报价币种对
        /// </summary>
        [JsonPropertyName("currency_pair")]
        public string CurrencyPair { get; set; }

        /// <summary>
        /// 报价单位
        /// </summary>
        [JsonPropertyName("currency_unit")]
        public long CurrencyUnit { get; set; }

        /// <summary>
        /// 价格失效时间
        /// </summary>
        [JsonPropertyName("expiry_time")]
        public string ExpiryTime { get; set; }

        /// <summary>
        /// 扩展字段
        /// </summary>
        [JsonPropertyName("extended_params")]
        public string ExtendedParams { get; set; }

        /// <summary>
        /// 报价生成日期
        /// </summary>
        [JsonPropertyName("generate_date")]
        public string GenerateDate { get; set; }

        /// <summary>
        /// 报价生成时间
        /// </summary>
        [JsonPropertyName("generate_time")]
        public string GenerateTime { get; set; }

        /// <summary>
        /// 创建日期
        /// </summary>
        [JsonPropertyName("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [JsonPropertyName("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 报价是否可成交
        /// </summary>
        [JsonPropertyName("guaranteed")]
        public string Guaranteed { get; set; }

        /// <summary>
        /// 主键id
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// 源汇率机构
        /// </summary>
        [JsonPropertyName("inst")]
        public string Inst { get; set; }

        /// <summary>
        /// 报价源报价ID
        /// </summary>
        [JsonPropertyName("inst_rate_reference_id")]
        public string InstRateReferenceId { get; set; }

        /// <summary>
        /// 是否异常源汇率，Y或者N
        /// </summary>
        [JsonPropertyName("is_exception")]
        public string IsException { get; set; }

        /// <summary>
        /// 是否平盘价
        /// </summary>
        [JsonPropertyName("is_flat")]
        public string IsFlat { get; set; }

        /// <summary>
        /// 是否需要格式化，Y或者N
        /// </summary>
        [JsonPropertyName("is_formatted")]
        public string IsFormatted { get; set; }

        /// <summary>
        /// 汇率是否有效
        /// </summary>
        [JsonPropertyName("is_valid")]
        public string IsValid { get; set; }

        /// <summary>
        /// 远期或掉期点价格到期日
        /// </summary>
        [JsonPropertyName("maturity_date")]
        public string MaturityDate { get; set; }

        /// <summary>
        /// 该价格的最大买入量
        /// </summary>
        [JsonPropertyName("maximum_bid_amount")]
        public long MaximumBidAmount { get; set; }

        /// <summary>
        /// 该价格的最大卖出量
        /// </summary>
        [JsonPropertyName("maximum_offer_amount")]
        public long MaximumOfferAmount { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [JsonPropertyName("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 中间价
        /// </summary>
        [JsonPropertyName("mid")]
        public string Mid { get; set; }

        /// <summary>
        /// 该价格的最小买入量
        /// </summary>
        [JsonPropertyName("minimum_bid_amount")]
        public long MinimumBidAmount { get; set; }

        /// <summary>
        /// 该价格的最小卖出量
        /// </summary>
        [JsonPropertyName("minimum_offer_amount")]
        public long MinimumOfferAmount { get; set; }

        /// <summary>
        /// 卖出价
        /// </summary>
        [JsonPropertyName("offer")]
        public string Offer { get; set; }

        /// <summary>
        /// 在岸/离岸标识:ON/OFF
        /// </summary>
        [JsonPropertyName("on_off_shore")]
        public string OnOffShore { get; set; }

        /// <summary>
        /// 期限(TODAY,TOM,SPOT)
        /// </summary>
        [JsonPropertyName("period")]
        public string Period { get; set; }

        /// <summary>
        /// 业务自定义字段
        /// </summary>
        [JsonPropertyName("profile")]
        public string Profile { get; set; }

        /// <summary>
        /// 价格类型 WHL/RTL
        /// </summary>
        [JsonPropertyName("quote_type")]
        public string QuoteType { get; set; }

        /// <summary>
        /// 报价生成方式，用来区分人工指定报价或者渠道原始报价
        /// </summary>
        [JsonPropertyName("rate_method")]
        public string RateMethod { get; set; }

        /// <summary>
        /// 源汇率编码
        /// </summary>
        [JsonPropertyName("rate_source_code")]
        public string RateSourceCode { get; set; }

        /// <summary>
        /// 产品类型：即期，远期，掉期
        /// </summary>
        [JsonPropertyName("rate_type")]
        public string RateType { get; set; }

        /// <summary>
        /// 端标识号
        /// </summary>
        [JsonPropertyName("segment_id")]
        public string SegmentId { get; set; }

        /// <summary>
        /// 即期买入价
        /// </summary>
        [JsonPropertyName("sp_bid")]
        public string SpBid { get; set; }

        /// <summary>
        /// 即期中间价
        /// </summary>
        [JsonPropertyName("sp_mid")]
        public string SpMid { get; set; }

        /// <summary>
        /// 即期卖出价
        /// </summary>
        [JsonPropertyName("sp_offer")]
        public string SpOffer { get; set; }

        /// <summary>
        /// 价格生效时间
        /// </summary>
        [JsonPropertyName("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 子机构
        /// </summary>
        [JsonPropertyName("sub_inst")]
        public string SubInst { get; set; }

        /// <summary>
        /// 报价缓冲时间
        /// </summary>
        [JsonPropertyName("threshold_time")]
        public string ThresholdTime { get; set; }

        /// <summary>
        /// 最晚用此报价发送交易时间
        /// </summary>
        [JsonPropertyName("valid_time")]
        public string ValidTime { get; set; }

        /// <summary>
        /// 价格失效时间(带时区)
        /// </summary>
        [JsonPropertyName("zone_expiry_time")]
        public string ZoneExpiryTime { get; set; }

        /// <summary>
        /// 报价生成时间(带时区)
        /// </summary>
        [JsonPropertyName("zone_generate_time")]
        public string ZoneGenerateTime { get; set; }

        /// <summary>
        /// 创建日期(带时区)
        /// </summary>
        [JsonPropertyName("zone_gmt_create")]
        public string ZoneGmtCreate { get; set; }

        /// <summary>
        /// 修改时间(带时区)
        /// </summary>
        [JsonPropertyName("zone_gmt_modified")]
        public string ZoneGmtModified { get; set; }

        /// <summary>
        /// 价格生效时间(带时区)
        /// </summary>
        [JsonPropertyName("zone_start_time")]
        public string ZoneStartTime { get; set; }

        /// <summary>
        /// 报价缓冲时间(带时区)
        /// </summary>
        [JsonPropertyName("zone_threshold_time")]
        public string ZoneThresholdTime { get; set; }

        /// <summary>
        /// 最晚用此报价发送交易时间(带时区)
        /// </summary>
        [JsonPropertyName("zone_valid_time")]
        public string ZoneValidTime { get; set; }
    }
}
