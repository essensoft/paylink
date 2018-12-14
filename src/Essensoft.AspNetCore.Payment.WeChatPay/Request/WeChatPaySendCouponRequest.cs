using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.WeChatPay.Response;
using Essensoft.AspNetCore.Payment.WeChatPay.Utility;

namespace Essensoft.AspNetCore.Payment.WeChatPay.Request
{
    /// <summary>
    /// 发放代金券
    /// </summary>
    public class WeChatPaySendCouponRequest : WeChatPayCertificateRequest<WeChatPaySendCouponResponse>
    {
        /// <summary>
        /// 应用ID
        /// </summary>
        public string AppId { get; set; }

        /// <summary>
        /// 代金券批次id
        /// </summary>
        public string CouponStockId { get; set; }

        /// <summary>
        /// openid记录数
        /// </summary>
        public string OpenIdCount { get; set; }

        /// <summary>
        /// 商户单据号
        /// </summary>
        public string PartnerTradeNo { get; set; }

        /// <summary>
        /// 用户openid
        /// </summary>
        public string OpenId { get; set; }

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

        #region IWeChatPayCertificateRequest Members

        public override string GetRequestUrl()
        {
            return "https://api.mch.weixin.qq.com/mmpaymkttransfers/send_coupon";
        }

        protected override IDictionary<string, string> GetParameters()
        {
            var parameters = new WeChatPayDictionary
            {
                { ConstKey.Key_appid, AppId },
                { ConstKey.Key_coupon_stock_id, CouponStockId },
                { ConstKey.Key_openid_count, OpenIdCount },
                { ConstKey.Key_partner_trade_no, PartnerTradeNo },
                { ConstKey.Key_openid, OpenId },
                { ConstKey.Key_op_user_id, OpUserId },
                { ConstKey.Key_device_info, DeviceInfo },
                { ConstKey.Key_version, Version },
                { ConstKey.Key_type, Type }
            };
            return parameters;
        }
        protected override void HandleParametersInOptions(WeChatPayDictionary sortedTxtParams, WeChatPayOptions options)
        {
            base.HandleParametersInOptions(sortedTxtParams, options);

            if (string.IsNullOrEmpty(sortedTxtParams.GetValue(ConstKey.Key_appid)))
            {
                sortedTxtParams.Add(ConstKey.Key_appid, options.AppId);
            }

            sortedTxtParams.Add(ConstKey.Key_mch_id, options.MchId);
        }
        #endregion
    }
}
