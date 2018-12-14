using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.WeChatPay.Response;
using Essensoft.AspNetCore.Payment.WeChatPay.Utility;

namespace Essensoft.AspNetCore.Payment.WeChatPay.Request
{
    /// <summary>
    /// 查询红包记录
    /// </summary>
    public class WeChatPayGetHBInfoRequest : WeChatPayCertificateRequest<WeChatPayGetHBInfoResponse>
    {
        /// <summary>
        /// 应用ID
        /// </summary>
        public string AppId { get; set; }

        /// <summary>
        /// 商户订单号
        /// </summary>
        public string MchBillNo { get; set; }

        /// <summary>
        /// 订单类型
        /// </summary>
        public string BillType { get; set; }

        #region IWeChatPayCertificateRequest Members

        public override string GetRequestUrl()
        {
            return "https://api.mch.weixin.qq.com/mmpaymkttransfers/gethbinfo";
        }

        protected override IDictionary<string, string> GetParameters()
        {
            var parameters = new WeChatPayDictionary
            {
                { ConstKey.Key_appid, AppId },
                { ConstKey.Key_mch_billno, MchBillNo },
                { ConstKey.Key_bill_type, BillType }
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
