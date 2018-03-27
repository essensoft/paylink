using Essensoft.AspNetCore.Payment.JdPay.Response;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Payment.JdPay.Request
{
    /// <summary>
    /// 撤销申请接口
    /// </summary>
    public class JdPayRevokeRequest : IJdPayRequest<JdPayRevokeResponse>
    {
        /// <summary>
        /// 交易流水号
        /// 和原交易流水号不能一致，否则撤销失败
        /// </summary>
        public string TradeNum { get; set; }

        /// <summary>
        /// 原交易流水号
        /// 数字或字母，标识需要撤销的那笔交易流水。
        /// </summary>
        public string OTradeNum { get; set; }

        /// <summary>
        /// 交易金额
        /// 商户订单的资金总额。单位：分，大于0
        /// </summary>
        public string Amount { get; set; }

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
        /// 交易备注
        /// 商户备注信息
        /// </summary>
        public string Note { get; set; }

        #region IJdPayRequest Members

        private string ApiVersion = "V2.0";

        public string GetRequestUrl()
        {
            return "https://paygate.jd.com/service/revoke";
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
                { "note", Note },
            };
            return parameters;
        }

        #endregion
    }
}
