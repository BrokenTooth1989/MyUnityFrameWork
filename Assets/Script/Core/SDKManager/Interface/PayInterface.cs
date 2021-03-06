﻿using FrameWork.SDKManager;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace FrameWork.SDKManager
{
    public abstract class PayInterface : SDKInterfaceBase
    {
        public PayCallBack m_PayResultCallBack;
        /// <summary>
        /// 验证回调，参数：string（商店名）,string（订单凭据，base64加密串）
        /// </summary>
        public CallBack<StoreName, string> m_ConfirmCallBack;

        virtual public void Pay(string goodsID, string tag, GoodsType goodsType = GoodsType.NORMAL, string orderID = null)
        {

        }

        virtual public void ConfirmPay(string goodsID, string tag)
        {

        }

        virtual public LocalizedGoodsInfo GetGoodsInfo(string goodsID)
        {
            return null;
        }

        virtual public List<LocalizedGoodsInfo> GetAllGoodsInfo()
        {
            return null;
        }

        public override void Init()
        {

        }
    }
    /// <summary>
    /// 本地化商品信息，来自SDK平台的后台，如：
    /// localizedPriceString :¥6.00
    ///localizedTitle :小包钻石
    ///localizedDescription :钻石可以在游戏内用于购买各项商品
    ///isoCurrencyCode :CNY
    ///localizedPrice :6
    /// </summary>
    public class LocalizedGoodsInfo
    {
        /// <summary>
        /// id
        /// </summary>
        public string goodsID;
        /// <summary>
        /// 描述串
        /// </summary>
        public string localizedPriceString;
        /// <summary>
        /// 标题
        /// </summary>
        public string localizedTitle;
        /// <summary>
        /// 商店描述
        /// </summary>
        public string localizedDescription;
        /// <summary>
        /// 货币类型
        /// </summary>
        public string isoCurrencyCode;
        /// <summary>
        /// 价格
        /// </summary>
        public decimal localizedPrice;
    }
}
