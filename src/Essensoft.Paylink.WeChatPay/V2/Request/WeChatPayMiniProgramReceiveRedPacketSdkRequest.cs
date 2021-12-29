using System.Collections.Generic;

namespace Essensoft.Paylink.WeChatPay.V2.Request
{
    /// <summary>
    /// 小程序红包 - 领取红包
    /// </summary>
    public class WeChatPayMiniProgramReceiveRedPacketSdkRequest : IWeChatPaySdkRequest
    {
        /// <summary>
        /// 红包详情的扩展
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
            this.signType = signType switch
            {
                WeChatPaySignType.MD5 => signType,
                _ => throw new WeChatPayException("api only support MD5!"),
            };
        }

        public void PrimaryHandler(WeChatPayDictionary sortedTxtParams, WeChatPayOptions options)
        {
            sortedTxtParams.Add(WeChatPayConsts.timeStamp, WeChatPayUtility.GetTimeStamp());
            sortedTxtParams.Add(WeChatPayConsts.nonceStr, WeChatPayUtility.GenerateNonceStr());

            sortedTxtParams.Add(WeChatPayConsts.signType, signType);
            sortedTxtParams.Add(WeChatPayConsts.paySign, WeChatPaySignature.SignWithKey(sortedTxtParams, options.APIKey, signType));
        }

        #endregion
    }
}
