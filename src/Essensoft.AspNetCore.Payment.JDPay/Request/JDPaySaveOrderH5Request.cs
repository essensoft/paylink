using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.JDPay.Response;

namespace Essensoft.AspNetCore.Payment.JDPay.Request
{
    /// <summary>
    /// H5在线支付接口
    /// </summary>
    public class JDPaySaveOrderH5Request : IJDPayRequest<JDPaySaveOrderResponse>
    {
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
        public string IP { get; set; }

        /// <summary>
        /// 用户指定卡号
        /// </summary>
        public string SpecCardNo { get; set; }

        /// <summary>
        /// 用户指定身份证
        /// </summary>
        public string SpecId { get; set; }

        /// <summary>
        /// 用户指定姓名
        /// </summary>
        public string SpecName { get; set; }

        /// <summary>
        /// 用户账号
        /// </summary>
        public string UserId { get; set; }

        /// <summary>
        /// 订单失效时长
        /// </summary>
        public string ExpireTime { get; set; }

        /// <summary>
        /// 订单商品数量
        /// </summary>
        public string OrderGoodsNum { get; set; }

        /// <summary>
        /// 厂商编码
        /// </summary>
        public string VendorId { get; set; }

        /// <summary>
        /// 商品信息
        /// </summary>
        public string GoodsInfo { get; set; }

        /// <summary>
        /// 收货信息
        /// </summary>
        public string ReceiverInfo { get; set; }

        /// <summary>
        /// 终端信息
        /// </summary>
        public string TermInfo { get; set; }

        /// <summary>
        /// 风控信息
        /// </summary>
        public string RiskInfo { get; set; }

        /// <summary>
        /// 结算币种
        /// </summary>
        public string SettleCurrency { get; set; }

        /// <summary>
        /// 业务信息
        /// </summary>
        public string KJInfo { get; set; }

        #region IJDPayRequest Members

        private string ApiVersion = "V2.0";

        public string GetRequestUrl()
        {
            return "https://h5pay.jd.com/jdpay/saveOrder";
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
                { "device", Device },
                { "tradeNum", TradeNum },
                { "tradeName", TradeName },
                { "tradeDesc", TradeDesc },
                { "tradeTime", TradeTime },
                { "amount", Amount },
                { "orderType", OrderType },
                { "industryCategoryCode", IndustryCategoryCode },
                { "currency", Currency },
                { "note", Note },
                { "callbackUrl", CallbackUrl },
                { "notifyUrl", NotifyUrl },
                { "ip", IP },
                { "specCardNo", SpecCardNo },
                { "specId", SpecId },
                { "specName", SpecName },
                { "userId", UserId },
                { "expireTime", ExpireTime },
                { "orderGoodsNum", OrderGoodsNum },
                { "vendorId", VendorId },
                { "goodsInfo", GoodsInfo },
                { "receiverInfo", ReceiverInfo },
                { "termInfo", TermInfo },
                { "riskInfo", RiskInfo },
                { "settleCurrency", SettleCurrency },
                { "kjInfo", KJInfo }
            };
            return parameters;
        }

        #endregion
    }
}
