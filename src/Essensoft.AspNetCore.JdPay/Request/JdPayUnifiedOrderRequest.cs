using Essensoft.AspNetCore.JdPay.Response;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.JdPay.Request
{
    public class JdPayUnifiedOrderRequest : IJdPayRequest<JdPayUnifiedOrderResponse>
    {
        /// <summary>
        /// 收款商户
        /// </summary>
        public string PayMerchant { set; get; }

        /// <summary>
        /// 门店号
        /// </summary>
        public string Device { set; get; }

        /// <summary>
        /// 交易流水号
        /// </summary>
        public string TradeNum { set; get; }

        /// <summary>
        /// 交易名称
        /// </summary>
        public string TradeName { set; get; }

        /// <summary>
        /// 交易描述
        /// </summary>
        public string TradeDesc { set; get; }

        /// <summary>
        /// 交易时间
        /// </summary>
        public string TradeTime { set; get; }

        /// <summary>
        /// 交易金额
        /// </summary>
        public string Amount { set; get; }

        /// <summary>
        /// 订单类型
        /// </summary>
        public string OrderType { set; get; }

        /// <summary>
        /// 业务类型
        /// </summary>
        public string IndustryCategoryCode { set; get; }

        /// <summary>
        /// 货币种类
        /// </summary>
        public string Currency { set; get; }

        /// <summary>
        /// 商户备注
        /// </summary>
        public string Note { set; get; }

        /// <summary>
        /// 同步通知页面
        /// </summary>
        public string CallbackUrl { set; get; }

        /// <summary>
        /// 异步通知页面地址
        /// </summary>
        public string NotifyUrl { set; get; }

        /// <summary>
        /// 用户IP
        /// </summary>
        public string Ip { set; get; }

        /// <summary>
        /// 用户指定卡号
        /// </summary>
        public string SpecCardNo { set; get; }

        /// <summary>
        /// 用户指定身份证
        /// </summary>
        public string SpecId { set; get; }

        /// <summary>
        /// 用户指定姓名
        /// </summary>
        public string SpecName { set; get; }

        /// <summary>
        /// 交易类型
        /// </summary>
        public string TradeType { set; get; }

        /// <summary>
        /// 用户账号
        /// </summary>
        public string UserId { set; get; }

        /// <summary>
        /// 订单失效时长
        /// </summary>
        public string ExpireTime { set; get; }

        /// <summary>
        /// 订单商品数量
        /// </summary>
        public string OrderGoodsNum { set; get; }

        /// <summary>
        /// 厂商编码
        /// </summary>
        public string VendorId { set; get; }

        /// <summary>
        /// 商品信息
        /// </summary>
        public string GoodsInfo { set; get; }

        /// <summary>
        /// 收货信息
        /// </summary>
        public string ReceiverInfo { set; get; }

        /// <summary>
        /// 终端信息
        /// </summary>
        public string TermInfo { set; get; }

        /// <summary>
        /// 风控信息
        /// </summary>
        public string RiskInfo { set; get; }

        #region IJdPayRequest Members

        private string ApiVersion = "V2.0";

        public string GetRequestUrl()
        {
            return "http://paygate.jd.com/service/uniorder";
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
            var parameters = new JdPayDictionary()
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
                { "note", Note },
                { "callbackUrl", CallbackUrl},
                { "notifyUrl", NotifyUrl },
                { "ip", Ip },
                { "specCardNo", SpecCardNo },
                { "specId", SpecId },
                { "specName", SpecName },
                { "tradeType", TradeType },
                { "userId", UserId },
                { "expireTime", ExpireTime },
                { "orderGoodsNum", OrderGoodsNum },
                { "vendorId", VendorId },
                { "goodsInfo", GoodsInfo },
                { "receiverInfo", ReceiverInfo },
                { "termInfo", TermInfo },
                { "riskInfo", RiskInfo },
            };
            return parameters;
        }

        public IDictionary<string, string> GetEncryptParameters()
        {
            return null;
        }

        #endregion
    }
}
