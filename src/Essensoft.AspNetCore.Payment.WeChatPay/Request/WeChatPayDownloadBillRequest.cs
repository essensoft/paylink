using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.WeChatPay.Response;
using Essensoft.AspNetCore.Payment.WeChatPay.Utility;

namespace Essensoft.AspNetCore.Payment.WeChatPay.Request
{
    /// <summary>
    /// 下载对账单
    /// </summary>
    public class WeChatPayDownloadBillRequest : WeChatPayRequest<WeChatPayDownloadBillResponse>
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

        public override string GetRequestUrl()
        {
            return "https://api.mch.weixin.qq.com/pay/downloadbill";
        }

        protected override IDictionary<string, string> GetParameters()
        {
            var parameters = new WeChatPayDictionary
            {
                { ConstKey.Key_appid, AppId },
                { ConstKey.Key_sub_appid, SubAppId },
                { ConstKey.Key_sub_mch_id, SubMchId },
                { ConstKey.Key_bill_date, BillDate },
                { ConstKey.Key_bill_type, BillType },
                { ConstKey.Key_tar_type, TarType }
            };
            return parameters;
        }

        public override void CheckResponseSign(WeChatPayResponse response, WeChatPayOptions options)
        {

        }

        #endregion
    }
}
