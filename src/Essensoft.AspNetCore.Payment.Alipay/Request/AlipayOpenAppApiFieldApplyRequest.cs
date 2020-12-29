using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.Alipay.Domain;
using Essensoft.AspNetCore.Payment.Alipay.Response;
using Essensoft.AspNetCore.Payment.Alipay.Utility;

namespace Essensoft.AspNetCore.Payment.Alipay.Request
{
    /// <summary>
    /// alipay.open.app.api.field.apply
    /// </summary>
    public class AlipayOpenAppApiFieldApplyRequest : IAlipayUploadRequest<AlipayOpenAppApiFieldApplyResponse>
    {
        /// <summary>
        /// 字段申请表单，其中api_name，field_name，package_code三个字段参数通过alipay.open.app.api.query接口查询获得，scene_code 则可通过alipay.open.app.api.scene.query接口查询获得。
        /// </summary>
        public AuthFieldApply AuthFieldApply { get; set; }

        /// <summary>
        /// 请上传应用使用图片必须包括如何登录、如何授权输出此字段、如何使用等内容。图片支持格式:png,jpg,jpeg,图片不超过10M。 video或picture_x不可同时为空，至少需传入1个。
        /// </summary>
        public FileItem Picture1 { get; set; }

        /// <summary>
        /// 请上传应用使用图片必须包括如何登录、如何授权输出此字段、如何使用等内容。图片支持格式:png,jpg,jpeg,图片不超过10M。 video或picture_x不可同时为空，至少需传入1个。
        /// </summary>
        public FileItem Picture2 { get; set; }

        /// <summary>
        /// 请上传应用使用图片必须包括如何登录、如何授权输出此字段、如何使用等内容。图片支持格式:png,jpg,jpeg,图片不超过10M。 video或picture_x不可同时为空，至少需传入1个。
        /// </summary>
        public FileItem Picture3 { get; set; }

        /// <summary>
        /// 请上传应用使用图片必须包括如何登录、如何授权输出此字段、如何使用等内容。图片支持格式:png,jpg,jpeg,图片不超过10M。 video或picture_x不可同时为空，至少需传入1个。
        /// </summary>
        public FileItem Picture4 { get; set; }

        /// <summary>
        /// 请上传应用使用图片必须包括如何登录、如何授权输出此字段、如何使用等内容。图片支持格式:png,jpg,jpeg,图片不超过10M。 video或picture_x不可同时为空，至少需传入1个。
        /// </summary>
        public FileItem Picture5 { get; set; }

        /// <summary>
        /// 请上传应用使用视频，必须包括如何登录、如何授权输出此字段、如何使用等内容。视频支持格式:MP4,视频不超过10M。 video或picture_x不可同时为空，至少需传入1个。
        /// </summary>
        public FileItem Video { get; set; }

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
            return "alipay.open.app.api.field.apply";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new AlipayDictionary
            {
                { "auth_field_apply", AuthFieldApply }
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
                { "picture_1", Picture1 },
                { "picture_2", Picture2 },
                { "picture_3", Picture3 },
                { "picture_4", Picture4 },
                { "picture_5", Picture5 },
                { "video", Video }
            };
            return parameters;
        }

        #endregion
    }
}
