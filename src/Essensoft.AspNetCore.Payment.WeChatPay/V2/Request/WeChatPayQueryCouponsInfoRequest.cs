using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.WeChatPay.V2.Response;

namespace Essensoft.AspNetCore.Payment.WeChatPay.V2.Request
{
    /// <summary>
    /// 查询代金券信息 (普通商户)
    /// </summary>
    public class WeChatPayQueryCouponsInfoRequest : IWeChatPayRequest<WeChatPayQueryCouponsInfoResponse>
    {
        /// <summary>
        /// 代金券id
        /// </summary>
        public string CouponId { get; set; }

        /// <summary>
        /// 用户openid
        /// </summary>
        public string OpenId { get; set; }

        /// <summary>
        /// 批次号
        /// </summary>
        public string StockId { get; set; }

        /// <summary>
        /// 操作员
        /// </summary>
        public string OpUserId { get; set; }

        /// <summary>
        /// 设备号
        /// </summary>
        public string DeviceInfo { get; set; }

        /// <summary>
        /// 协议版本
        /// </summary>
        public string Version { get; set; }

        /// <summary>
        /// 协议类型
        /// </summary>
        public string Type { get; set; }

        #region IWeChatPayRequest Members

        private string requestUrl = "https://api.mch.weixin.qq.com/mmpaymkttransfers/querycouponsinfo";

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
                { "coupon_id", CouponId },
                { "openid", OpenId },
                { "stock_id", StockId },
                { "op_user_id", OpUserId },
                { "device_info", DeviceInfo },
                { "version", Version },
                { "type", Type }
            };
            return parameters;
        }

        public void PrimaryHandler(WeChatPayOptions options, WeChatPaySignType signType, WeChatPayDictionary sortedTxtParams)
        {
            sortedTxtParams.Add(WeChatPayConsts.nonce_str, WeChatPayUtility.GenerateNonceStr());
            sortedTxtParams.Add(WeChatPayConsts.appid, options.AppId);
            sortedTxtParams.Add(WeChatPayConsts.mch_id, options.MchId);

            sortedTxtParams.Add(WeChatPayConsts.sign, WeChatPaySignature.SignWithKey(sortedTxtParams, options.Key, signType));
        }

        #endregion
    }
}
