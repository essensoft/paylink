using System;
using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.WeChatPay.Response;
using Essensoft.AspNetCore.Payment.WeChatPay.Utility;

namespace Essensoft.AspNetCore.Payment.WeChatPay.Request
{
    /// <summary>
    /// 企业支付 - 向员工付款
    /// </summary>
    public class WeChatPayPayWwSpTrans2PockeRequest : WeChatPayCertificateRequest<WeChatPayPayWwSpTrans2PockeResponse>
    {
        /// <summary>
        /// 公众账号appid
        /// </summary>
        public string AppId { get; set; }

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
        /// 付款说明
        /// </summary>
        public string Desc { get; set; }

        /// <summary>
        /// Ip地址
        /// </summary>
        public string SpbillCreateIp { get; set; }

        /// <summary>
        /// 付款消息类型
        /// </summary>
        public string WwMsgType { get; set; }

        /// <summary>
        /// 审批单号
        /// </summary>
        public string ApprovalNumber { get; set; }

        /// <summary>
        /// 审批类型
        /// </summary>
        public string ApprovalType { get; set; }

        /// <summary>
        /// 项目名称
        /// </summary>
        public string ActName { get; set; }

        /// <summary>
        /// 付款的应用id
        /// </summary>
        public string AgentId { get; set; }

        #region IWeChatPayCertificateRequest Members

        public override string GetRequestUrl()
        {
            return "https://api.mch.weixin.qq.com/mmpaymkttransfers/promotion/paywwsptrans2pocket";
        }

        protected override IDictionary<string, string> GetParameters()
        {
            var parameters = new WeChatPayDictionary
            {
                { ConstKey.Key_appid, AppId },
                { ConstKey.Key_device_info, DeviceInfo },
                { ConstKey.Key_partner_trade_no, PartnerTradeNo },
                { ConstKey.Key_openid, OpenId },
                { ConstKey.Key_check_name, CheckName },
                { ConstKey.Key_re_user_name, ReUserName },
                { ConstKey.Key_amount, Amount },
                { ConstKey.Key_desc, Desc },
                { ConstKey.Key_spbill_create_ip, SpbillCreateIp },
                { ConstKey.Key_ww_msg_type, WwMsgType },
                { ConstKey.Key_approval_number, ApprovalNumber },
                { ConstKey.Key_approval_type, ApprovalType },
                { ConstKey.Key_act_name, ActName },
                { ConstKey.Key_agentid, AgentId },
            };
            return parameters;
        }
        public override void CheckResponseSign(WeChatPayResponse response, WeChatPayOptions options)
        {
        }

        protected override void HandleParametersInOptions(WeChatPayDictionary sortedTxtParams, WeChatPayOptions options)
        {
            base.HandleParametersInOptions(sortedTxtParams, options);


            if (string.IsNullOrEmpty(sortedTxtParams.GetValue(ConstKey.Key_appid)))
            {
                sortedTxtParams.Add(ConstKey.Key_appid, options.AppId);
            }

            sortedTxtParams.Add(ConstKey.Key_mch_id, options.MchId);

            var sign_list = new List<string>
                {
                    "amount",
                    "appid",
                    "desc",
                    "mch_id",
                    "nonce_str",
                    "openid",
                    "partner_trade_no",
                    "ww_msg_type",
                };

            sortedTxtParams.Add(ConstKey.Key_workwx_sign, WeChatPaySignature.SignWithSecret(sortedTxtParams, options.Secret, sign_list));
        }
        #endregion
    }
}