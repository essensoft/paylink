using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ExClientRateVO Data Structure.
    /// </summary>
    [Serializable]
    public class ExClientRateVO : AlipayObject
    {
        /// <summary>
        /// 协议编号
        /// </summary>
        [JsonProperty("agreement_id")]
        [XmlElement("agreement_id")]
        public string AgreementId { get; set; }

        /// <summary>
        /// 基准货币。汇率货币单位默认为1，即1货币单位的基础货币，对应非基准货币的价格
        /// </summary>
        [JsonProperty("base_ccy")]
        [XmlElement("base_ccy")]
        public string BaseCcy { get; set; }

        /// <summary>
        /// 买入价格 为交易对手添加了点差后，基准货币的买入价格，直接面向终端客户
        /// </summary>
        [JsonProperty("bid_rate")]
        [XmlElement("bid_rate")]
        public string BidRate { get; set; }

        /// <summary>
        /// 终端客户买入价格 面向交易对手的基准货币买入价格，不包含终端客户点差
        /// </summary>
        [JsonProperty("client_bid_rate")]
        [XmlElement("client_bid_rate")]
        public string ClientBidRate { get; set; }

        /// <summary>
        /// 客户id
        /// </summary>
        [JsonProperty("client_id")]
        [XmlElement("client_id")]
        public string ClientId { get; set; }

        /// <summary>
        /// 终端客户卖出价格 面向交易对手的基准货币卖出价格，不包含终端客户点差
        /// </summary>
        [JsonProperty("client_offer_rate")]
        [XmlElement("client_offer_rate")]
        public string ClientOfferRate { get; set; }

        /// <summary>
        /// 基准货币/非基准货币
        /// </summary>
        [JsonProperty("currency_pair")]
        [XmlElement("currency_pair")]
        public string CurrencyPair { get; set; }

        /// <summary>
        /// 汇率的失效时间
        /// </summary>
        [JsonProperty("expiry_time")]
        [XmlElement("expiry_time")]
        public string ExpiryTime { get; set; }

        /// <summary>
        /// 汇率生成日期,yyyymmdd
        /// </summary>
        [JsonProperty("generate_date")]
        [XmlElement("generate_date")]
        public string GenerateDate { get; set; }

        /// <summary>
        /// 汇率生成时间 与rateTime一致
        /// </summary>
        [JsonProperty("generate_time")]
        [XmlElement("generate_time")]
        public string GenerateTime { get; set; }

        /// <summary>
        /// 字典：T - 可交易，F - 仅作为参考，不可交易
        /// </summary>
        [JsonProperty("guaranteed")]
        [XmlElement("guaranteed")]
        public string Guaranteed { get; set; }

        /// <summary>
        /// 远期或者掉期点价格到期日, yyyymmdd
        /// </summary>
        [JsonProperty("maturity_date")]
        [XmlElement("maturity_date")]
        public string MaturityDate { get; set; }

        /// <summary>
        /// 基准货币买入的最大金额，对于单笔、累计交易
        /// </summary>
        [JsonProperty("maximum_bid_amount")]
        [XmlElement("maximum_bid_amount")]
        public long MaximumBidAmount { get; set; }

        /// <summary>
        /// 基准货币卖出的最大金额，对于单笔、累计交易
        /// </summary>
        [JsonProperty("maximum_offer_amount")]
        [XmlElement("maximum_offer_amount")]
        public long MaximumOfferAmount { get; set; }

        /// <summary>
        /// 汇率中间价
        /// </summary>
        [JsonProperty("mid_rate")]
        [XmlElement("mid_rate")]
        public string MidRate { get; set; }

        /// <summary>
        /// 基准货币买入的最小金额，对于单笔交易
        /// </summary>
        [JsonProperty("minimum_bid_amount")]
        [XmlElement("minimum_bid_amount")]
        public string MinimumBidAmount { get; set; }

        /// <summary>
        /// 基准货币卖出的最小金额，对于单笔交易
        /// </summary>
        [JsonProperty("minimum_offer_amount")]
        [XmlElement("minimum_offer_amount")]
        public string MinimumOfferAmount { get; set; }

        /// <summary>
        /// 卖出价格 添加了交易对手点差后，基准货币的卖出价格，直接面向终端客户
        /// </summary>
        [JsonProperty("offer_rate")]
        [XmlElement("offer_rate")]
        public string OfferRate { get; set; }

        /// <summary>
        /// 在岸离岸标识 ON - 在岸，OFF - 离岸
        /// </summary>
        [JsonProperty("on_off_shore")]
        [XmlElement("on_off_shore")]
        public string OnOffShore { get; set; }

        /// <summary>
        /// 该汇率的来源机构
        /// </summary>
        [JsonProperty("origin_rate_inst")]
        [XmlElement("origin_rate_inst")]
        public string OriginRateInst { get; set; }

        /// <summary>
        /// 原始汇率来源机构，对该汇率的唯一标识
        /// </summary>
        [JsonProperty("origin_rate_ref")]
        [XmlElement("origin_rate_ref")]
        public string OriginRateRef { get; set; }

        /// <summary>
        /// 汇率期限 字典：TODAY, TOMORROW, SPOT, O/N, T/N等标准期限
        /// </summary>
        [JsonProperty("period")]
        [XmlElement("period")]
        public string Period { get; set; }

        /// <summary>
        /// 子协议扩展号 对不同商户/渠道的报价协议
        /// </summary>
        [JsonProperty("profile_id")]
        [XmlElement("profile_id")]
        public string ProfileId { get; set; }

        /// <summary>
        /// 非基准货币
        /// </summary>
        [JsonProperty("quote_ccy")]
        [XmlElement("quote_ccy")]
        public string QuoteCcy { get; set; }

        /// <summary>
        /// 标识单一货币对，每次汇率生成时变化，不重复
        /// </summary>
        [JsonProperty("rate_ref")]
        [XmlElement("rate_ref")]
        public string RateRef { get; set; }

        /// <summary>
        /// 汇率发布时间
        /// </summary>
        [JsonProperty("rate_time")]
        [XmlElement("rate_time")]
        public string RateTime { get; set; }

        /// <summary>
        /// 字典: SPOT - 即期，FORWORD - 远期，SWAP - 掉期点
        /// </summary>
        [JsonProperty("rate_type")]
        [XmlElement("rate_type")]
        public string RateType { get; set; }

        /// <summary>
        /// 汇率类型为远期下，即期的买入价
        /// </summary>
        [JsonProperty("sp_bid")]
        [XmlElement("sp_bid")]
        public string SpBid { get; set; }

        /// <summary>
        /// 汇率类型为远期下，即期的中间价
        /// </summary>
        [JsonProperty("sp_mid")]
        [XmlElement("sp_mid")]
        public string SpMid { get; set; }

        /// <summary>
        /// 汇率类型为远期下，即期的卖出价
        /// </summary>
        [JsonProperty("sp_offer")]
        [XmlElement("sp_offer")]
        public string SpOffer { get; set; }

        /// <summary>
        /// 报价中心内部标准产品编码
        /// </summary>
        [JsonProperty("standard_product_rate_id")]
        [XmlElement("standard_product_rate_id")]
        public string StandardProductRateId { get; set; }

        /// <summary>
        /// 汇率的有效时间
        /// </summary>
        [JsonProperty("start_time")]
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 子协议id
        /// </summary>
        [JsonProperty("sub_agreement_id")]
        [XmlElement("sub_agreement_id")]
        public string SubAgreementId { get; set; }

        /// <summary>
        /// 锁定汇率模式下，在新旧汇率交替时，仍可以使用旧汇率下单的最外时间
        /// </summary>
        [JsonProperty("threshold_time")]
        [XmlElement("threshold_time")]
        public string ThresholdTime { get; set; }

        /// <summary>
        /// 时间所在的时区
        /// </summary>
        [JsonProperty("time_zone")]
        [XmlElement("time_zone")]
        public string TimeZone { get; set; }

        /// <summary>
        /// 交易货币类型 字典: DELIV - 原币交割，NDF - 非原币交割
        /// </summary>
        [JsonProperty("transaction_ccy_type")]
        [XmlElement("transaction_ccy_type")]
        public string TransactionCcyType { get; set; }

        /// <summary>
        /// 保价过期时间
        /// </summary>
        [JsonProperty("valid_time")]
        [XmlElement("valid_time")]
        public string ValidTime { get; set; }
    }
}
