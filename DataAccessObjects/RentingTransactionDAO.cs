using BusinessObjects;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public class RentingTransactionDAO
    {
        private static RentingTransactionDAO instance = null;
        private static object objLock = new object();

        private RentingTransactionDAO() { }

        public static RentingTransactionDAO Instance
        {
            get
            {
                lock (objLock)
                {
                    if (instance == null)
                    {
                        instance = new RentingTransactionDAO();
                    }
                    return instance;
                }
            }
        }

        public List<RentingTransaction> GetRentingTransactionsList()
        {//lấy danh sách rentingtransactions //xem lịch sử giao dịch
            using var db = new FUCarRentingManagementContext();
            return db.RentingTransactions.Include(f => f.Customer).ToList();
        }

        public List<RentingTransaction> GetRentingListByCusID(int cusId)
        {
            var list = GetRentingTransactionsList().FindAll(m => m.CustomerId == cusId);
            return list.ToList();
        }
        public int GetRentingTransactionsMaxId() {
            using var db = new FUCarRentingManagementContext();

            // Sắp xếp danh sách RentingTransactions theo ID giảm dần và lấy ID của phần tử đầu tiên (ID lớn nhất)
            int maxId = db.RentingTransactions.OrderByDescending(rt => rt.RentingTransationId).Select(rt => rt.RentingTransationId).FirstOrDefault();
            return maxId;
        }

        public List<RentingDetail> GetRentingDetailsList()
        {//lấy danh sách rentingdetails
            using var db = new FUCarRentingManagementContext();
            return db.RentingDetails.Include(f => f.Car).Include(f => f.RentingTransaction).ToList();
        }

        public RentingTransaction GetRentingTransactionById(int tranId)
        {//lấy car infomation theo id
            var temp = GetRentingTransactionsList().
                SingleOrDefault((m) => m.RentingTransationId == tranId);
            return temp;
        }

        public void CreateRentingTransaction(RentingTransaction renTran)
        {
            //tạo mới carInfo
            using var db = new FUCarRentingManagementContext();
            db.RentingTransactions.Add(renTran);
            db.SaveChanges();
        }

        public void UpdateRentingTransaction(RentingTransaction renTran)
        {
            //update carInfo
            using var db = new FUCarRentingManagementContext();
            db.RentingTransactions.Update(renTran);
            db.SaveChanges();
        }

        public void DeleteRentingTransaction(RentingTransaction renTran)
        {
            //update carInfo
            using var db = new FUCarRentingManagementContext();
            db.RentingTransactions.Update(renTran);
            db.SaveChanges();
        }

        public void CreateRentingDetail(RentingDetail renDet)
        {
            //tạo mới carInfo
            using var db = new FUCarRentingManagementContext();
            db.RentingDetails.Add(renDet);
            db.SaveChanges();
        }

        public void UpdateRentingDetail(RentingDetail renDet)
        {
            //update carInfo
            using var db = new FUCarRentingManagementContext();
            db.RentingDetails.Update(renDet);
            db.SaveChanges();
        }

        public void DeleteRentingDetail(RentingDetail renDet)
        {
            //update carInfo
            using var db = new FUCarRentingManagementContext();
            db.RentingDetails.Update(renDet);
            db.SaveChanges();
        }

        public List<RentingDetail> GetRentingDetailsFromTo(DateTime from, DateTime to)
        {
            var temp = GetRentingDetailsList().FindAll(m => m.StartDate >= from && m.StartDate <= to);
            return temp;
        }

    }
}
