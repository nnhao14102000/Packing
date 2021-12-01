using PackIT.Shared.Abstraction.Exceptions;

namespace PackIT.Domain.Exceptions
{
    public class EmptyPackingListItemNameException : PackItException
    {
        public EmptyPackingListItemNameException() : base("Packing item name can not be empty.")
        {
        }
    }
}
