using Business.Abstracts;
using Core.Utilities.Results;
using DataAcces.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class CollectionPaymentsManager : ICollectionPaymentsService
    {
        ICollectionPaymentsDal _collectionPayments;
        ISafeBalanceService _safeBalanceService;
        public CollectionPaymentsManager(ICollectionPaymentsDal collectionPayments, ISafeBalanceService safeBalanceService)
        {
            _collectionPayments = collectionPayments;
            _safeBalanceService = safeBalanceService;
        }

        public IResult Add(CollectionPayments collectionPayments)
        {
            _collectionPayments.Add(collectionPayments);
            return new SuccessResult();
        }

        public IDataResult<List<CollectionPayments>> GetAll()
        {
            return new SuccessDataResult<List<CollectionPayments>>(_collectionPayments.GetAll());
        }

        public IDataResult<CollectionPayments> Transaction(CollectionPayments collectionPayments)
        {
            // Ensure collectionPayments is not null
            if (collectionPayments == null)
            {
                return new ErrorDataResult<CollectionPayments>("CollectionPayments object is null.");
            }

            var amount = collectionPayments.Ammount;
            int safeId = collectionPayments.SafeId;

            if (amount <= 0)
            {
                return new ErrorDataResult<CollectionPayments>("Invalid amount.");
            }

            if (collectionPayments.TransactionC == 'T' || collectionPayments.TransactionC == 'O')
            {
                var balanceResult = _safeBalanceService.GetById(safeId);
                if (balanceResult?.Data != null)
                {
                    var balance = balanceResult.Data;

                    if (collectionPayments.TransactionC == 'T')
                    {
                        balance.Balance += amount;
                    }
                    else if (collectionPayments.TransactionC == 'O')
                    {
                        balance.Balance -= amount;
                    }

                    // Güncelleme işlemini yap
                    _safeBalanceService.Update(balance);

                    // Yeni CollectionPayments nesnesini veritabanına ekle
                    _collectionPayments.Add(collectionPayments);

                    return new SuccessDataResult<CollectionPayments>(collectionPayments.TransactionC == 'T' ? "Tahsilat Gerçekleşti" : "Ödeme Gerçekleşti");
                }
                else
                {
                    return new ErrorDataResult<CollectionPayments>("Safe balance not found.");
                }
            }

            return new ErrorDataResult<CollectionPayments>("Invalid transaction type.");
        }

    }
}
