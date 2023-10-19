using BusinessObjects;
using DataAccessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class RentingTransactionRepository:IRentingTransactionRepository
    {
        public List<RentingTransaction> GetRentingTransactionsList()
            => RentingTransactionDAO.Instance.GetRentingTransactionsList();

        public List<RentingDetail> GetRentingDetailsList()
            => RentingTransactionDAO.Instance.GetRentingDetailsList();

        public RentingTransaction GetRentingTransactionById(int tranId)
            => RentingTransactionDAO.Instance.GetRentingTransactionById(tranId);

        public void CreateRentingTransaction(RentingTransaction renTran)
            => RentingTransactionDAO.Instance.CreateRentingTransaction(renTran);

        public void UpdateRentingTransaction(RentingTransaction renTran)
            => RentingTransactionDAO.Instance.UpdateRentingTransaction(renTran);
        public void DeleteRentingTransaction(RentingTransaction renTran)
            => RentingTransactionDAO.Instance.DeleteRentingTransaction(renTran);
        public void CreateRentingDetail(RentingDetail renDet)
            => RentingTransactionDAO.Instance.CreateRentingDetail(renDet);
        public void UpdateRentingDetail(RentingDetail renDet)
            => RentingTransactionDAO.Instance.UpdateRentingDetail(renDet);
        public void DeleteRentingDetail(RentingDetail renDet)
            => RentingTransactionDAO.Instance.DeleteRentingDetail(renDet);

        public List<RentingDetail> GetRentingDetailsFromTo(DateTime from, DateTime to)
            => RentingTransactionDAO.Instance.GetRentingDetailsFromTo(from, to);

        public int GetRentingTransactionsMaxId() 
            => RentingTransactionDAO.Instance.GetRentingTransactionsMaxId();

        public List<RentingTransaction> GetRentingListByCusID(int cusId)
            => RentingTransactionDAO.Instance.GetRentingListByCusID(cusId);
    }
}
