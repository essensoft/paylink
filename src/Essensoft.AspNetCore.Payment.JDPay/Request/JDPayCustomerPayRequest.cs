using System.Collections.Generic;

namespace Essensoft.AspNetCore.Payment.JDPay.Request
{
    /// <summary>
    /// 商户二维码支付接口
    /// </summary>
    public class JDPayCustomerPayRequest : IJDPayRequest<JDPayResponse>
    {
        /// <summary>
        /// 收款商户
        /// </summary>
        public string PayMerchant { get; set; }

        /// <summary>
        /// 门店号
        /// </summary>
        public string Device { get; set; }

        /// <summary>
        /// 交易流水号
        /// </summary>
        public string TradeNum { get; set; }

        /// <summary>
        /// 交易名称
        /// </summary>
        public string TradeName { get; set; }

        /// <summary>
        /// 交易描述
        /// </summary>
        public string TradeDesc { get; set; }

        /// <summary>
        /// 交易时间
        /// </summary>
        public string TradeTime { get; set; }

        /// <summary>
        /// 交易金额
        /// </summary>
        public string Amount { get; set; }

        /// <summary>
        /// 订单类型
        /// </summary>
        public string OrderType { get; set; }

        /// <summary>
        /// 业务类型
        /// </summary>
        public string IndustryCategoryCode { get; set; }

        /// <summary>
        /// 货币种类
        /// </summary>
        public string Currency { get; set; }


        /// <summary>
        /// 交易类型
        /// </summary>
        public string TradeType { get; set; }

        /// <summary>
        /// 商户备注
        /// </summary>
        public string Note { get; set; }

        /// <summary>
        /// 支付成功跳转路径
        /// </summary>
        public string CallbackUrl { get; set; }

        /// <summary>
        /// 异步通知页面地址
        /// </summary>
        public string NotifyUrl { get; set; }

        /// <summary>
        /// 用户IP
        /// </summary>
        public string Ip { get; set; }

        /// <summary>
        /// 订单失效时长
        /// </summary>
        public string ExpireTime { get; set; }

        /// <summary>
        /// 风控信息
        /// </summary>
        public string RiskInfo { get; set; }

        #region IJDPayRequest Members

        private string ApiVersion = "V2.0";

        public string GetRequestUrl()
        {
            return "https://h5pay.jd.com/jdpay/customerPay";
        }

        public void SetApiVersion(string apiVersion)
        {
            ApiVersion = apiVersion;
        }

        public string GetApiVersion()
        {
            return ApiVersion;
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new JDPayDictionary()
            {
                { "payMerchant", PayMerchant },
                { "device", Device},
                { "tradeNum",TradeNum },
                { "tradeName", TradeName},
                { "tradeDesc", TradeDesc },
                { "tradeTime", TradeTime },
                { "amount", Amount },
                { "orderType", OrderType },
                { "industryCategoryCode", IndustryCategoryCode },
                { "currency", Currency },
                { "tradeType", TradeType },
                { "note", Note },
                { "callbackUrl", CallbackUrl},
                { "notifyUrl", NotifyUrl },
                { "ip", Ip },
                { "riskInfo", RiskInfo },
            };
            return parameters;
        }

        #endregion
    }
}
