﻿using PackIT.Shared.Abstraction.Exceptions;

namespace PackIT.Domain.Exceptions
{
    public class EmptyPackingListNameException : PackItException
    {
        public EmptyPackingListNameException() : base("Packing list name can not be empty.")
        {
        }
    }
}
