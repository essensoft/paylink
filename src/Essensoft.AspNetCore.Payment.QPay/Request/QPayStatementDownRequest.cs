using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.QPay.Response;

namespace Essensoft.AspNetCore.Payment.QPay.Request
{
    /// <summary>
    /// 对账单下载
    /// </summary>
    public class QPayStatementDownRequest : IQPayRequest<QPayStatementDownResponse>
    {
        /// <summary>
        /// 对账单时间
        /// </summary>
        public string BillDate { get; set; }

        /// <summary>
        /// 对账单类型
        /// </summary>
        public string BillType { get; set; }

        /// <summary>
        /// 压缩账单
        /// </summary>
        public string TarType { get; set; }

        #region IQPayRequest Members

        public string GetRequestUrl()
        {
            return "https://qpay.qq.com/cgi-bin/sp_download/qpay_mch_statement_down.cgi";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new QPayDictionary
            {
                { "bill_date", BillDate },
                { "bill_type", BillType },
                { "tar_type", TarType }
            };
            return parameters;
        }

        #endregion
    }
}
