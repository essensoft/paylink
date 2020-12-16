using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// SnapshotDTO Data Structure.
    /// </summary>
    public class SnapshotDTO : AlipayObject
    {
        /// <summary>
        /// 盘后竞价成交量
        /// </summary>
        [JsonPropertyName("after_market_amount")]
        public string AfterMarketAmount { get; set; }

        /// <summary>
        /// 盘后竞价买入申报数量,当前未成交的买入申报总股数
        /// </summary>
        [JsonPropertyName("after_market_buy_volume")]
        public string AfterMarketBuyVolume { get; set; }

        /// <summary>
        /// 盘后竞价价格
        /// </summary>
        [JsonPropertyName("after_market_price")]
        public string AfterMarketPrice { get; set; }

        /// <summary>
        /// 盘后竞价卖出申报数量,当前未成交的卖出申报总股数
        /// </summary>
        [JsonPropertyName("after_market_sell_volume")]
        public string AfterMarketSellVolume { get; set; }

        /// <summary>
        /// 盘后竞价最后交易时间
        /// </summary>
        [JsonPropertyName("after_market_trade_time")]
        public string AfterMarketTradeTime { get; set; }

        /// <summary>
        /// 盘后竞价交易状态,参考枚举 AfterMarketTradingPhase
        /// </summary>
        [JsonPropertyName("after_market_trading_phase")]
        public string AfterMarketTradingPhase { get; set; }

        /// <summary>
        /// 盘后竞价成交额
        /// </summary>
        [JsonPropertyName("after_market_volume")]
        public string AfterMarketVolume { get; set; }

        /// <summary>
        /// 成交额
        /// </summary>
        [JsonPropertyName("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 卖出1价
        /// </summary>
        [JsonPropertyName("ask_price_1")]
        public string AskPrice1 { get; set; }

        /// <summary>
        /// 卖出10价
        /// </summary>
        [JsonPropertyName("ask_price_10")]
        public string AskPrice10 { get; set; }

        /// <summary>
        /// 卖出2价
        /// </summary>
        [JsonPropertyName("ask_price_2")]
        public string AskPrice2 { get; set; }

        /// <summary>
        /// 卖出3价
        /// </summary>
        [JsonPropertyName("ask_price_3")]
        public string AskPrice3 { get; set; }

        /// <summary>
        /// 卖出4价
        /// </summary>
        [JsonPropertyName("ask_price_4")]
        public string AskPrice4 { get; set; }

        /// <summary>
        /// 卖出5价
        /// </summary>
        [JsonPropertyName("ask_price_5")]
        public string AskPrice5 { get; set; }

        /// <summary>
        /// 卖出6价
        /// </summary>
        [JsonPropertyName("ask_price_6")]
        public string AskPrice6 { get; set; }

        /// <summary>
        /// 卖出7价
        /// </summary>
        [JsonPropertyName("ask_price_7")]
        public string AskPrice7 { get; set; }

        /// <summary>
        /// 卖出8价
        /// </summary>
        [JsonPropertyName("ask_price_8")]
        public string AskPrice8 { get; set; }

        /// <summary>
        /// 卖出9价
        /// </summary>
        [JsonPropertyName("ask_price_9")]
        public string AskPrice9 { get; set; }

        /// <summary>
        /// 卖出1量
        /// </summary>
        [JsonPropertyName("ask_volume_1")]
        public string AskVolume1 { get; set; }

        /// <summary>
        /// 卖出10量
        /// </summary>
        [JsonPropertyName("ask_volume_10")]
        public string AskVolume10 { get; set; }

        /// <summary>
        /// 卖出2量
        /// </summary>
        [JsonPropertyName("ask_volume_2")]
        public string AskVolume2 { get; set; }

        /// <summary>
        /// 卖出3量
        /// </summary>
        [JsonPropertyName("ask_volume_3")]
        public string AskVolume3 { get; set; }

        /// <summary>
        /// 卖出4量
        /// </summary>
        [JsonPropertyName("ask_volume_4")]
        public string AskVolume4 { get; set; }

        /// <summary>
        /// 卖出5量
        /// </summary>
        [JsonPropertyName("ask_volume_5")]
        public string AskVolume5 { get; set; }

        /// <summary>
        /// 卖出6量
        /// </summary>
        [JsonPropertyName("ask_volume_6")]
        public string AskVolume6 { get; set; }

        /// <summary>
        /// 卖出7量
        /// </summary>
        [JsonPropertyName("ask_volume_7")]
        public string AskVolume7 { get; set; }

        /// <summary>
        /// 卖出8量
        /// </summary>
        [JsonPropertyName("ask_volume_8")]
        public string AskVolume8 { get; set; }

        /// <summary>
        /// 卖出9量
        /// </summary>
        [JsonPropertyName("ask_volume_9")]
        public string AskVolume9 { get; set; }

        /// <summary>
        /// 买入1价
        /// </summary>
        [JsonPropertyName("bid_price_1")]
        public string BidPrice1 { get; set; }

        /// <summary>
        /// 买入10价
        /// </summary>
        [JsonPropertyName("bid_price_10")]
        public string BidPrice10 { get; set; }

        /// <summary>
        /// 卖入2价
        /// </summary>
        [JsonPropertyName("bid_price_2")]
        public string BidPrice2 { get; set; }

        /// <summary>
        /// 卖入3价
        /// </summary>
        [JsonPropertyName("bid_price_3")]
        public string BidPrice3 { get; set; }

        /// <summary>
        /// 买入4价
        /// </summary>
        [JsonPropertyName("bid_price_4")]
        public string BidPrice4 { get; set; }

        /// <summary>
        /// 买入5价
        /// </summary>
        [JsonPropertyName("bid_price_5")]
        public string BidPrice5 { get; set; }

        /// <summary>
        /// 买入6价
        /// </summary>
        [JsonPropertyName("bid_price_6")]
        public string BidPrice6 { get; set; }

        /// <summary>
        /// 买入7价
        /// </summary>
        [JsonPropertyName("bid_price_7")]
        public string BidPrice7 { get; set; }

        /// <summary>
        /// 买入8价
        /// </summary>
        [JsonPropertyName("bid_price_8")]
        public string BidPrice8 { get; set; }

        /// <summary>
        /// 买入9价
        /// </summary>
        [JsonPropertyName("bid_price_9")]
        public string BidPrice9 { get; set; }

        /// <summary>
        /// 买入1量
        /// </summary>
        [JsonPropertyName("bid_volume_1")]
        public string BidVolume1 { get; set; }

        /// <summary>
        /// 买入10量
        /// </summary>
        [JsonPropertyName("bid_volume_10")]
        public string BidVolume10 { get; set; }

        /// <summary>
        /// 买入2量
        /// </summary>
        [JsonPropertyName("bid_volume_2")]
        public string BidVolume2 { get; set; }

        /// <summary>
        /// 买入3量
        /// </summary>
        [JsonPropertyName("bid_volume_3")]
        public string BidVolume3 { get; set; }

        /// <summary>
        /// 买入4量
        /// </summary>
        [JsonPropertyName("bid_volume_4")]
        public string BidVolume4 { get; set; }

        /// <summary>
        /// 买入5量
        /// </summary>
        [JsonPropertyName("bid_volume_5")]
        public string BidVolume5 { get; set; }

        /// <summary>
        /// 买入6量
        /// </summary>
        [JsonPropertyName("bid_volume_6")]
        public string BidVolume6 { get; set; }

        /// <summary>
        /// 买入7量
        /// </summary>
        [JsonPropertyName("bid_volume_7")]
        public string BidVolume7 { get; set; }

        /// <summary>
        /// 买入8量
        /// </summary>
        [JsonPropertyName("bid_volume_8")]
        public string BidVolume8 { get; set; }

        /// <summary>
        /// 买入9量
        /// </summary>
        [JsonPropertyName("bid_volume_9")]
        public string BidVolume9 { get; set; }

        /// <summary>
        /// 涨跌幅
        /// </summary>
        [JsonPropertyName("change_percent")]
        public string ChangePercent { get; set; }

        /// <summary>
        /// 涨跌额
        /// </summary>
        [JsonPropertyName("change_price")]
        public string ChangePrice { get; set; }

        /// <summary>
        /// 收盘价
        /// </summary>
        [JsonPropertyName("close_price")]
        public string ClosePrice { get; set; }

        /// <summary>
        /// 最后交易的时间戳
        /// </summary>
        [JsonPropertyName("date")]
        public string Date { get; set; }

        /// <summary>
        /// 跌停价
        /// </summary>
        [JsonPropertyName("down_price")]
        public string DownPrice { get; set; }

        /// <summary>
        /// 最高价
        /// </summary>
        [JsonPropertyName("high_price")]
        public string HighPrice { get; set; }

        /// <summary>
        /// 最低价
        /// </summary>
        [JsonPropertyName("low_price")]
        public string LowPrice { get; set; }

        /// <summary>
        /// 股票名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 开盘价
        /// </summary>
        [JsonPropertyName("open_price")]
        public string OpenPrice { get; set; }

        /// <summary>
        /// 昨收价
        /// </summary>
        [JsonPropertyName("previous_close")]
        public string PreviousClose { get; set; }

        /// <summary>
        /// 当前价
        /// </summary>
        [JsonPropertyName("price")]
        public string Price { get; set; }

        /// <summary>
        /// 停牌状态，未停牌(SP_NO)
        /// </summary>
        [JsonPropertyName("suspension_state")]
        public string SuspensionState { get; set; }

        /// <summary>
        /// 股票唯一代码，symbol=code.market
        /// </summary>
        [JsonPropertyName("symbol")]
        public string Symbol { get; set; }

        /// <summary>
        /// 交易状态
        /// </summary>
        [JsonPropertyName("trade_state")]
        public string TradeState { get; set; }

        /// <summary>
        /// 涨停价
        /// </summary>
        [JsonPropertyName("up_price")]
        public string UpPrice { get; set; }

        /// <summary>
        /// 成交量
        /// </summary>
        [JsonPropertyName("volume")]
        public string Volume { get; set; }
    }
}
