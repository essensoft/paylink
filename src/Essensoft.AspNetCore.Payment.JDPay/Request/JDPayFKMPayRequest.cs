using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.JDPay.Response;

namespace Essensoft.AspNetCore.Payment.JDPay.Request
{
    /// <summary>
    /// 付款码支付接口
    /// </summary>
    public class JDPayFKMPayRequest : IJDPayRequest<JDPayFKMPayResponse>
    {
        /// <summary>
        /// 付款码
        /// </summary>
        public string Token { get; set; }

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
        /// 业务类型
        /// </summary>
        public string IndustryCategoryCode { get; set; }

        /// <summary>
        /// 货币种类
        /// </summary>
        public string Currency { get; set; }

        /// <summary>
        /// 商户备注
        /// </summary>
        public string Note { get; set; }

        /// <summary>
        /// 异步通知页面地址
        /// </summary>
        public string NotifyUrl { get; set; }

        /// <summary>
        /// 订单商品数量
        /// </summary>
        public string OrderGoodsNum { get; set; }

        /// <summary>
        /// 厂商编码
        /// </summary>
        public string VendorId { get; set; }

        /// <summary>
        /// 商品信息列表
        /// </summary>
        public string GoodsInfoList { get; set; }

        /// <summary>
        /// 收货信息
        /// </summary>
        public string ReceiverInfo { get; set; }

        /// <summary>
        /// 终端信息
        /// </summary>
        public string TermInfo { get; set; }

        /// <summary>
        /// 收款商户
        /// </summary>
        public string PayMerchant { get; set; }

        /// <summary>
        /// 风控信息
        /// </summary>
        public string RiskInfo { get; set; }

        #region IJDPayRequest Members

        private string ApiVersion = "V2.0";

        public string GetRequestUrl()
        {
            return "https://paygate.jd.com/service/fkmPay";
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
            var parameters = new JDPayDictionary
            {
                { "token", Token },
                { "device", Device},
                { "tradeNum",TradeNum },
                { "tradeName", TradeName},
                { "tradeDesc", TradeDesc },
                { "tradeTime", TradeTime },
                { "amount", Amount },
                { "industryCategoryCode", IndustryCategoryCode },
                { "currency", Currency },
                { "note", Note },
                { "notifyUrl", NotifyUrl },
                { "orderGoodsNum", OrderGoodsNum },
                { "vendorId", VendorId },
                { "goodsInfoList", GoodsInfoList },
                { "receiverInfo", ReceiverInfo },
                { "termInfo", TermInfo },
                { "payMerchant", PayMerchant },
                { "riskInfo", RiskInfo }
            };
            return parameters;
        }

        #endregion
    }
}
