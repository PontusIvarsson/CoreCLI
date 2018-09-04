using System;
using System.Collections.Generic;
using System.Text;

namespace Handlers.Base
{

    public abstract class HandlerBase<T> where T: IResponse
    { 

        public T Handle2<T3>(T3 command) where T3 : ICommandBase
        {
            return DoHandle(command);
        }
        

        protected abstract T DoHandle(ICommandBase command);

    }
}
