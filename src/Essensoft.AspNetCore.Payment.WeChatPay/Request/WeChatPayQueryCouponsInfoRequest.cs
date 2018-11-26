using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.WeChatPay.Response;

namespace Essensoft.AspNetCore.Payment.WeChatPay.Request
{
    /// <summary>
    /// 查询代金券信息
    /// </summary>
    public class WeChatPayQueryCouponsInfoRequest : IWeChatPayRequest<WeChatPayQueryCouponsInfoResponse>
    {
        /// <summary>
        /// 应用ID
        /// </summary>
        public string AppId { get; set; }

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

        public string GetRequestUrl()
        {
            return "https://api.mch.weixin.qq.com/mmpaymkttransfers/querycouponsinfo";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new WeChatPayDictionary
            {
                { "appid", AppId },
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

        #endregion
    }
}
