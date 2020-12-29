using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.Alipay.Response;
using Essensoft.AspNetCore.Payment.Alipay.Utility;

namespace Essensoft.AspNetCore.Payment.Alipay.Request
{
    /// <summary>
    /// alipay.open.public.life.modify
    /// </summary>
    public class AlipayOpenPublicLifeModifyRequest : IAlipayUploadRequest<AlipayOpenPublicLifeModifyResponse>
    {
        /// <summary>
        /// 背景图片，需上传图片原始二进制流，此图片显示在支付宝客户端生活号主页上方背景图位置，后缀是jpg或者jpeg，图片大小限制1mb
        /// </summary>
        public FileItem Background { get; set; }

        /// <summary>
        /// 联系人邮箱，可以是调用者的联系人邮箱
        /// </summary>
        public string ContactEmail { get; set; }

        /// <summary>
        /// 联系人姓名，可以是调用者的联系人姓名
        /// </summary>
        public string ContactName { get; set; }

        /// <summary>
        /// 联系人电话，可以是调用者的联系人电话
        /// </summary>
        public string ContactTel { get; set; }

        /// <summary>
        /// 客服电话，可以是电话号码，手机号码，400电话
        /// </summary>
        public string CustomerTel { get; set; }

        /// <summary>
        /// 生活号描述，此内容显示在支付宝客户端生活号主页简介区块
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 扩展信息JSON串。为空则不修改，不为空则覆盖更新
        /// </summary>
        public string ExtendData { get; set; }

        /// <summary>
        /// 生活号名称
        /// </summary>
        public string LifeName { get; set; }

        /// <summary>
        /// logo图片，需上传图片原始二进制流，此图片显示在支付宝客户端生活号主页上方位置，后缀是jpg或者jpeg，图片大小限制1mb，图片最小150px，图片建议为是正方形。为空则不修改。
        /// </summary>
        public FileItem Logo { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        public string UserId { get; set; }

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

        public void SetApiVersion(string apiVersion)
        {
            this.apiVersion = apiVersion;
        }

        public string GetApiVersion()
        {
            return apiVersion;
        }

        public string GetApiName()
        {
            return "alipay.open.public.life.modify";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new AlipayDictionary
            {
                { "contact_email", ContactEmail },
                { "contact_name", ContactName },
                { "contact_tel", ContactTel },
                { "customer_tel", CustomerTel },
                { "description", Description },
                { "extend_data", ExtendData },
                { "life_name", LifeName },
                { "user_id", UserId }
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

        #region IAlipayUploadRequest Members

        public IDictionary<string, FileItem> GetFileParameters()
        {
            IDictionary<string, FileItem> parameters = new Dictionary<string, FileItem>
            {
                { "background", Background },
                { "logo", Logo }
            };
            return parameters;
        }

        #endregion
    }
}
