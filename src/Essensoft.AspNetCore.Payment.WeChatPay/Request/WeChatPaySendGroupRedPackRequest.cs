using System;
using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.WeChatPay.Response;
using Essensoft.AspNetCore.Payment.WeChatPay.Utility;

namespace Essensoft.AspNetCore.Payment.WeChatPay.Request
{
    /// <summary>
    /// 发放裂变红包
    /// </summary>
    public class WeChatPaySendGroupRedPackRequest : WeChatPayCertificateRequest<WeChatPaySendGroupRedPackResponse>
    {
        /// <summary>
        /// 商户订单号
        /// </summary>
        public string MchBillNo { get; set; }

        /// <summary>
        /// 子商户号
        /// </summary>
        public string SubMchId { get; set; }

        /// <summary>
        /// 公众账号appid
        /// </summary>
        public string WXAppId { get; set; }

        /// <summary>
        /// 触达用户appid
        /// </summary>
        public string MsgAppId { get; set; }

        /// <summary>
        /// 商户名称
        /// </summary>
        public string SendName { get; set; }

        /// <summary>
        /// 用户openid
        /// </summary>
        public string ReOpenId { get; set; }

        /// <summary>
        /// 付款金额
        /// </summary>
        public int TotalAmount { get; set; }

        /// <summary>
        /// 红包发放总人数
        /// </summary>
        public int TotalNum { get; set; }

        /// <summary>
        /// 红包金额设置方式
        /// </summary>
        public string AmtType { get; set; }

        /// <summary>
        /// 红包祝福语
        /// </summary>
        public string Wishing { get; set; }

        /// <summary>
        /// 活动名称
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

        /// <summary>
        /// 活动信息
        /// </summary>
        public string RiskInfo { get; set; }

        /// <summary>
        /// 资金授权商户号
        /// </summary>
        public string ConsumeMchId { get; set; }

        #region IWeChatPayCertificateRequest Members

        public override string GetRequestUrl()
        {
            return "https://api.mch.weixin.qq.com/mmpaymkttransfers/sendgroupredpack";
        }

        protected override IDictionary<string, string> GetParameters()
        {
            var parameters = new WeChatPayDictionary
            {
                { ConstKey.Key_mch_billno, MchBillNo },
                { ConstKey.Key_sub_mch_id, SubMchId },
                { ConstKey.Key_wxappid, WXAppId },
                { ConstKey.Key_msgappid, MsgAppId },
                { ConstKey.Key_send_name, SendName },
                { ConstKey.Key_re_openid, ReOpenId },
                { ConstKey.Key_total_amount, TotalAmount },
                { ConstKey.Key_total_num, TotalNum },
                { ConstKey.Key_amt_type, AmtType },
                { ConstKey.Key_wishing, Wishing },
                { ConstKey.Key_act_name, ActName },
                { ConstKey.Key_remark, Remark },
                { ConstKey.Key_scene_id, SceneId },
                { ConstKey.Key_risk_info, RiskInfo },
                { ConstKey.Key_consume_mch_id, ConsumeMchId }
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
        }
        #endregion
    }
}
