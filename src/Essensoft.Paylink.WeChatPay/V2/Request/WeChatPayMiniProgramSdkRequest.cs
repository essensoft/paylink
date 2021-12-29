using System.Collections.Generic;

namespace Essensoft.Paylink.WeChatPay.V2.Request
{
    /// <summary>
    /// 小程序调起支付
    /// </summary>
    public class WeChatPayMiniProgramSdkRequest : IWeChatPaySdkRequest
    {
        /// <summary>
        /// 扩展字段
        /// </summary>
        public string Package { get; set; }

        #region IWeChatPaySdkRequest Members

        private WeChatPaySignType signType = WeChatPaySignType.MD5;

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new WeChatPayDictionary
            {
                { "package", Package }
            };
            return parameters;
        }

        public WeChatPaySignType GetSignType()
        {
            return signType;
        }

        public void SetSignType(WeChatPaySignType signType)
        {
            this.signType = signType;
        }

        public void PrimaryHandler(WeChatPayDictionary sortedTxtParams, WeChatPayOptions options)
        {
            sortedTxtParams.Add(WeChatPayConsts.timeStamp, WeChatPayUtility.GetTimeStamp());
            sortedTxtParams.Add(WeChatPayConsts.nonceStr, WeChatPayUtility.GenerateNonceStr());

            if (!string.IsNullOrEmpty(options.SubAppId))
            {
                sortedTxtParams.Add(WeChatPayConsts.appId, options.SubAppId);
            }
            else
            {
                sortedTxtParams.Add(WeChatPayConsts.appId, options.AppId);
            }

            sortedTxtParams.Add(WeChatPayConsts.signType, signType);
            sortedTxtParams.Add(WeChatPayConsts.paySign, WeChatPaySignature.SignWithKey(sortedTxtParams, options.APIKey, signType));
        }

        #endregion
    }
}
