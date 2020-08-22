using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.WeChatPay.V2.Response;

namespace Essensoft.AspNetCore.Payment.WeChatPay.V2.Request
{
    /// <summary>
    /// 下载资金账单 (普通商户)
    /// </summary>
    public class WeChatPayDownloadFundFlowRequest : IWeChatPayCertRequest<WeChatPayDownloadFundFlowResponse>
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

        #region IWeChatPayCertificateRequest Members

        private string requestUrl = "https://api.mch.weixin.qq.com/pay/downloadfundflow";

        public string GetRequestUrl()
        {
            return requestUrl;
        }

        public void SetRequestUrl(string url)
        {
            requestUrl = url;
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new WeChatPayDictionary
            {
                { "bill_date", BillDate },
                { "account_type", AccountType },
                { "tar_type", TarType }
            };
            return parameters;
        }

        public WeChatPaySignType GetSignType()
        {
            return WeChatPaySignType.HMAC_SHA256;
        }

        public void PrimaryHandler(WeChatPayOptions options, WeChatPaySignType signType, WeChatPayDictionary sortedTxtParams)
        {
            sortedTxtParams.Add(WeChatPayConsts.nonce_str, WeChatPayUtility.GenerateNonceStr());
            sortedTxtParams.Add(WeChatPayConsts.appid, options.AppId);
            sortedTxtParams.Add(WeChatPayConsts.mch_id, options.MchId);

            if (signType == WeChatPaySignType.HMAC_SHA256)
            {
                sortedTxtParams.Add(WeChatPayConsts.sign_type, WeChatPayConsts.HMAC_SHA256);
            }

            sortedTxtParams.Add(WeChatPayConsts.sign, WeChatPaySignature.SignWithKey(sortedTxtParams, options.Key, signType));
        }

        public bool GetNeedCheckSign()
        {
            return false;
        }

        #endregion
    }
}
