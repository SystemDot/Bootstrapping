namespace SystemDot.Bootstrapping
{
    using System;
    using System.Collections.Generic;

    public interface IApplication
    {
        IEnumerable<Type> GetAllTypes();
    }
}