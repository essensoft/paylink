using Essensoft.AspNetCore.WeChatPay.Response;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.WeChatPay.Request
{
    public class WeChatPayDownloadFundFlowRequest : IWeChatPayCertificateRequest<WeChatPayDownloadFundFlowResponse>
    {
        /// <summary>
        /// 资金账单日期
        /// 下载对账单的日期，格式：20140603
        /// </summary>
        public string BillDate { get; set; }

        /// <summary>
        /// 资金账户类型
        /// 账单的资金来源账户：
        /// Basic 基本账户
        /// Operation 运营账户
        /// Fees 手续费账户
        /// </summary>
        public string AccountType { get; set; }

        /// <summary>
        /// 压缩账单
        /// 非必传参数，固定值：GZIP，返回格式为.gzip的压缩包账单。不传则默认为数据流形式。
        /// </summary>
        public string TarType { get; set; }

        #region IWeChatPayRequest Members

        public string GetRequestUrl()
        {
            return "https://api.mch.weixin.qq.com/pay/downloadfundflow";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new WeChatPayDictionary()
            {
                { "bill_date", BillDate },
                { "account_type", AccountType },
                { "tar_type", TarType }
            };
            return parameters;
        }

        #endregion
    }
}
