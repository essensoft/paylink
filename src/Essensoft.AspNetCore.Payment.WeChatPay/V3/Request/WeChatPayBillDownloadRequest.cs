using Essensoft.AspNetCore.Payment.WeChatPay.V3.Response;

namespace Essensoft.AspNetCore.Payment.WeChatPay.V3.Request
{
    /// <summary>
    /// 账单-下载账单API（电商平台、服务商、直连商户）
    /// 最新更新时间：2019.09.16
    /// https://pay.weixin.qq.com/wiki/doc/apiv3/wxpay/pay/bill/chapter3_3.shtml
    /// </summary>
    public class WeChatPayBillDownloadRequest : IWeChatPayGetRequest<WeChatPayBillDownloadResponse>
    {
        /// <summary>
        /// 下载地址
        /// </summary>
        public string DownloadUrl { get; set; }

        public string GetRequestUrl()
        {
            return DownloadUrl;
        }

        public bool GetNeedCheckSign()
        {
            return false;
        }
    }
}
