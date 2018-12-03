using System;
using System.Framework;
using System.Framework.DataLayer;

namespace System.DataLayer.Views
{
    /// <summary>
    /// Account ���K�n�y�z�C
    /// </summary>
    public class InventroyRPTInfo : BaseView
    {
        #region Name Config
        public enum ncConditions { vendor, name, importSDTTM, importEDTTM, exportSDTTM, exportEDTTM, status, dealer  , returnSDTTM, returnEDTTM }
        public enum ncFields { INV_SERNO, INV_NAME , SERNOLIST , STOCK, INCOUNT, INTOTAL, OUTCOUNT, OUTTOTAL, RETURNCOUNT, RETURNTOTAL, NET, INV_TYPE, INV_COLOR, INV_SIZE }
        public enum ncSort { Default }
        #endregion

        #region Fields

        /// <summary>�Ǹ�</summary>
        public string INV_SERNO = "";
        /// <summary>����</summary>
        public string INV_NAME = "";
        /// <summary>�ӫ~����</summary>
        public string INV_TYPE = "";
        /// <summary>�ӫ~�C��</summary>
        public string INV_COLOR = "";
        /// <summary>�ӫ~�ؤo</summary>
        public string INV_SIZE = "";
        /// <summary>�Ǹ��C</summary>
        public string SERNOLIST = "";
        /// <summary>�w�s</summary>
        public string STOCK = "";
        /// <summary>�i�f�`��</summary>
        public int INCOUNT = 0;
        /// <summary>�i�f�`�B</summary>
        public int INTOTAL = 0;
        /// <summary>�X�f�`��</summary>
        public int OUTCOUNT = 0;
        /// <summary>�X�f�`�B</summary>
        public int OUTTOTAL = 0;
        /// <summary>�h�f�`��</summary>
        public int RETURNCOUNT = 0;
        /// <summary>�h�f�`�B</summary>
        public int RETURNTOTAL = 0;
        /// <summary>�b�B�B</summary>
        public int NET = 0;

        #endregion

        public void condFormat(string cond)
        {
            base.Fields = string.Format(base.Fields, cond);
        }

        public InventroyRPTInfo(IConnection AConn)
            : base(AConn)
        {
            base.Fields = @" INV_NAME,INV_TYPE,INV_COLOR,INV_SIZE, STUFF(( SELECT  ',' + INV_SERNO FROM INVENTORY T WHERE INV_NAME=MAIN.INV_NAME AND INV_TYPE=MAIN.INV_TYPE AND INV_COLOR=MAIN.INV_COLOR AND INV_SIZE =MAIN.INV_SIZE  {0} FOR XML PATH( '' )), 1 , 1 , '' ) AS SERNOLIST
                        ,SUM(CASE INV_STATUS WHEN  '" + InventoryStatus.�w�s�� + @"' THEN 1 ELSE 0 END) AS 'STOCK'
						,COUNT(*) AS 'INCOUNT'
						,SUM(INV_INAMT) AS 'INTOTAL'
                        ,SUM(CASE INV_STATUS WHEN  '" + InventoryStatus.�w�X�f + @"' THEN 1 ELSE 0 END) AS 'OUTCOUNT'
						,SUM(INV_OUTAMT) AS 'OUTTOTAL'
                        ,SUM(CASE INV_STATUS WHEN  '" + InventoryStatus.�w�h�f + @"' THEN 1 ELSE 0 END) AS 'RETURNCOUNT'
						,SUM(INV_RETURNAMT) AS 'RETURNTOTAL'
						,SUM(INV_OUTAMT + INV_RETURNAMT - INV_INAMT) AS 'NET' ";
            
            base.From = "INVENTORY MAIN";
            this.GroupBy = "INV_NAME,INV_TYPE,INV_COLOR,INV_SIZE";
            
            base.ConditionDictionary.Add("vendor", " INV_VENDOR = N'?' ");
            base.ConditionDictionary.Add("name", " INV_NAME like N'%?%' ");
            base.ConditionDictionary.Add("importSDTTM", " left(INV_INDTTM,10) >= N'?'");
            base.ConditionDictionary.Add("importEDTTM", " left(INV_INDTTM,10) <= N'?'");
            base.ConditionDictionary.Add("exportSDTTM", " left(INV_OUTDTTM,10) >= N'?'");
            base.ConditionDictionary.Add("exportEDTTM", " left(INV_OUTDTTM,10) <= N'?'");
            base.ConditionDictionary.Add("returnSDTTM", " left(INV_RETURNDTTM,10) >= N'?'");
            base.ConditionDictionary.Add("returnEDTTM", " left(INV_RETURNDTTM,10) <= N'?'");
            base.ConditionDictionary.Add("status", " INV_STATUS = N'?' ");
            base.ConditionDictionary.Add("dealer", " INV_OUTDEALER = N'?' ");


            base.OrderByDictionary.Add("Default", " INV_NAME desc ");
            base.OrderByDictionary.Add("dgvInventory_Name", " INV_NAME ");
            base.OrderByDictionary.Add("dgvInventory_Count", " ITEMTOTAL ");
            base.OrderByDictionary.Add("dgvInventory_INAMT", " INAMT ");
            base.OrderByDictionary.Add("dgvInventory_OUTAMT", " OUTAMT ");
            base.OrderByDictionary.Add("dgvInventory_RETURNAMT", " RETURNAMT ");
        }
       

    }

}
