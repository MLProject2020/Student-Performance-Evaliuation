using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using educationSector.DLTableAdapters;
using System.Data;

namespace educationSector
{
    public class BLL
    {
        //functions
        DataTable3TableAdapter dt3Obj = new DataTable3TableAdapter();
        DataTable3TableAdapter dt4Obj = new DataTable3TableAdapter();

        tblActualDataTableAdapter actualData = new tblActualDataTableAdapter();
                                                    
        public DataTable GetTestingDataset(string cName, int sem)
        {
            return dt3Obj.GetTestingDataset(cName, sem);
        }
        
        public DataTable GetAllTrainingDataset()
        {
            return dt3Obj.GetAllTrainingDataset();
        }
               
        public DataTable GetTrainingDatasetwithRegNo(string cName, int sem)
        {
            return dt3Obj.GetTrainingDatasetWithRegNo(cName, sem);
        }

        public DataTable GetActualData(string cName,int sem)
        {
            return actualData.GetActualDataByCNameandSem(cName, sem);
        }
              

    }
}