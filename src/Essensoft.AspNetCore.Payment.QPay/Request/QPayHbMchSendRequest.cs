using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.QPay.Response;
using Essensoft.AspNetCore.Payment.QPay.Utility;

namespace Essensoft.AspNetCore.Payment.QPay.Request
{
    /// <summary>
    /// 现金红包 - 创建现金红包 (普通商户)
    /// </summary>
    public class QPayHbMchSendRequest : IQPayCertRequest<QPayHbMchSendResponse>
    {
        /// <summary>
        /// 字符集
        /// </summary>
        public string Charset { get; set; } = "UTF-8";

        /// <summary>
        /// 商户订单号
        /// </summary>
        public string MchBillNo { get; set; }

        /// <summary>
        /// 商户名称
        /// </summary>
        public string MchName { get; set; }

        /// <summary>
        /// 接收者openid
        /// </summary>
        public string ReOpenId { get; set; }

        /// <summary>
        /// 发放总金额
        /// </summary>
        public long TotalAmount { get; set; }

        /// <summary>
        /// 红包发放总人数
        /// </summary>
        public int TotalNum { get; set; }

        /// <summary>
        /// 红包祝福语
        /// </summary>
        public string Wishing { get; set; }

        /// <summary>
        /// 活动名称
        /// </summary>
        public string ActName { get; set; }

        /// <summary>
        /// 商户logo图片ID
        /// </summary>
        public int IconId { get; set; }

        /// <summary>
        /// 商户banner图片ID
        /// </summary>
        public int BannerId { get; set; }

        /// <summary>
        /// 红包领取结果通知
        /// </summary>
        public string NotifyUrl { get; set; }

        /// <summary>
        /// 是否发送公众号消息链接
        /// </summary>
        public int NotSendMsg { get; set; }

        /// <summary>
        /// 最小红包金额
        /// </summary>
        public long MinValue { get; set; }

        /// <summary>
        /// 最大红包金额
        /// </summary>
        public long MaxValue { get; set; }

        #region IQPayRequest Members

        public string GetRequestUrl()
        {
            return "https://api.qpay.qq.com/cgi-bin/hongbao/qpay_hb_mch_send.cgi";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new QPayDictionary
            {
                { "charset", Charset },
                { "mch_billno", MchBillNo },
                { "mch_name", MchName },
                { "re_openid", ReOpenId },
                { "total_amount", TotalAmount },
                { "total_num", TotalNum },
                { "wishing", Wishing },
                { "act_name", ActName },
                { "icon_id", IconId },
                { "banner_id", BannerId },
                { "notify_url", NotifyUrl },
                { "not_send_msg", NotSendMsg },
                { "min_value", MinValue },
                { "max_value", MaxValue },
            };
            return parameters;
        }

        public void PrimaryHandler(QPayOptions options, QPayDictionary sortedTxtParams)
        {
            sortedTxtParams.Add(QPayConsts.NONCE_STR, QPayUtility.GenerateNonceStr());
            sortedTxtParams.Add(QPayConsts.MCH_ID, options.MchId);
            sortedTxtParams.Add(QPayConsts.QQAPPID, options.AppId);

            sortedTxtParams.Add(QPayConsts.SIGN, QPaySignature.SignWithKey(sortedTxtParams, options.Key));
        }

        public bool GetNeedCheckSign()
        {
            return false;
        }

        #endregion
    }
}
