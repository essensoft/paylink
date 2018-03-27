using Essensoft.AspNetCore.Payment.WeChatPay.Response;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Payment.WeChatPay.Request
{
    public class WeChatPayDownloadBillRequest : IWeChatPayRequest<WeChatPayDownloadBillResponse>
    {
        /// <summary>
        /// 设备号
        /// </summary>
        public string DeviceInfo { get; set; }

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

        /// <summary>
        /// 子商户公众账号ID
        /// </summary>
        public string SubAppId { get; set; }

        /// <summary>
        /// 子商户号
        /// </summary>
        public string SubMchId { get; set; }

        #region IWeChatPayRequest Members

        public string GetRequestUrl()
        {
            return "https://api.mch.weixin.qq.com/pay/downloadbill";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new WeChatPayDictionary()
            {
                { "device_info", DeviceInfo },
                { "bill_date", BillDate },
                { "bill_type", BillType },
                { "tar_type", TarType },
                { "sub_appid", SubAppId },
                { "sub_mch_id", SubMchId },
            };
            return parameters;
        }

        #endregion
    }
}
