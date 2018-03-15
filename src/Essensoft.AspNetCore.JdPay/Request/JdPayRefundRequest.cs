using Essensoft.AspNetCore.JdPay.Response;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.JdPay.Request
{
    public class JdPayRefundRequest : IJdPayRequest<JdPayRefundResponse>
    {
        /// <summary>
        /// 交易流水号
        /// </summary>
        public string TradeNum { get; set; }

        /// <summary>
        /// 原交易流水号
        /// </summary>
        public string OTradeNum { get; set; }

        /// <summary>
        /// 交易金额
        /// 商户订单的资金总额。单位：分，大于0
        /// </summary>
        public long Amount { get; set; }

        /// <summary>
        /// 交易币种
        /// 货币类型。固定值：CNY
        /// </summary>
        public string Currency { get; set; }

        /// <summary>
        /// 交易时间
        /// 订单生成时间。格式：“yyyyMMddHHmmss”
        /// </summary>
        public string TradeTime { get; set; }

        /// <summary>
        /// 交易通知地址
        /// 支付完成后，京东异步通知商户服务相关支付结果。必须是外网可访问的url。
        /// </summary>
        public string NotifyUrl { get; set; }

        /// <summary>
        /// 交易备注
        /// 退款申请的备注
        /// </summary>
        public string Note { get; set; }

        /// <summary>
        /// 门店号
        /// 商户门店号
        /// </summary>
        public string Device { get; set; }

        /// <summary>
        /// 终端号
        /// 用户终端信息,以json格式提交
        /// </summary>
        public string TermInfoId { get; set; }


        #region IJdPayRequest Members

        private string ApiVersion = "V2.0";

        public string GetRequestUrl()
        {
            return "https://paygate.jd.com/service/refund";
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
                { "tradeNum", TradeNum },
                { "oTradeNum", OTradeNum },
                { "amount", Amount },
                { "currency", Currency },
                { "tradeTime", TradeTime },
                { "notifyUrl", NotifyUrl },
                { "note", Note },
                { "device", Device },
                { "termInfoId", TermInfoId },
            };
            return parameters;
        }

        #endregion
    }
}
