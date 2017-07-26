using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.ComponentModel;
using System.Reflection;

namespace GroupAssignment
{
    class clsSQL : INotifyPropertyChanged
    {
        DataSet ds = new DataSet();

        clsDataAccess db = new clsDataAccess();

        public DataView getData()
        {
            try
            {
                //Number of return values
                int iRet = 0;
                //Get the data to be put into the DataGridView
                ds = db.ExecuteSQLStatement("SELECT * FROM ItemDesc ORDER BY ItemCode", ref iRet);
                //Set the table name in the DataSet
                ds.Tables[0].TableName = "Item Table";

                return ds.Tables[0].DefaultView;
            }
            catch (Exception ex)
            {
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." + MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }

        /// <summary>
        /// addes a new row with passed in values into the Database. 
        /// </summary>
        /// <param name="itemDesc"></param>
        /// <param name="cost"></param>
        public void addNewItem(string itemCode, string itemDesc, string cost)
        {
            try
            {
                string sSQL = "INSERT INTO ItemDesc (ItemCode, ItemDesc, Cost) VALUES ('" + itemCode + "', '" + itemDesc + "', " + cost + ")";
                db.ExecuteNonQuery(sSQL);
            }
            catch (Exception ex)
            {
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." + MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }

        /// <summary>
        /// updates the line that the item code is a part of with the passed in values
        /// </summary>
        /// <param name="itemCode"></param>
        /// <param name="itemDesc"></param>
        /// <param name="cost"></param>
        public void updateItem(string itemCode, string itemDesc, string cost)
        {
            try
            {
                string sSQL = "UPDATE ItemDesc SET ItemDesc = '" + itemDesc + "', Cost = '" + cost + "' WHERE ItemCode = '" + itemCode + "'";
                db.ExecuteNonQuery(sSQL);
            }
            catch (Exception ex)
            {
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." + MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }

        /// <summary>
        /// Deletes the row that the passed in item code is a part of
        /// </summary>
        /// <param name="itemCode"></param>
        public void deleteItem(string itemCode)
        {
            try
            {
                string sSQL = "DELETE FROM ItemDesc WHERE ItemCode = '" + itemCode + "'";
                db.ExecuteNonQuery(sSQL);
            }
            catch (Exception ex)
            {
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." + MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
