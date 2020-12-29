using System;
using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.Alipay.Response;
using Essensoft.AspNetCore.Payment.Alipay.Utility;

namespace Essensoft.AspNetCore.Payment.Alipay.Request
{
    /// <summary>
    /// alipay.open.mini.ampe.product.create
    /// </summary>
    public class AlipayOpenMiniAmpeProductCreateRequest : IAlipayUploadRequest<AlipayOpenMiniAmpeProductCreateResponse>
    {
        /// <summary>
        /// 行业类目
        /// </summary>
        public string CategoryId { get; set; }

        /// <summary>
        /// 设备类型
        /// </summary>
        public string DeviceType { get; set; }

        /// <summary>
        /// 设备产品名称, 必填，最大长度32，单oid下唯一
        /// </summary>
        public string ProductName { get; set; }

        /// <summary>
        /// 产品图片二进制流，必填，最小为1k，最大不能超过5MB，图片格式只支持jpg，png
        /// </summary>
        public FileItem ProductPic { get; set; }

        /// <summary>
        /// 场景码，申请后平台分配
        /// </summary>
        public string SceneCode { get; set; }

        /// <summary>
        /// 出货量
        /// </summary>
        public Nullable<long> ShipQuantity { get; set; }

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
            return "alipay.open.mini.ampe.product.create";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new AlipayDictionary
            {
                { "category_id", CategoryId },
                { "device_type", DeviceType },
                { "product_name", ProductName },
                { "scene_code", SceneCode },
                { "ship_quantity", ShipQuantity }
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
                { "product_pic", ProductPic }
            };
            return parameters;
        }

        #endregion
    }
}
