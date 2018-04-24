using Essensoft.AspNetCore.Payment.QPay.Response;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Payment.QPay.Request
{
    public class QPayUnifiedOrderRequest : IQPayRequest<QPayUnifiedOrderResponse>
    {
        /// <summary>
        /// 应用ID
        /// </summary>
        public string AppId { get; set; }

        /// <summary>
        /// 子商户应用ID
        /// </summary>
        public string SubAppId { get; set; }

        /// <summary>
        /// 子商户号
        /// </summary>
        public string SubMchId { get; set; }

        /// <summary>
        /// 商品描述
        /// </summary>
        public string Body { get; set; }

        /// <summary>
        /// 附加数据
        /// </summary>
        public string Attach { get; set; }

        /// <summary>
        /// 商户订单号
        /// </summary>
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 标价币种
        /// </summary>
        public string FeeType { get; set; }

        /// <summary>
        /// 订单金额
        /// </summary>
        public int TotalFee { get; set; }

        /// <summary>
        /// 终端IP
        /// </summary>
        public string SpbillCreateIp { get; set; }

        /// <summary>
        /// 交易起始时间
        /// </summary>
        public string TimeStart { get; set; }

        /// <summary>
        /// 交易结束时间
        /// </summary>
        public string TimeExpire { get; set; }

        /// <summary>
        /// 支付方式限制
        /// </summary>
        public string LimitPay { get; set; }

        /// <summary>
        /// 代扣签约序列号
        /// </summary>
        public string ContractCode { get; set; }

        /// <summary>
        /// QQ钱包活动标识
        /// </summary>
        public string PromotionTag { get; set; }

        /// <summary>
        /// 支付场景
        /// </summary>
        public string TradeType { get; set; }

        /// <summary>
        /// 通知地址
        /// </summary>
        public string NotifyUrl { get; set; }

        /// <summary>
        /// 设备号
        /// </summary>
        public string DeviceInfo { get; set; }

        #region IQPayRequest Members

        public string GetRequestUrl()
        {
            return "https://qpay.qq.com/cgi-bin/pay/qpay_unified_order.cgi";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new QPayDictionary()
            {
                { "appid", AppId },
                { "sub_appid", SubAppId },
                { "sub_mch_id", SubMchId },
                { "body", Body },
                { "attach", Attach },
                { "out_trade_no", OutTradeNo },
                { "fee_type", FeeType },
                { "total_fee", TotalFee },
                { "spbill_create_ip", SpbillCreateIp },
                { "time_start", TimeStart },
                { "time_expire", TimeExpire },
                { "limit_pay", LimitPay },
                { "contract_code", ContractCode },
                { "promotion_tag", PromotionTag },
                { "trade_type", TradeType },
                { "notify_url", NotifyUrl },
                { "device_info", DeviceInfo }
            };
            return parameters;
        }

        #endregion
    }
}
