using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.Alipay.Response;
using Essensoft.AspNetCore.Payment.Alipay.Utility;

namespace Essensoft.AspNetCore.Payment.Alipay.Request
{
    /// <summary>
    /// alipay.ins.data.dsb.image.upload
    /// </summary>
    public class AlipayInsDataDsbImageUploadRequest : IAlipayUploadRequest<AlipayInsDataDsbImageUploadResponse>
    {
        /// <summary>
        /// 保险公司定损单号，唯一标识一个定损单的id
        /// </summary>
        public string EstimateNo { get; set; }

        /// <summary>
        /// 车架号
        /// </summary>
        public string FrameNo { get; set; }

        /// <summary>
        /// 图片二进制字节流，上传图片是文件提交方式的必须提供该字段。  提供可下载的图片url或图片存储拉取方式的保司可不传该字段
        /// </summary>
        public FileItem ImageContent { get; set; }

        /// <summary>
        /// 图像格式类型，目前仅支持jpg格式
        /// </summary>
        public string ImageFormat { get; set; }

        /// <summary>
        /// 图像文件名称
        /// </summary>
        public string ImageName { get; set; }

        /// <summary>
        /// 图像文件在存储上的路径，与蚂蚁接口负责人确定上传方式是图片url拉取、通过oss拉取等方式可行后传入该字段。  该字段与图片二进制流参数选传其一。
        /// </summary>
        public string ImagePath { get; set; }

        /// <summary>
        /// 图片扩展属性信息json格式,如照片拍摄参数等
        /// </summary>
        public string ImageProperties { get; set; }

        /// <summary>
        /// 图片来源描述，如weixin、app等
        /// </summary>
        public string ImageSource { get; set; }

        /// <summary>
        /// 照片存储类型，枚举值如下   OSS-阿里云oss存储   SELF-自建类型
        /// </summary>
        public string ImageStoreType { get; set; }

        /// <summary>
        /// 图片类型，比如：car_damage(车损图像)、certificate(证照图像)、material(资料图像)、other(其他图像)
        /// </summary>
        public string ImageType { get; set; }

        /// <summary>
        /// 车牌号
        /// </summary>
        public string LicenseNo { get; set; }

        /// <summary>
        /// 报案号,2017-10-12后接入的公司必传该字段
        /// </summary>
        public string ReportNo { get; set; }

        /// <summary>
        /// 照片拍摄时间，精确到秒，格式yyyyMMddHHmmss
        /// </summary>
        public string ShootTime { get; set; }

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
            return "alipay.ins.data.dsb.image.upload";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new AlipayDictionary
            {
                { "estimate_no", EstimateNo },
                { "frame_no", FrameNo },
                { "image_format", ImageFormat },
                { "image_name", ImageName },
                { "image_path", ImagePath },
                { "image_properties", ImageProperties },
                { "image_source", ImageSource },
                { "image_store_type", ImageStoreType },
                { "image_type", ImageType },
                { "license_no", LicenseNo },
                { "report_no", ReportNo },
                { "shoot_time", ShootTime }
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
                { "image_content", ImageContent }
            };
            return parameters;
        }

        #endregion
    }
}
