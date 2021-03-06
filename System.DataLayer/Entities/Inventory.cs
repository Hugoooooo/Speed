﻿using System.Framework.DataLayer;
using System.DataLayer.Base;
using System;

namespace System.DataLayer.Entities
{
    /// <summary>
    /// Account
    /// </summary>
    public class Inventory : BaseEntity
    {
        #region Name Config
        public enum ncConditions { serno, sernolist }
        public enum ncFields { INV_SERNO, INV_VENDOR, INV_NAME, INV_STATUS, INV_INAMT, INV_INDTTM, INV_INCOMMENT, INV_OUTAMT, INV_OUTDTTM, INV_OUTCOMMENT, INV_OUTDEALER, INV_MODIFIEDBY, INV_MODIFIEDDTTM  , INV_RETURNAMT, INV_RETURNCOMMENT, INV_RETURNDTTM, INV_TYPE, INV_COLOR, INV_SIZE }
        #endregion
        #region Fields

        /// <summary>序號</summary>
        public string INV_SERNO = "";
        /// <summary>商品供應商</summary>
        public string INV_VENDOR = "";
        /// <summary>商品名稱</summary>
        public string INV_NAME = "";
        /// <summary>商品類型</summary>
        public string INV_TYPE = "";
        /// <summary>商品顏色</summary>
        public string INV_COLOR = "";
        /// <summary>商品尺寸</summary>
        public string INV_SIZE = "";
        /// <summary>狀態</summary>
        public string INV_STATUS = "";
        /// <summary>進貨金額</summary>
        public int INV_INAMT = 0;
        /// <summary>進貨備註</summary>
        public string INV_INCOMMENT = "";
        /// <summary>出貨金額</summary>
        public int INV_OUTAMT = 0 ;
        /// <summary>出貨備註</summary>
        public string INV_OUTCOMMENT = "";
        /// <summary>負責人</summary>
        public string INV_OUTDEALER = "";
        /// <summary>修改人員</summary>
        public string INV_MODIFIEDBY = "";
        /// <summary>進貨日期</summary>
        public DateTime INV_INDTTM;
        /// <summary>出貨日期</summary>
        public DateTime INV_OUTDTTM;
        /// <summary>修改日期</summary>
        public DateTime INV_MODIFIEDDTTM;
        /// <summary>退貨金額</summary>
        public int INV_RETURNAMT = 0;
        /// <summary>退貨備註</summary>
        public string INV_RETURNCOMMENT = "";
        /// <summary>退貨日期</summary>
        public DateTime INV_RETURNDTTM;

        #endregion
        /// <summary>
        /// 建構式
        /// </summary>
        /// <param name="AConn">資料庫連接物件介面</param>
        public Inventory(IConnection AConn)
            : base(AConn)
        {
            this.TableName = "INVENTORY";
            base.addKey("INV_SERNO");
            this.ConditionDictionary["serno"] = " INV_SERNO = N'?' ";
            this.ConditionDictionary["sernolist"] = " INV_SERNO IN (?) ";
        }
    }
}
