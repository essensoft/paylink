using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.QPay.Response;

namespace Essensoft.AspNetCore.Payment.QPay.Request
{
    /// <summary>
    /// 企业付款 - 对账单下载
    /// </summary>
    public class QPayEPayStatementDownRequest : IQPayRequest<QPayEPayStatementDownResponse>
    {
        /// <summary>
        /// 对账单时间
        /// </summary>
        public string BillDate { get; set; }

        #region IQPayRequest Members

        public string GetRequestUrl()
        {
            return "https://qpay.qq.com/cgi-bin/pay/qpay_epay_statement_down.cgi";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new QPayDictionary
            {
                { "bill_date", BillDate },
            };
            return parameters;
        }

        public bool IsCheckResponseSign()
        {
            return false;
        }

        #endregion
    }
}
