using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.Alipay.Response;
using Essensoft.AspNetCore.Payment.Alipay.Utility;

namespace Essensoft.AspNetCore.Payment.Alipay.Request
{
    /// <summary>
    /// alipay.open.mini.ampe.enter.apply
    /// </summary>
    public class AlipayOpenMiniAmpeEnterApplyRequest : IAlipayUploadRequest<AlipayOpenMiniAmpeEnterApplyResponse>
    {
        /// <summary>
        /// 详细地址
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// 联系人邮箱
        /// </summary>
        public string ContactEmail { get; set; }

        /// <summary>
        /// 联系人姓名
        /// </summary>
        public string ContactName { get; set; }

        /// <summary>
        /// 联系人手机号
        /// </summary>
        public string ContactPhone { get; set; }

        /// <summary>
        /// 厂商名称，必填，最大长度为128
        /// </summary>
        public string EnterpriseName { get; set; }

        /// <summary>
        /// 介绍资料，选填，最小为1k，最大不能超过10MB，文件格式支持zip，rar，jpg，png，doc，docx，pdf
        /// </summary>
        public FileItem IntroductionFile { get; set; }

        /// <summary>
        /// 企业营业执照照片二进制流，必填，最小为1k，最大不能超过5MB，图片格式支持jpg，png
        /// </summary>
        public FileItem LicensePic { get; set; }

        /// <summary>
        /// 主营产品信息，选填
        /// </summary>
        public string MajorProducts { get; set; }

        /// <summary>
        /// 企业官网，选填，最大长度为128
        /// </summary>
        public string OfficialWebsite { get; set; }

        /// <summary>
        /// 场景码，申请后平台分配，必填
        /// </summary>
        public string SceneCode { get; set; }

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
            return "alipay.open.mini.ampe.enter.apply";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new AlipayDictionary
            {
                { "address", Address },
                { "contact_email", ContactEmail },
                { "contact_name", ContactName },
                { "contact_phone", ContactPhone },
                { "enterprise_name", EnterpriseName },
                { "major_products", MajorProducts },
                { "official_website", OfficialWebsite },
                { "scene_code", SceneCode }
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
                { "introduction_file", IntroductionFile },
                { "license_pic", LicensePic }
            };
            return parameters;
        }

        #endregion
    }
}
