using System;
using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.WeChatPay.Response;
using Essensoft.AspNetCore.Payment.WeChatPay.Utility;

namespace Essensoft.AspNetCore.Payment.WeChatPay.Request
{
    /// <summary>
    /// 企业支付 - 发放企业红包
    /// </summary>
    public class WeChatPaySendWorkWxRedPackRequest : WeChatPayCertificateRequest<WeChatPaySendWorkWxRedPackResponse>
    {
        /// <summary>
        /// 商户订单号
        /// </summary>
        public string MchBillNo { get; set; }

        /// <summary>
        /// 公众账号appid
        /// </summary>
        public string WxAppId { get; set; }

        /// <summary>
        /// 发送者名称
        /// </summary>
        public string SenderName { get; set; }

        /// <summary>
        /// 发送红包的应用id
        /// </summary>
        public string AgentId { get; set; }

        /// <summary>
        /// 发送者头像
        /// </summary>
        public string SenderHeaderMediaId { get; set; }

        /// <summary>
        /// 用户openid
        /// </summary>
        public string ReOpenId { get; set; }

        /// <summary>
        /// 金额
        /// </summary>
        public int TotalAmount { get; set; }

        /// <summary>
        /// 红包祝福语
        /// </summary>
        public string Wishing { get; set; }

        /// <summary>
        /// 项目名称
        /// </summary>
        public string ActName { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }

        /// <summary>
        /// 场景id
        /// </summary>
        public string SceneId { get; set; }

        #region IWeChatPayCertificateRequest Members

        public override string GetRequestUrl()
        {
            return "https://api.mch.weixin.qq.com/mmpaymkttransfers/sendworkwxredpack";
        }

        protected override IDictionary<string, string> GetParameters()
        {
            var parameters = new WeChatPayDictionary
            {
                { ConstKey.Key_mch_billno, MchBillNo },
                { ConstKey.Key_wxappid, WxAppId },
                { ConstKey.Key_sender_name, SenderName },
                { ConstKey.Key_agentid, AgentId },
                { ConstKey.Key_sender_header_media_id, SenderHeaderMediaId },
                { ConstKey.Key_re_openid, ReOpenId },
                { ConstKey.Key_total_amount, TotalAmount },
                { ConstKey.Key_wishing, Wishing },
                { ConstKey.Key_act_name, ActName },
                { ConstKey.Key_remark, Remark },
                { ConstKey.Key_scene_id, SceneId },
            };
            return parameters;
        }

        protected override void HandleParametersInOptions(WeChatPayDictionary sortedTxtParams, WeChatPayOptions options)
        {
            base.HandleParametersInOptions(sortedTxtParams, options);

            if (string.IsNullOrEmpty(sortedTxtParams.GetValue(ConstKey.Key_wxappid)))
            {
                sortedTxtParams.Add(ConstKey.Key_wxappid, options.AppId);
            }

            sortedTxtParams.Add(ConstKey.Key_mch_id, options.MchId);

            var sign_list = new List<string>
                {
                    "act_name",
                    "mch_billno",
                    "mch_id",
                    "nonce_str",
                    "re_openid",
                    "total_amount",
                    "wxappid",
                };

            sortedTxtParams.Add(ConstKey.Key_workwx_sign, WeChatPaySignature.SignWithSecret(sortedTxtParams, options.Secret, sign_list));
        }
        #endregion
    }
}
