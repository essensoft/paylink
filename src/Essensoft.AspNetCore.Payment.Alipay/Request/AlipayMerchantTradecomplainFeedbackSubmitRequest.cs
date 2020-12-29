using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.Alipay.Response;

namespace Essensoft.AspNetCore.Payment.Alipay.Request
{
    /// <summary>
    /// alipay.merchant.tradecomplain.feedback.submit
    /// </summary>
    public class AlipayMerchantTradecomplainFeedbackSubmitRequest : IAlipayRequest<AlipayMerchantTradecomplainFeedbackSubmitResponse>
    {
        /// <summary>
        /// 支付宝侧投诉单号
        /// </summary>
        public string ComplainEventId { get; set; }

        /// <summary>
        /// 反馈类目ID 00:使用体验保障金退款； 02:通过其他方式退款; 03:已发货; 04:其他; 05:已完成售后服务; 06:非我方责任范围；
        /// </summary>
        public string FeedbackCode { get; set; }

        /// <summary>
        /// 反馈内容，字数不超过200个字
        /// </summary>
        public string FeedbackContent { get; set; }

        /// <summary>
        /// 商家处理投诉时反馈凭证的图片id，多个逗号隔开（图片id可以通过"商户上传处理图片"接口获取）
        /// </summary>
        public string FeedbackImages { get; set; }

        /// <summary>
        /// 处理投诉人，字数不超过6个字
        /// </summary>
        public string Operator { get; set; }

        #region IAlipayRequest Members
        private bool needEncrypt = false;
        private string apiVersion = "1.0";
        private string terminalType;
        private string terminalInfo;
        private string prodCode;
        private string notifyUrl;
        private string returnUrl;
        private AlipayObject bizModel;

        public void SetNeedEncrypt(bool needEncrypt)
        {
            this.needEncrypt = needEncrypt;
        }

        public bool GetNeedEncrypt()
        {
            return needEncrypt;
        }

        public void SetNotifyUrl(string notifyUrl)
        {
            this.notifyUrl = notifyUrl;
        }

        public string GetNotifyUrl()
        {
            return notifyUrl;
        }

        public void SetReturnUrl(string returnUrl)
        {
            this.returnUrl = returnUrl;
        }

        public string GetReturnUrl()
        {
            return returnUrl;
        }

        public void SetTerminalType(string terminalType)
        {
            this.terminalType = terminalType;
        }

        public string GetTerminalType()
        {
            return terminalType;
        }

        public void SetTerminalInfo(string terminalInfo)
        {
            this.terminalInfo = terminalInfo;
        }

        public string GetTerminalInfo()
        {
            return terminalInfo;
        }

        public void SetProdCode(string prodCode)
        {
            this.prodCode = prodCode;
        }

        public string GetProdCode()
        {
            return prodCode;
        }

        public string GetApiName()
        {
            return "alipay.merchant.tradecomplain.feedback.submit";
        }

        public void SetApiVersion(string apiVersion)
        {
            this.apiVersion = apiVersion;
        }

        public string GetApiVersion()
        {
            return apiVersion;
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new AlipayDictionary
            {
                { "complain_event_id", ComplainEventId },
                { "feedback_code", FeedbackCode },
                { "feedback_content", FeedbackContent },
                { "feedback_images", FeedbackImages },
                { "operator", Operator }
            };
            return parameters;
        }

        public AlipayObject GetBizModel()
        {
            return bizModel;
        }

        public void SetBizModel(AlipayObject bizModel)
        {
            this.bizModel = bizModel;
        }

        #endregion
    }
}
