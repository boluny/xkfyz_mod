using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xkfy_mod.Domain;
using xkfy_mod.Helper;

namespace xkfy_mod.Facade
{
    class StoreItemFacade
    {
        enum ColumnName : ushort
        {
            iStoreID,
            sStoreNama,
            sStroreIconID,
            iRandom,
            sRandom,
            sItemID,
            sBuyamount,
            iAddReset,
            iAddBackpack,
            iCheckAch,
            iStoreType
        }
        private const string TB_NAME_STORE_DATA = "StoreData";
        private const string TB_NAME_ITEM_DATA = "ItemData";
        private const string TB_NAME_STRING_TABLE = "String_table";

        private readonly DataTable _table;
        public StoreItemFacade()
        {
            FileHelper.LoadTable(TB_NAME_STRING_TABLE);
            FileHelper.LoadTable(TB_NAME_ITEM_DATA);
            FileHelper.LoadTable(TB_NAME_STORE_DATA);
            _table = DataHelper.XkfyData.Tables[TB_NAME_STORE_DATA];
        }

        private StoreItem GenerateStoreItem(DataRow row)
        {
            //string queryStr = $"iStoreID='{id}'";
            //var rows = _table.Select(queryStr);

            var quantity = UInt32.Parse(row.Field<string>(ColumnName.sBuyamount.ToString()));

            var randMax = UInt32.Parse(row.Field<string>(ColumnName.sRandom.ToString()));
            var randMin = UInt32.Parse(row.Field<string>(ColumnName.iRandom.ToString()));
            uint possibility = 100;
            if (randMax != randMin) { 
                possibility = (randMax - randMin + 1) * 10;
            }

            var storeId = row.Field<string>(ColumnName.sStoreNama.ToString());
            var storeName = DataHelper.GetValue("String_table", "sString", "iID", storeId);

            // assume item should be there
            var itemId = row.Field<string>(ColumnName.sItemID.ToString());
            var itemName = DataHelper.GetValue("ItemData", "sItemName$1", "iItemID$0", itemId);
            var price = DataHelper.GetValue("ItemData", "iItemBuy$6", "iItemID$0", itemId);
            

            StoreItem storeItem = new StoreItem()
            {
                StoreName = storeName,
                ProductName = itemName,
                Quantity = quantity,
                Price = UInt32.Parse(price),
                Possibility = possibility
            };

            return storeItem;
        }

        public Dictionary<string, List<StoreItem>> GetStoreInformationMap()
        {
            Dictionary<string, List<StoreItem>> storeInformationMap = new Dictionary<string,List<StoreItem>>();

            foreach (DataRow row in _table.Rows)
            {
                StoreItem item = GenerateStoreItem(row);
                var key = item.StoreName;
                if (!storeInformationMap.ContainsKey(key))
                {
                    storeInformationMap[key] = new List<StoreItem>();
                }

                storeInformationMap[key].Add(item);
            }

            return storeInformationMap;
        }
    }
}
