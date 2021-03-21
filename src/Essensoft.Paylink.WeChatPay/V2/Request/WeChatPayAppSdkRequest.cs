using System.Collections.Generic;

namespace Essensoft.Paylink.WeChatPay.V2.Request
{
    /// <summary>
    /// APP支付 调起支付
    /// </summary>
    public class WeChatPayAppSdkRequest : IWeChatPaySdkRequest
    {
        /// <summary>
        /// 预支付交易会话ID
        /// </summary>
        public string PrepayId { get; set; }

        /// <summary>
        /// 扩展字段
        /// </summary>
        public string Package { get; set; } = "Sign=WXPay";

        #region IWeChatPaySdkRequest Members

        private WeChatPaySignType signType = WeChatPaySignType.MD5;

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new WeChatPayDictionary
            {
                { "prepayid", PrepayId },
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
            sortedTxtParams.Add(WeChatPayConsts.noncestr, WeChatPayUtility.GenerateNonceStr());
            sortedTxtParams.Add(WeChatPayConsts.timestamp, WeChatPayUtility.GetTimeStamp());

            if (!string.IsNullOrEmpty(options.SubAppId) && !string.IsNullOrEmpty(options.SubMchId))
            {
                sortedTxtParams.Add(WeChatPayConsts.appid, options.SubAppId);
                sortedTxtParams.Add(WeChatPayConsts.partnerid, options.SubMchId);
            }
            else
            {
                sortedTxtParams.Add(WeChatPayConsts.appid, options.AppId);
                sortedTxtParams.Add(WeChatPayConsts.partnerid, options.MchId);
            }

            sortedTxtParams.Add(WeChatPayConsts.sign, WeChatPaySignature.SignWithKey(sortedTxtParams, options.APIKey, signType));
        }

        #endregion
    }
}
