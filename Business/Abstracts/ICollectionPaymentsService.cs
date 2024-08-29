using Core.Utilities.Results;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface ICollectionPaymentsService
    {
        IDataResult<List<CollectionPayments>> GetAll();
        IDataResult<CollectionPayments> Transaction(CollectionPayments collectionPayments);
        IResult Add(CollectionPayments collectionPayments);
    }
}
