﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace WCFClient
{
    class PicoscopeThread
    {
        WCFClient.FormClient client_;
        bool end_ = false;

        public PicoscopeThread(WCFClient.FormClient client)
        {
            client_ = client;
        }

        public bool getEnd()
        {
            return end_;
        }

        public void setEnd(bool end)
        {
            end_ = end;
        }

        public void ThreadLoop()
        {
            end_ = false;
            client_.captureBlock();
            end_ = true;
        }
    }
}