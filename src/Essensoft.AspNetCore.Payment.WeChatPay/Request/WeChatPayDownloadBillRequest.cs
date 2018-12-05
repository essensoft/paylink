using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.WeChatPay.Response;

namespace Essensoft.AspNetCore.Payment.WeChatPay.Request
{
    /// <summary>
    /// 下载对账单
    /// </summary>
    public class WeChatPayDownloadBillRequest : IWeChatPayRequest<WeChatPayDownloadBillResponse>
    {
        /// <summary>
        /// 应用ID
        /// </summary>
        public string AppId { get; set; }

        /// <summary>
        /// 子商户公众账号ID
        /// </summary>
        public string SubAppId { get; set; }

        /// <summary>
        /// 子商户号
        /// </summary>
        public string SubMchId { get; set; }

        /// <summary>
        /// 对账单日期
        /// </summary>
        public string BillDate { get; set; }

        /// <summary>
        /// 账单类型
        /// </summary>
        public string BillType { get; set; }

        /// <summary>
        /// 压缩账单
        /// </summary>
        public string TarType { get; set; }

        #region IWeChatPayRequest Members

        public string GetRequestUrl()
        {
            return "https://api.mch.weixin.qq.com/pay/downloadbill";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new WeChatPayDictionary
            {
                { "appid", AppId },
                { "sub_appid", SubAppId },
                { "sub_mch_id", SubMchId },
                { "bill_date", BillDate },
                { "bill_type", BillType },
                { "tar_type", TarType }
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
