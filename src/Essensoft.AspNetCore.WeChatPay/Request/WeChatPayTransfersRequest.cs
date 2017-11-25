using Essensoft.AspNetCore.WeChatPay.Response;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.WeChatPay.Request
{
    public class WeChatPayTransfersRequest : IWeChatPayCertificateRequest<WeChatPayTransfersResponse>
    {
        /// <summary>
        /// 设备号
        /// </summary>
        public string DeviceInfo { get; set; }

        /// <summary>
        /// 商户订单号
        /// </summary>
        public string PartnerTradeNo { get; set; }

        /// <summary>
        /// 用户openid
        /// </summary>
        public string OpenId { get; set; }

        /// <summary>
        /// 校验用户姓名选项
        /// </summary>
        public string CheckName { get; set; }

        /// <summary>
        /// 收款用户姓名
        /// </summary>
        public string ReUserName { get; set; }

        /// <summary>
        /// 金额
        /// </summary>
        public int Amount { get; set; }

        /// <summary>
        /// 企业付款描述信息
        /// </summary>
        public string Desc { get; set; }

        /// <summary>
        /// Ip地址
        /// </summary>
        public string SpbillCreateIp { get; set; }

        #region IWeChatPayRequest Members

        public string GetRequestUrl()
        {
            return "https://api.mch.weixin.qq.com/mmpaymkttransfers/promotion/transfers";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new WeChatPayDictionary()
            {
                { "device_info", DeviceInfo },
                { "partner_trade_no", PartnerTradeNo },
                { "openid", OpenId },
                { "check_name", CheckName },
                { "re_user_name", ReUserName },
                { "amount", Amount.ToString() },
                { "desc", Desc.ToString() },
                { "spbill_create_ip", SpbillCreateIp }
            };
            return parameters;
        }
        #endregion
    }
}
