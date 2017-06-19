using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace WCFClient
{
    class PicoscopeThread
    {
        WCFClient.FormClient client_;
        bool success_ = false;

        public PicoscopeThread(WCFClient.FormClient client)
        {
            client_ = client;
        }

        public bool success()
        {
            return success_;
        }

        public void ThreadLoop()
        {
            success_ = false;
            /*while (!success_)
            {
                if (!client_.getPulseDone())
                {
                    client_.captureBlock();
                    success_ = client_.getPulseDone();
                    Thread.Sleep(500);
                }
            } 
            */
            client_.captureBlock();
            success_ = true;
        }
    }
}
