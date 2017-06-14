using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace WCFClient
{
    class RoutineThread
    {
        bool stop_ = false;
        FormClient client_;

        public RoutineThread(FormClient client)
        {
            client_ = client;
        }

        public bool getStop()
        {
            return stop_;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            stop_ = true;
        }

        public void ThreadLoop()
        {
            while(!stop_)
            {
                client_.routineLoop();
            }
            stop_ = false;
        }

        public void setStop(bool stop)
        {
            this.stop_ = stop;
        }
    }
}
