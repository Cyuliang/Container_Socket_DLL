using System;

namespace Container_Socket_DLL
{
    public class MessageEventArgs : EventArgs
    {
        public string Message { get; set; }
        public string FunName { get; set; }
    }

}
