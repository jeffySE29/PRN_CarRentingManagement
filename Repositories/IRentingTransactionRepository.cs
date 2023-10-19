using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IRentingTransactionRepository
    {
        List<RentingTransaction> GetRentingTransactionsList();

        List<RentingDetail> GetRentingDetailsList();

        RentingTransaction GetRentingTransactionById(int tranId);

        void CreateRentingTransaction(RentingTransaction renTran);

        void UpdateRentingTransaction(RentingTransaction renTran);

        void DeleteRentingTransaction(RentingTransaction renTran);

        void CreateRentingDetail(RentingDetail renDet);

        void UpdateRentingDetail(RentingDetail renDet);

        void DeleteRentingDetail(RentingDetail renDet);

        List<RentingDetail> GetRentingDetailsFromTo(DateTime from, DateTime to);

        int GetRentingTransactionsMaxId();
        List<RentingTransaction> GetRentingListByCusID(int cusId);
    }
}
