using System.Collections.Generic;
using Essensoft.Paylink.WeChatPay.V2.Response;

namespace Essensoft.Paylink.WeChatPay.V2.Request
{
    /// <summary>
    /// 微信代扣 - 车主平台 - 用户状态查询 (普通商户)
    /// </summary>
    public class WeChatPayVehiclePayQueryStateRequest : IWeChatPayRequest<WeChatPayVehiclePayQueryStateResponse>
    {
        /// <summary>
        /// 交易场景
        /// </summary>
        public string TradeScene { get; set; }

        /// <summary>
        /// 跳转场景
        /// </summary>
        public string JumpScene { get; set; }

        /// <summary>
        /// 用户标识
        /// </summary>
        public string OpenId { get; set; }

        /// <summary>
        /// 用户子标识
        /// </summary>
        public string SubOpenId { get; set; }

        /// <summary>
        /// 车牌号
        /// </summary>
        public string PlateNumber { get; set; }

        /// <summary>
        /// 版本号
        /// </summary>
        public string Version { get; set; }

        #region IWeChatPayRequest Members

        private string requestUrl = "https://api.mch.weixin.qq.com/vehicle/pay/querystate";
        private WeChatPaySignType signType = WeChatPaySignType.HMAC_SHA256;

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
                { "trade_scene", TradeScene },
                { "jump_scene", JumpScene },
                { "openid", OpenId },
                { "sub_openid", SubOpenId },
                { "plate_number", PlateNumber },
                { "version", Version },
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
            sortedTxtParams.Add(WeChatPayConsts.nonce_str, WeChatPayUtility.GenerateNonceStr());
            sortedTxtParams.Add(WeChatPayConsts.appid, options.AppId);
            sortedTxtParams.Add(WeChatPayConsts.mch_id, options.MchId);

            sortedTxtParams.Add(WeChatPayConsts.sign_type, signType.ToString());
            sortedTxtParams.Add(WeChatPayConsts.sign, WeChatPaySignature.SignWithKey(sortedTxtParams, options.APIKey, signType));
        }

        #endregion
    }
}
